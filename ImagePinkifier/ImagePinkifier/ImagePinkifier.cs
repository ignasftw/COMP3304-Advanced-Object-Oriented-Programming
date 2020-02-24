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

        IImageGallery imageGallery;

        IImageSaver imageSaver;

        private ImageFactory _imfac = new ImageFactory();

        

        private ImageScale _scaling = new ImageScale();

        public ImagePinkifier()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //Initialise the image gallery
            imageGallery = new ImageGallery(imageCounter);

            //Initialise the image saver
            imageSaver = new ImageSaver(_imfac);

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            imageSaver.SaveImage();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Delete placeholder image
                if (imageGallery.CurrentImage.Width == 1 && imageGallery.CurrentImage.Height == 1) imageGallery.DeleteImage();

                //Add the image chosen to the list of images
                foreach (string fileName in openFileDialog.FileNames)
                {
                    imageGallery.AddImage(fileName);
                }

                //Display the most recently added image
                pictureBox.Image = imageGallery.CurrentImage;

                //Load the current image to the imageprocessor (ready to be processed)
                _imfac.Load(pictureBox.Image);
            } else
            {
                MessageBox.Show("No image chosen");
            }

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = imageGallery.ChangeImage(-1);
            _imfac.Load(pictureBox.Image);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = imageGallery.ChangeImage(1);
            _imfac.Load(pictureBox.Image);
        }

       

        private void zoomAutoButton_Click(object sender, EventArgs e)
        {
            _scaling.autoResizeImage(pictureBox,_imfac);
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            ((ICustomScale)_scaling).CustomScale(pictureBox, _imfac, 1.1);
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            ((ICustomScale)_scaling).CustomScale(pictureBox, _imfac, 0.9);
        }

        private void makePinkerButton_Click(object sender, EventArgs e)
        {
            _imfac.Tint(Color.Pink);
            pictureBox.Image = _imfac.Image;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = imageGallery.CurrentImage;
            _imfac.Load(pictureBox.Image);
        }
    }
}
