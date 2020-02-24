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
        /// <param name="image">Image of the guiImage which will have to be changed</param>
        /// <param name="factor">ImageFactory which will be asked to return scaled image</param>
        public Image autoResizeImage(Size size, ImageFactory factor)
        {
            try
            {
                //Ask factory to resize the image to the size of the window
                factor.Resize(size);
                //Ask guiImage to be changed into a scaled image
                return factor.Image;
            }
            catch (Exception e)
            {
                Console.WriteLine("No image found. Message: {0}", e);
                return null;
            }
        }


        public Image CustomScale(Image image, ImageFactory factor, double scale)
        {
            try
            {
                factor.Resize(image.Size.Multiply(scale));
                image = factor.Image;
                return image;
            }
            catch (Exception e)
            {
                Console.WriteLine("No image found. Message: {0}",e);
                return null;
            }

        }
    }
}
