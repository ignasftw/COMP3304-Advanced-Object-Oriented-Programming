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

        public PictureBox PictureBox { get { return pictureBox; } }


        /// <summary>
        /// Calling a SaveImage interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _saveImageDelegate();
        }

        /// <summary>
        /// Calling a Load interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            //_loading.Load(_imageGallery,pictureBox, _imfac); Collection loads the image

        }

        /// <summary>
        /// Calling a change to left interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftButton_Click(object sender, EventArgs e)
        {
            /*
            //Change image from list downwards the list by 1
            pictureBox.Image = _imageGallery.ChangeImage(-1);
            //Load the image and update the galery
            _imfac.Load(pictureBox.Image);
             */
        }

        /// <summary>
        /// Calling a change to right interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightButton_Click(object sender, EventArgs e)
        {
            //No need for this button
        }


        /// <summary>
        /// Calling a auto zoom image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomAutoButton_Click(object sender, EventArgs e)
        {
            //Request and return scaled version of an image
            //No need for this button
            //pictureBox.Image = _scaling.AutoResizeImage(pictureBox.Size, _imfac);
        }


        /// <summary>
        /// Calling a zoom-in Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            //Request and return Zoomed-In version of an image
            //No need for this button

            //pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 1.1);
        }

        /// <summary>
        /// Calling a zoom-out Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            //Request and return Zoomed-Out version of an image
            //No need for this button

            //pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 0.9);
        }

        /// <summary>
        /// Calling a pinker Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakePinkerButton_Click(object sender, EventArgs e)
        {
            //Request a factory to return a pinker version of an Image
            //_imfac.Tint(Color.Pink);
            //Load the image and update the galery
            //pictureBox.Image = _imfac.GetImage;

            //tintimage delegate
        }

        /// <summary>
        /// Calling a reload an Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            //Request the image with the current id
            //pictureBox.Image = _imageGallery.CurrentImage;
            //Load the image and update the galery
            //_imfac.Load(pictureBox.Image);
        }

        /// <summary>
        /// Enables buttons which may be used
        /// </summary>
        /// <param name="button">Button which requires it's state to be changed</param>
        private void EnableButton(Button button)
        {
            button.Enabled = true;
        }

        private void ImagePinkifier_Load(object sender, EventArgs e)
        {

        }

        private void imageName_Click(object sender, EventArgs e)
        {

        }
    }
}
