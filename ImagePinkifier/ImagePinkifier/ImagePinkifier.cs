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
    public partial class ImagePinkifier : Form
    {
        private IImageGallery _imageGallery;

        private IImageSaver _imageSaver;

        private IImageFactoryLocal _imfac = new ImageFactoryLocal();

        private ILoader _loading = new ImageLoader();

        private IAutoScale _scaling = new ImageScale();

        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //Initialise the image gallery
            _imageGallery = new ImageGallery(imageCounter);

            //Initialise the image saver
            _imageSaver = new ImageSaver(_imfac);
        }

        /// <summary>
        /// Calling a SaveImage interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            _imageSaver.SaveImage();
        }

        /// <summary>
        /// Calling a Load interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _loading.Load(_imageGallery,pictureBox,_imfac);
        }

        /// <summary>
        /// Calling a change to left interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.ChangeImage(-1);
            _imfac.Load(pictureBox.Image);
        }

        /// <summary>
        /// Calling a change to right interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.ChangeImage(1);
            _imfac.Load(pictureBox.Image);
        }


        /// <summary>
        /// Calling a auto zoom image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomAutoButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _scaling.autoResizeImage(pictureBox.Size, _imfac);
        }


        /// <summary>
        /// Calling a zoom-in Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 1.1);
        }

        /// <summary>
        /// Calling a zoom-out Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 0.9);
        }

        /// <summary>
        /// Calling a pinker Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makePinkerButton_Click(object sender, EventArgs e)
        {
            _imfac.Tint(Color.Pink);
            pictureBox.Image = _imfac.GetImage();
        }

        /// <summary>
        /// Calling a reload an Image interface after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.CurrentImage;
            _imfac.Load(pictureBox.Image);
        }
    }
}
