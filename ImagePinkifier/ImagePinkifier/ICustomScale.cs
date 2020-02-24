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
        Image CustomScale(Image guiImage, ImageFactory factor, double scale);
    }
}
