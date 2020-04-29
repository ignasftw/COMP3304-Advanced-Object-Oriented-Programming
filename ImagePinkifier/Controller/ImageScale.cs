﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;
using System.Windows.Forms;


namespace Controller
{
    /// <summary>
    /// Purpose of this class is to return a scaled image upon request
    /// </summary>
    public class ImageScale : IAutoScale, ICustomScale
    {
        public ImageScale()
        {
        }

        /// <summary>
        /// A method which will Set the image to fit the window
        /// </summary>
        /// <param name="image">Image of the guiImage which will be changed</param>
        /// <param name="factor">ImageFactory which will be asked to return scaled image</param>
        public Image AutoResizeImage(Size size, IImageFactoryLocal factor)
        {
            try
            {
                //Ask factory to resize the image to the size of the window
                factor.Resize(size);
                //Ask guiImage to be changed into a scaled image
                return factor.GetImage;
            }
            catch (Exception e)
            {
                Console.WriteLine("No image found. Message: {0}", e);
                return null;
            }
        }

        /// <summary>
        /// A method which scales an image's width and height depending on a double: "scale"
        /// </summary>
        /// <param name="image">An Image which will be scaled</param>
        /// <param name="factor">A factory which will be asked to modify the image</param>
        /// <param name="scale">A double which is scale multiplier, 1.1 will increase the size by 10% and 0.9 will decrease by 10%</param>
        /// <returns>A scaled version of an Image</returns>
        public Image CustomScale(Image image, IImageFactoryLocal factor, double scale)
        {
            try
            {
                Size scaleImageSize = new Size(System.Convert.ToInt16(image.Width * scale), System.Convert.ToInt16(image.Height * scale));
                factor.Resize(scaleImageSize);
                image = factor.GetImage;
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
