using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;

namespace Controller
{
    /// <summary>
    /// Class which is responsible for loading images from pathfile
    /// </summary>
    public class ImageLoader : ILoader, IComponent
    {
        public ImageLoader()
        {

        }

        /// <summary>
        /// Loading an Image from OpenFileDialog and then adding it to the Image list and display the most recent one
        /// </summary>
        /// <param name="imageGallery">The galery that all the images will be displayed in</param>
        /// <param name="pictureBox">The PictureBox where the most secent upload will be displayed</param>
        /// <param name="imagefactor">The imagefactory will be asked to load the Image</param>
        public void Load(IImageGallery imageGallery, PictureBox pictureBox, IImageFactoryLocal imagefactor)
        {
            //Open file picker dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Delete placeholder image
                if (imageGallery.CurrentImage.Width == 1 && imageGallery.CurrentImage.Height == 1) imageGallery.DeleteImage();

                ((IModel)imageGallery).Load(openFileDialog.FileNames);

                //Display the most recently added image
                pictureBox.Image = imageGallery.CurrentImage;

                //Load the current image to the imageprocessor (ready to be processed)
                imagefactor.Load(pictureBox.Image);
            }
            else
            {
                MessageBox.Show("No image chosen");
            }

        }
    }
}
