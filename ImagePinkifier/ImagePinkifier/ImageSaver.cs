using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class takes an ImageFactory and prepares to save that factory's current image to a file using a file dialog
    /// </summary>
    class ImageSaver : IImageSaver
    {
        /// <summary>
        /// This is the factory that will be used to save the image
        /// </summary>
        private ImageFactory _imageFactory;

        public ImageSaver(ImageFactory imageFactory)
        {
            _imageFactory = imageFactory;
        }

        public void SaveImage()
        {
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Let the dialog form assume that the default extension is "jpg"
                DefaultExt = "jpg"
            };

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save the image currently shown to whatever path
                _imageFactory.Save(saveFileDialog.FileName);
            }
        }

}
}
