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
    class VideoModify
    {
        //DECLARE a VideoFileReader which will read the loaded video, call it '_reader'
        private VideoFileReader _reader;
        //DECLARE a VideoFileWriter which will write a new video from frames, call it '_writer'
        private VideoFileWriter _writer;
        //DECLARE an IImageFactoryLocal which will store a reference for imagemodification class
        private IImageFactoryLocal _imageFactory;

        Action<View.ICommand> _execute;
        Size videoDimensions = new Size(640, 360);

        public VideoModify(IImageFactoryLocal factor, Action<View.ICommand> execute)
        {
            _reader = new VideoFileReader();
            _writer = new VideoFileWriter();
            _execute = execute;
            _imageFactory = factor;
        }

        public void ApplyModification(string video, string savepath, string filename, Action<int[]> modification)
        {
            //Open Video which will be modified
            _reader.Open(video);
            //Set parameters of how and where the video will be saved
            _writer.Open(savepath + filename, videoDimensions.Width, videoDimensions.Height, _reader.FrameRate, VideoCodec.Default, 1000000);
            View.ProgressBar progressBar = new View.ProgressBar();
            progressBar.SetBar(0, System.Convert.ToInt32(_reader.FrameCount));
            progressBar.Show();
            //Modify through every frame of the video
            for (int i = 0; i < _reader.FrameCount; i+=3)
            {
                //Load current frame to modification factory
                _imageFactory.Load(_reader.ReadVideoFrame() as Image);
                //Create a command which applies the effect
                View.ICommand rotateCom = new View.Command<int[]>(modification, new int[] { i});
                //Execute the command
                _execute(rotateCom);
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
    }
}
