using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface ICustomScale
    {
        void CustomScale(PictureBox guiImage, ImageFactory factor, double scale);
    }
}
