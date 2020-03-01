using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;

namespace WindowsFormsApp1
{
    interface ILoader
    {
        void Load(IImageGallery imageGallery, PictureBox pictureBox, IImageFactoryLocal imagefactor);
    }
}
