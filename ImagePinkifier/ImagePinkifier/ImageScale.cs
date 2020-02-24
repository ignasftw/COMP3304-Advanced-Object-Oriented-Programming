using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;
using SizeMultiplier;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    /// <summary>
    /// Purpose of this class is to return a scaled image upon request
    /// </summary>
    class ImageScale : IAutoScale, ICustomScale
    {
        public ImageScale()
        {
        }
        /// <summary>
        /// Set the image to fit the window
        /// </summary>
        /// <param name="guiImage">Image of the guiImage which will have to be changed</param>
        /// <param name="factor">ImageFactory which will be asked to return scaled image</param>
        public void autoResizeImage(PictureBox guiImage, ImageFactory factor)
        {
            //Ask factory to resize the image to the size of the window
            factor.Resize(guiImage.Size);
            //Ask guiImage to be changed into a scaled image
            guiImage.Image = factor.Image;
        }


        public void CustomScale(PictureBox guiImage, ImageFactory factor, double scale)
        {
            factor.Resize(guiImage.Image.Size.Multiply(scale));
            guiImage.Image = factor.Image;
        }
    }
}
