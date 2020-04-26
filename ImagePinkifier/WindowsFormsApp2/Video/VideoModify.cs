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
        //Video for testing purposes
        private string _loadedVideo = "C:/Users/Viktorija/Desktop/OOP/small.mp4";
        //Default savepath
        private string _savepath = "C:/Users/Viktorija/Desktop/OOP/";
        //DECLARE a VideoFileReader which will read the loaded video, call it '_reader'
        private VideoFileReader _reader = new VideoFileReader();
        //DECLARE a VideoFileWriter which will write a new video from frames, call it '_writer'
        private VideoFileWriter _writer = new VideoFileWriter();

        Action<View.ICommand> _execute;
        Action<float> _rotate;
        Size videoDimensions = new Size(640, 360);

        public VideoModify(Action<float> RotationDel, IImageFactoryLocal factor, Action<View.ICommand> execute, Action<float> rotate)
        {
            _execute = execute;
            _rotate = rotate;
            ApplyModification(_loadedVideo, _savepath, "filename.avi", RotationDel, factor);
        }

        public void ApplyModification(string video, string savepath, string filename, Action<float> RotationDel, IImageFactoryLocal factor)
        {
            //Open Video which will be modified
            _reader.Open(video);
            //Set parameters of how and where the video will be saved
            _writer.Open(savepath + filename, videoDimensions.Width, videoDimensions.Height, _reader.FrameRate, VideoCodec.Default, 1000000);
            View.ProgressBar progressBar = new View.ProgressBar();
            progressBar.SetBar(0, System.Convert.ToInt32(_reader.FrameCount));
            progressBar.Show();
            //Modify through every frame of the video
            //for (int i = 0; i < _reader.FrameCount/10; i++)
            for (int i = 0; i < 69; i++)
            {
                //Load current frame to modification factory
                factor.Load(_reader.ReadVideoFrame() as Image);

                View.ICommand rotateCom = new View.Command<float>(_rotate, i);
                _execute(rotateCom);

                //TINT the image
                factor.Tint(Color.HotPink);
                //Keep resolution
                factor.Resize(new Size(_writer.Width, _writer.Height));
                //Write a modified image
                _writer.WriteVideoFrame(factor.GetImage as Bitmap);

                progressBar.Step();
                string text = i.ToString();
                text += " / ";
                text += _reader.FrameCount;
                progressBar.UpdateText(text);
            }
            progressBar.Hide();
            //Let the User know that the file was not saved
            MessageBox.Show("Process has been completed.","Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Close the reader to prevent memory leakage
            _reader.Close();
            //Close the writer to prevent memory leakage
            _writer.Close();
        }
    }
}
