using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Drawing;
using System.Windows.Forms;

namespace Controller
{
    /// <summary>
    /// Class which contains library class, so it could implement an interface without modifying a library and keeping encapsulation
    /// </summary>
    public class ImageFactoryLocal : IImageFactoryLocal, IDisposable, IService
    {
        //Declare an ImageFactory
        private ImageFactory _imfac = new ImageFactory();

        //Declare an EventHandler which would check whenever the data has been changed, call it 'DataHasChanged'
        public event EventHandler EffectWasApplied;

        /// <summary>
        /// A constructor which creates a library's factory
        /// </summary>
        public ImageFactoryLocal()
        {
            _imfac = new ImageFactory();
        }

        /// <summary>
        ///Gets or the local image for manipulation.
        /// </summary>
        /// <returns></returns>
        public Image GetImage { get { return _imfac.Image; } }

        /// <summary>
        /// Gets the path to the local image for manipulation.
        /// </summary>
        /// <returns></returns>
        public string GetImagePath { get { return _imfac.ImagePath; } }

        /// <summary>
        /// Disposes the object and frees resources for the Garbage Collector.
        /// </summary>
        public void Dispose()
        {
            _imfac.Dispose();
        }

        /// <summary>
        /// Loads the image to process. Always call this method first.
        /// </summary>
        /// <param name="imagePath">The absolute path to the image to load.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public void Load(string imagePath)
        {
            _imfac = _imfac.Load(imagePath);
            EffectWasApplied(this, EventArgs.Empty);
        }

        /// <summary>
        /// Loads the image to process from an array of bytes. Always call this method first.
        /// </summary>
        /// <param name="image">The System.Drawing.Image to load. The original image is untouched during manipulation
        ///                     as a copy is made. Disposal of the input image is the responsibility of the user.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public void Load(Image image)
        {
            _imfac = _imfac.Load(image);
            EffectWasApplied(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Saves the current image to the specified file path. If the extension does not
        ///     match the correct extension for the current format it will be replaced by the
        ///     correct default value.
        /// </summary>
        /// <param name="filePath">The path to save the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public void Save(string filePath)
        {
            try
            {
                _imfac = _imfac.Save(filePath);
                EffectWasApplied(this, EventArgs.Empty);
            }
            catch (Exception e)
            {
                //Let the User know that the file was not saved
                MessageBox.Show("This file is already in use, please change the name. \nError: " + e.Message + " \nIf you think that is a bug please contant the developer.", "Please select different name." ,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Error: {0}", e);
            }
        }

        /// <summary>
        /// Tints the current image with the given color.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to tint the image with.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public void Tint(Color color)
        {
            _imfac = _imfac.Tint(color);
            EffectWasApplied(this, EventArgs.Empty);
        }

        public void Tint(params int[] color)
        {
            Tint(Color.DeepPink);
        }


        /// <summary>
        /// Resizes the current image to the given dimensions.
        /// </summary>
        /// <param name="size">The System.Drawing.Size containing the width and height to set the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public void Resize(Size size)
        {
            _imfac = _imfac.Resize(size);
            EffectWasApplied(this, EventArgs.Empty);
        }

        public void Resize(params int[] size)
        {
            Resize(new Size(size[0], size[1]));
        }

        /// <summary>
        /// Rotates the image to the given rotation value in degrees
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        public void Rotate(float degrees)
        {
            _imfac = _imfac.Rotate(degrees);
            //Cannot convert object[] to float
            EffectWasApplied(this, EventArgs.Empty);
        }
        public void Rotate(params int[] degrees)
        {
            Rotate((float) degrees[0]);
        }

        public void Flip(bool[] flips)
        {
            //flips[0] is flipVertically
            //flips[1] is flip both axis
            _imfac = _imfac.Flip(flips[0], flips[1]);
            EffectWasApplied(this, EventArgs.Empty);
        }

        public void Flip(params int[] flip)
        {
            Flip(new bool[] {Convert.ToBoolean(flip[0]), Convert.ToBoolean(flip[1])});
        }

        public void Subscribe(EventHandler dataHasBeenChanged)
        {
            EffectWasApplied += dataHasBeenChanged;
        }


        public void Unsubscribe(EventHandler dataHasBeenChanged)
        {
            EffectWasApplied -= dataHasBeenChanged;
        }
    }
}
