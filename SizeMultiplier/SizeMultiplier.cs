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
        public static Size Multiply(this Size size, double factor)
        {
            System.Diagnostics.Debug.WriteLine(size.Width);
            return new Size((int)(size.Width * factor), (int)(size.Height * factor));
        }
    }
}
