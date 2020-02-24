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

        ImageGallery imageGallery;

        private ImageFactory _imfac = new ImageFactory();

        

        public ImagePinkifier()
        {
            InitializeComponent();

            //Initialise the image gallery
            imageGallery = new ImageGallery(imageCounter);

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "jpg";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save the image currently shown to whatever path
                _imfac.Save(saveFileDialog.FileName);
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Delete placeholder image
                if (imageGallery.CurrentImage.Width == 1 && imageGallery.CurrentImage.Height == 1) imageGallery.deleteImage();

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
            pictureBox.Image = imageGallery.changeImage(-1);
            _imfac.Load(pictureBox.Image);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = imageGallery.changeImage(1);
            _imfac.Load(pictureBox.Image);
        }

       

        private void zoomAutoButton_Click(object sender, EventArgs e)
        {
            autoResizeImage();
        }

        private void autoResizeImage()
        {
            _imfac.Resize(pictureBox.Size);
            pictureBox.Image = _imfac.Image;
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            _imfac.Resize(pictureBox.Image.Size.Multiply(1.1));
            pictureBox.Image = _imfac.Image;
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            _imfac.Resize(pictureBox.Image.Size.Multiply(0.9));
            pictureBox.Image = _imfac.Image;
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
