using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// This class controls the GUI for the program, it has references to all the classes that do the actual work
    /// </summary>
    public partial class ImagePinkifier : Form
    {
        /*Delegates which will be used as commands*/
        //DECLARE a Delegate which asks to Scale Image
        private Action<Size> _scaleImageDelegate;

        //DECLARE a Delegate which asks to Rotate Image
        private Action<float> _rotateImageDelegate;

        //DECLARE a Delegate which asks to Flip Image
        private Action<bool[]> _flipImageDelegate;

        //DECLARE a Delegate which asks to Save Image
        private ICommand _saveImageDelegate;

        //DECLARE a Delegate which reloads the Image
        private Action _reloadDelegate;

        private Action<ICommand> _executeCommand;

        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier(Action<Size> scale, Action<float> rotate, Action<bool[]> flip, ICommand saveImage, Action resetCommand, Action<ICommand> execute)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            _scaleImageDelegate = scale;
            _rotateImageDelegate = rotate;
            _flipImageDelegate = flip;
            _saveImageDelegate = saveImage;
            _reloadDelegate = resetCommand;

            _executeCommand = execute;
        }

        private void ImagePinkifier_Load(object sender, EventArgs e)
        {

        }

        public PictureBox PictureBox { get { return pictureBox; } }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            RequestForms.ScaleRequestForm scaleRequest = new RequestForms.ScaleRequestForm(_scaleImageDelegate);
            scaleRequest.PutPictureNumbers(PictureBox.Image.Width, PictureBox.Image.Height);
            scaleRequest.Show();
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            RequestForms.RotateRequestForm rotateRequest = new RequestForms.RotateRequestForm(_rotateImageDelegate);
            rotateRequest.Show();
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            RequestForms.FlipRequestForm flipRequest = new RequestForms.FlipRequestForm(_flipImageDelegate);
            flipRequest.Show();
        }

        private void MakePinkerButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            _reloadDelegate();
        }

        /// <summary>
        /// Calling a SaveImage Command after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _executeCommand(_saveImageDelegate);
        }
    }
}
