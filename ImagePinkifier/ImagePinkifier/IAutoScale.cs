using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IAutoScale
    {
        /// <summary>
        /// An interface that scales image to the window size
        /// </summary>
        /// <param name="size">Size of the window that is should be scaled to</param>
        /// <param name="factor">Asking a factory to scale an image</param>
        /// <returns>a scaled image</returns>
        Image autoResizeImage(Size size, IImageFactoryLocal factor);
    }
}
