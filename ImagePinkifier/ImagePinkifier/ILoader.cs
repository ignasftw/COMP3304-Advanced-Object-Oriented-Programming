using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;

namespace WindowsFormsApp1
{
    interface ILoader
    {
        /// <summary>
        /// Loads an Image and then puts to display to the PictureBox
        /// </summary>
        /// <param name="imageGallery">A list of Images where loaded Image will be added</param>
        /// <param name="pictureBox">A PictureBox where the loaded Image will be displayed</param>
        /// <param name="imagefactor">A factory which allows to load the images</param>
        void Load(IImageGallery imageGallery, PictureBox pictureBox, IImageFactoryLocal imagefactor);
    }
}
