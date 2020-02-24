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
        void autoResizeImage(PictureBox guiImage, ImageFactory factor);
    }
}
