using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    /// <summary>
    /// This class takes an ImageFactory and prepares to save that factory's current image to a file using a file dialog
    /// </summary>
    public class ImageSaver : IImageSaver, IComponent
    {
        /// <summary>
        /// This is the factory that will be used to save the image
        /// </summary>

        //Declare an IImageFactoryLocal which will be a link for a library which didn't have an interface
        private IImageFactoryLocal _imageFactory;

        public ImageSaver(IImageFactoryLocal imageFactory)
        {
            _imageFactory = imageFactory;
        }

        /// <summary>
        /// Save a current Image selected
        /// </summary>
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
