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

        public ImagePinkifier()
        {
            InitializeComponent();
        }


        private void leftButton_Click(object sender, EventArgs e)
        {
            //Display the previous image on the list

            //Loop around to the last one if you get to the beginning

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            //Display the next image on the list

            //Loop around to the first one if you get to the end

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

            pictureBox.Image = Image.FromFile(openFileDialog.FileName);

            //Add the image chosen to the list of images


            //Display the most recently added image

        }

        


    }
}
