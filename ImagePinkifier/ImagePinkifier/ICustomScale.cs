using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    interface ICustomScale
    {
        /// <summary>
        ///  An interface that scales image to set value
        /// </summary>
        /// <param name="guiImage">Takes an image that should be scaled</param>
        /// <param name="factor">Will ask a factory to scale an image</param>
        /// <param name="scale">Scale factor will be scaled to. For example 1 will not scale the image and 1.1 will expand image by 10%</param>
        /// <returns>A scaled version of an image</returns>
        Image CustomScale(Image guiImage, IImageFactoryLocal factor, double scale);
    }
}
