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
        private Action<string> _saveImageDelegate;

        //DECLARE a Delegate which reloads the Image
        private Action _reloadDelegate;


        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier(Action<Size> scale, Action<float> rotate, Action<bool[]> flip, Action<string> saveImage, Action resetCommand)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            _scaleImageDelegate = scale;
            _rotateImageDelegate = rotate;
            _flipImageDelegate = flip;
            _saveImageDelegate = saveImage;
            _reloadDelegate = resetCommand;
        }

        private void ImagePinkifier_Load(object sender, EventArgs e)
        {

        }

        public PictureBox PictureBox { get { return pictureBox; } }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            _scaleImageDelegate(new Size(100,100));
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            _rotateImageDelegate(10);
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            bool[] flip = { true, true };

            _flipImageDelegate(flip);
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
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Let the dialog form assume that the default extension is "jpg"
                DefaultExt = "jpg"
            };

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _saveImageDelegate(saveFileDialog.FileName);
            }


        }
    }
}
