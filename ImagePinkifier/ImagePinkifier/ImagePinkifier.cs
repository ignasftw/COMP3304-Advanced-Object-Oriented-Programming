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

        private ImageFactory _imfac = new ImageFactory();

        private List<Image> _images = new List<Image>();
        private int _currentImageIndex = 0;

        public ImagePinkifier()
        {
            InitializeComponent();

            //Begin the list of images with one blank image
            _images.Add(new Bitmap(1, 1));
            //Load the blank image to stop controls crashing if they have no image to affect
            pictureBox.Image = _images[_currentImageIndex];
            _imfac.Load(_images[_currentImageIndex]);
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
                if (_images[0].Width == 1 && _images[0].Height == 1) _images.RemoveAt(0);

                //Add the image chosen to the list of images
                foreach (string fileName in openFileDialog.FileNames)
                {
                    _images.Add(Image.FromFile(fileName));
                }

                //Display the most recently added image
                _currentImageIndex = _images.Count - 1;
                pictureBox.Image = _images[_currentImageIndex];

                //Load the current image to the imageprocessor (ready to be processed)
                _imfac.Load(_images[_currentImageIndex]);
            } else
            {
                MessageBox.Show("No image chosen");
            }

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            //Display the previous image on the list
            _currentImageIndex -= 1;

            //Loop around to the last one if you get to the beginning
            if (_currentImageIndex < 0) _currentImageIndex = _images.Count - 1;

            pictureBox.Image = _images[_currentImageIndex];

            //Load the current image to the imageprocessor (ready to be processed)
            _imfac.Load(_images[_currentImageIndex]);

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            //Display the next image on the list
            _currentImageIndex += 1;

            //Loop around to the first one if you get to the end
            if (_currentImageIndex > _images.Count - 1) _currentImageIndex = 0;

            pictureBox.Image = _images[_currentImageIndex];

            //Load the current image to the imageprocessor (ready to be processed)
            _imfac.Load(_images[_currentImageIndex]);
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
            pictureBox.Image = _images[_currentImageIndex];
            _imfac.Load(_images[_currentImageIndex]);
        }
    }
}
