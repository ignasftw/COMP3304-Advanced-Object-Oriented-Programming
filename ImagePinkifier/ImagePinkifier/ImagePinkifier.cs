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

        private ImageFactory _imfac = new ImageFactory();

        private ILoader _loading = new ImageLoader();

        private ImageScale _scaling = new ImageScale();

        public ImagePinkifier()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //Initialise the image gallery
            imageGallery = new ImageGallery(imageCounter);

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //Let the dialog form assume that the default extension is "jpg"
            saveFileDialog.DefaultExt = "jpg";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save the image currently shown to whatever path
                _imfac.Save(saveFileDialog.FileName);
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _loading.Load(imageGallery,pictureBox,_imfac);
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
