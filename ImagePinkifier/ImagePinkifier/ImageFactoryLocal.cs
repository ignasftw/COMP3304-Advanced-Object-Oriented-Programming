using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Drawing;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Class which contains library class, so it could implement an interface without modifying a library and keeping encapsulation
    /// </summary>
    class ImageFactoryLocal : IImageFactoryLocal, IComponent, IDisposable
    {
        //Declare an ImageFactory
        private ImageFactory _imfac = new ImageFactory();

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
        public Image GetImage()
        {
            return _imfac.Image;
        }

        /// <summary>
        /// Gets the path to the local image for manipulation.
        /// </summary>
        /// <returns></returns>
        public string GetImagePath()
        {
            return _imfac.ImagePath;
        }

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
        public ImageFactory Load(string imagePath)
        {
            return _imfac.Load(imagePath);
        }

        /// <summary>
        /// Loads the image to process from an array of bytes. Always call this method first.
        /// </summary>
        /// <param name="image">The System.Drawing.Image to load. The original image is untouched during manipulation
        ///                     as a copy is made. Disposal of the input image is the responsibility of the user.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public ImageFactory Load(Image image)
        {
            return _imfac.Load(image);
        }

        /// <summary>
        ///     Saves the current image to the specified file path. If the extension does not
        ///     match the correct extension for the current format it will be replaced by the
        ///     correct default value.
        /// </summary>
        /// <param name="filePath">The path to save the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public ImageFactory Save(string filePath)
        {
            return _imfac.Save(filePath);
        }

        /// <summary>
        /// Tints the current image with the given color.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to tint the image with.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public ImageFactory Tint(Color color)
        {
            return _imfac.Tint(color);
        }

        /// <summary>
        /// Resizes the current image to the given dimensions.
        /// </summary>
        /// <param name="size">The System.Drawing.Size containing the width and height to set the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        public ImageFactory Resize(Size size)
        {
            return _imfac.Resize(size);
        }
    }
}
