using ImageProcessor;
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
        }


        private void leftButton_Click(object sender, EventArgs e)
        {
            //Display the previous image on the list
            currentImageIndex -= 1;

            //Loop around to the last one if you get to the beginning
            if (currentImageIndex < 0) currentImageIndex = images.Count-1;

            pictureBox.Image = images[currentImageIndex];

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            //Display the next image on the list
            currentImageIndex += 1;

            //Loop around to the first one if you get to the end
            if (currentImageIndex > images.Count-1) currentImageIndex = 0;

            pictureBox.Image = images[currentImageIndex];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog

            //Save the image currently shown to whatever path
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            //Open file picker dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            //Add the image chosen to the list of images
            images.Add(Image.FromFile(openFileDialog.FileName));

            //Display the most recently added image
            currentImageIndex = images.Count - 1;
            pictureBox.Image = images[currentImageIndex];
            
        }

        


    }
}
