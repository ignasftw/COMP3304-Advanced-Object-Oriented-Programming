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

        public ImagePinkifier()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //Initialise the image gallery
            _imageGallery = new ImageGallery(imageCounter);

            //Initialise the image saver
            _imageSaver = new ImageSaver(_imfac);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            _imageSaver.SaveImage();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _loading.Load(_imageGallery,pictureBox,_imfac);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.ChangeImage(-1);
            _imfac.Load(pictureBox.Image);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.ChangeImage(1);
            _imfac.Load(pictureBox.Image);
        }

       

        private void zoomAutoButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _scaling.autoResizeImage(pictureBox.Size, _imfac);
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 1.1);
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ((ICustomScale)_scaling).CustomScale(pictureBox.Image, _imfac, 0.9);
        }

        private void makePinkerButton_Click(object sender, EventArgs e)
        {
            _imfac.Tint(Color.Pink);
            pictureBox.Image = _imfac.GetImage();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _imageGallery.CurrentImage;
            _imfac.Load(pictureBox.Image);
        }
    }
}
