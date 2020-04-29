using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.FFMPEG;
using System.Drawing;
using System.Windows.Forms;

namespace Controller.Video
{
    class VideoModify : IVideoModify
    {
        //DECLARE a VideoFileReader which will read the loaded video, call it '_reader'
        private VideoFileReader _reader;
        //DECLARE a VideoFileWriter which will write a new video from frames, call it '_writer'
        private VideoFileWriter _writer;
        //DECLARE an IImageFactoryLocal which will store a reference for imagemodification class
        private IImageFactoryLocal _imageFactory;

        Action<View.ICommand> _execute;

        //Declare a delegate which would check whenever the data has been changed, call it 'DataHasChanged'
        public delegate void ModificationAppliedEventHandler(object source, ModificationAppliedArgs args);
        //Set up an event for cheking for modification apply
        public event ModificationAppliedEventHandler ModificationApplied;

        string _pathfilename;

        public VideoModify(IImageFactoryLocal factor, Action<View.ICommand> execute)
        {
            _reader = new VideoFileReader();
            _writer = new VideoFileWriter();
            _execute = execute;
            _imageFactory = factor;
        }

        /// <summary>
        /// METHOD: which tells when the modification has been applied to video
        /// </summary>
        private void OnModificationApplied()
        {
            ModificationApplied(this, new ModificationAppliedArgs() { Pathfile = _pathfilename});
        }

        /// <summary>
        /// SUBSCRIBE to DataHasChanged event
        /// </summary>
        /// <param name="dataHasBeenChanged"></param>
        public void Subscribe(ModificationAppliedEventHandler modificationApplied)
        {
            ModificationApplied += modificationApplied;
        }

        /// <summary>
        /// UNSUBSCRIBE to DataHasChanged event
        /// </summary>
        /// <param name="dataHasBeenChanged"></param>
        public void Unsubscribe(ModificationAppliedEventHandler modificationApplied)
        {
            ModificationApplied -= modificationApplied;
        }


        public void ApplyModification(string video, string output, Action<int[]> modification, Size videoDimensions, params int[] data)
        {
            //Open Video which will be modified
            _reader.Open(video);
            //Set parameters of how and where the video will be saved
            _writer.Open(output, videoDimensions.Width, videoDimensions.Height, _reader.FrameRate, VideoCodec.MPEG4, 1000000);
            View.ProgressBar progressBar = new View.ProgressBar();
            progressBar.SetBar(0, System.Convert.ToInt32(_reader.FrameCount));
            progressBar.Show();
            //Modify through every frame of the video
            for (int i = 0; i < _reader.FrameCount; i++)
            {
                //Load current frame to modification factory
                _imageFactory.Load(_reader.ReadVideoFrame() as Image);
                //Create a command which applies the effect
                View.ICommand modify = new View.Command<int[]>(modification, data);
                //Execute the command
                _execute(modify);
                //Keep resolution
                _imageFactory.Resize(new Size(_writer.Width, _writer.Height));
                //Write a modified image
                _writer.WriteVideoFrame(_imageFactory.GetImage as Bitmap);

                progressBar.Step();
                string text = i.ToString();
                text += " / ";
                text += _reader.FrameCount;
                progressBar.UpdateText(text);
            }
            progressBar.Hide();
            //Let the User know that the file was not saved
            MessageBox.Show("Process has been completed.", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Close the reader to prevent memory leakage
            _reader.Close();
            //Close the writer to prevent memory leakage
            _writer.Close();
        }

        public void SaveVideo(string input, Action<int[]> modification, Size videoDimensions, params int[] data)
        {
            //Let the User know that they have to choose where the video will be output
            MessageBox.Show("Notification: \nPlease select where your video with applied effect will be outputted.", "Select output path",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Let the dialog form assume that the default extension is "avi"
                DefaultExt = ".avi"
            };

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save the image currently shown to whatever path
                try
                {
                    ApplyModification(input, saveFileDialog.FileName, modification, videoDimensions, data);
                    _pathfilename = saveFileDialog.FileName;
                }
                catch (Exception e)
                {
                    SaveVideo(input, modification, videoDimensions, data);
                    Console.WriteLine("Error: " + e);
                }
            }
        }
    }
}
