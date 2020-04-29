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
    public class ImageSaver : IImageSaver, IService
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
                try
                {
                    _imageFactory.Save(saveFileDialog.FileName);

                }
                catch (Exception e)
                {
                    //Let the User know that something went wrong
                    MessageBox.Show("Error: " + e.Message + " \nIf you think that is a bug please contant the developer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Console.WriteLine("Error: {0}", e);
                    SaveImage();
                }
            }
        }
    }

}

