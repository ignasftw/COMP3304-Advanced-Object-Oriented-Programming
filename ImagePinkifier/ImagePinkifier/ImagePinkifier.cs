using ImageProcessor;
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

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class controls the GUI for the program, it has references to all the classes that do the actual work
    /// </summary>
    public partial class ImagePinkifier : Form
    {
        //Declare a factory which will be creating and returning components, call it'_factory'
        private Factory.IComponentFactory _factory = new Factory.ComponentFactory();

        //Declare an IImageGallery which will store Image Galery, call it '_imageGallery'
        private IImageGallery _imageGallery;

        //Declare an IImageSaver which would be responsible for saving images, call it '_imageSaver'
        private IImageSaver _imageSaver;

        //Declare an IImageFactoryLocal which would be responsible for returning modified version of an image, call it '_imfac'
        private IImageFactoryLocal _imfac;

        //Declare an ILoader which would be responsible for loading images into the galery, call it '_loading'
        private ILoader _loading;

        //Declare an IAutoScale which would be responsible for scaling the image, call it '_scaling'
        private IAutoScale _scaling;

        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //Initialising ImageFactory Component
            _imfac = (IImageFactoryLocal)_factory.Get<ImageFactoryLocal>();
            //Initialising Image Loader Component
            _loading = (ILoader)_factory.Get<ImageLoader>();
            //Initialising Image Scale Component
            _scaling = (IAutoScale)_factory.Get<ImageScale>();

            //Initialise the image gallery
            //Creating through factory doesn't allow to pass any variables
            _imageGallery = new ImageGallery(imageCounter, imageName);

            //Initialise the image saver
            //Creating through factory doesn't allow to pass any variables
            _imageSaver = new ImageSaver(_imfac);
        }

        /// <summary>
        /// Calling a SaveImage interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _imageSaver.SaveImage();
        }

        /// <summary>
        /// Calling a Load interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            _loading.Load(_imageGallery,pictureBox, _imfac);
        }

        /// <summary>
        /// Calling a change to left interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftButton_Click(object sender, EventArgs e)
        {
            //Change image from list downwards the list by 1
            pictureBox.Image = _imageGallery.ChangeImage(-1);
            //Load the image and update the galery
            _imfac.Load(pictureBox.Image);
        }

        /// <summary>
        /// Calling a change to right interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightButton_Click(object sender, EventArgs e)
        {
            //Change image from list upwards the list by 1
            pictureBox.Image = _imageGallery.ChangeImage(1);
            //Load the image and update the galery
            _imfac.Load(pictureBox.Image);
        }


        /// <summary>
        /// Calling a auto zoom image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomAutoButton_Click(object sender, EventArgs e)
        {
            //Request and return scaled version of an image
            pictureBox.Image = _scaling.AutoResizeImage(pictureBox.Size, _imfac);
        }


        /// <summary>
        /// Calling a zoom-in Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            //Request and return Zoomed-In version of an image
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 1.1);
        }

        /// <summary>
        /// Calling a zoom-out Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            //Request and return Zoomed-Out version of an image
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 0.9);
        }

        /// <summary>
        /// Calling a pinker Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakePinkerButton_Click(object sender, EventArgs e)
        {
            //Request a factory to return a pinker version of an Image
            _imfac.Tint(Color.Pink);
            //Load the image and update the galery
            pictureBox.Image = _imfac.GetImage;
        }

        /// <summary>
        /// Calling a reload an Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            //Request the image with the current id
            pictureBox.Image = _imageGallery.CurrentImage;
            //Load the image and update the galery
            _imfac.Load(pictureBox.Image);
        }
    }
}
