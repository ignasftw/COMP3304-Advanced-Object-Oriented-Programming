using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeMultiplier
{
    public static class SizeMultiplier
    {
        /// <summary>
        /// Class which modifies the image's size
        /// </summary>
        /// <param name="size">Size of current image</param>
        /// <param name="factor">Factor of image scale</param>
        /// <returns></returns>
        public static Size Multiply(this Size size, double factor)
        {
            //System.Diagnostics.Debug.WriteLine(size.Width);
            return new Size((int)(size.Width * factor), (int)(size.Height * factor));
        }
    }
}
