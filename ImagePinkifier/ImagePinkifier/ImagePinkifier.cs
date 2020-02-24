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

        ImageFactory imfac = new ImageFactory();

        List<Image> images = new List<Image>();
        int currentImageIndex = 0;

        public ImagePinkifier()
        {
            InitializeComponent();

            //Begin the list of images with one blank image
            images.Add(new Bitmap(1, 1));
            //Load the blank image to stop controls crashing if they have no image to affect
            pictureBox.Image = images[currentImageIndex];
            imfac.Load(images[currentImageIndex]);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "jpg";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save the image currently shown to whatever path
                imfac.Save(saveFileDialog.FileName);
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
                if (images[0].Width == 1 && images[0].Height == 1) images.RemoveAt(0);

                //Add the image chosen to the list of images
                foreach (string fileName in openFileDialog.FileNames)
                {
                    images.Add(Image.FromFile(fileName));
                }

                //Display the most recently added image
                currentImageIndex = images.Count - 1;
                pictureBox.Image = images[currentImageIndex];

                //Load the current image to the imageprocessor (ready to be processed)
                imfac.Load(images[currentImageIndex]);
            } else
            {
                MessageBox.Show("No image chosen");
            }

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            //Display the previous image on the list
            currentImageIndex -= 1;

            //Loop around to the last one if you get to the beginning
            if (currentImageIndex < 0) currentImageIndex = images.Count - 1;

            pictureBox.Image = images[currentImageIndex];

            //Load the current image to the imageprocessor (ready to be processed)
            imfac.Load(images[currentImageIndex]);

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            //Display the next image on the list
            currentImageIndex += 1;

            //Loop around to the first one if you get to the end
            if (currentImageIndex > images.Count - 1) currentImageIndex = 0;

            pictureBox.Image = images[currentImageIndex];

            //Load the current image to the imageprocessor (ready to be processed)
            imfac.Load(images[currentImageIndex]);
        }

        private void zoomAutoButton_Click(object sender, EventArgs e)
        {
            autoResizeImage();
        }

        private void autoResizeImage()
        {
            imfac.Resize(pictureBox.Size);
            pictureBox.Image = imfac.Image;
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            imfac.Resize(pictureBox.Image.Size.Multiply(1.1));
            pictureBox.Image = imfac.Image;
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            imfac.Resize(pictureBox.Image.Size.Multiply(0.9));
            pictureBox.Image = imfac.Image;
        }

        private void makePinkerButton_Click(object sender, EventArgs e)
        {
            imfac.Tint(Color.Pink);
            pictureBox.Image = imfac.Image;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = images[currentImageIndex];
            imfac.Load(images[currentImageIndex]);
        }
    }
}
