using SizeMultiplier;
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
        //Declare a factory which will be creating and returning components, call it'_factory'
        //private Factory.IComponentFactory _factory = new Factory.ComponentFactory();

        /*Delegates which will be used as commands*/
        //DECLARE a Delegate which asks to Scale Image
        private Action<Size> _scaleImageDelegate;

        //DECLARE a Delegate which asks to Rotate Image
        private Action<int> _rotateImageDelegate;

        //DECLARE a Delegate which asks to Flip Image
        private Action _flipImageDelegate;

        //DECLARE a Delegate which asks to Save Image
        private Action _saveImageDelegate;


        public ImagePinkifier()
        {
            //DEBUG COMPILER FOR TESTS SHOULD BE DELETED
            InitializeComponent();
            pictureBox.AutoSize = true;
            //pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier(Action<Size> scaleImageDelegate, Action<int> rotateImageDelegate, Action flipImageDelegate, Action saveImageDelegate)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            /*Setup Delegates*/
            _scaleImageDelegate = scaleImageDelegate;
            _rotateImageDelegate = rotateImageDelegate;
            _flipImageDelegate = flipImageDelegate;
            _saveImageDelegate = saveImageDelegate;
        }

        private void ImagePinkifier_Load(object sender, EventArgs e)
        {

        }

        public PictureBox PictureBox { get { return pictureBox; } }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            _scaleImageDelegate(new Size());
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            _rotateImageDelegate(new int());
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            _flipImageDelegate();
        }

        private void MakePinkerButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calling a SaveImage Command after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _saveImageDelegate();
        }
    }
}
