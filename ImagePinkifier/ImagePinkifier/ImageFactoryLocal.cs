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
    /// Class which contains library class, so it could implement an interface without modifying a library
    /// </summary>
    class ImageFactoryLocal :  IComponent, IImageFactoryLocal
    {
        private ImageFactory _imfac = new ImageFactory();


        public ImageFactoryLocal()
        {
            _imfac =  new ImageFactory();
        }

        //
        // Summary:
        //     Gets or the local image for manipulation.
        public Image GetImage()
        {
            return _imfac.Image;
        }
        //
        // Summary:
        //     Gets the path to the local image for manipulation.
        public string GetImagePath()
        {
            return _imfac.ImagePath;
        }

        //
        // Summary:
        //     Disposes the object and frees resources for the Garbage Collector.
        public void Dispose()
        {
            _imfac.Dispose();
        }
        //
        // Summary:
        //     Loads the image to process. Always call this method first.
        //
        // Parameters:
        //   imagePath:
        //     The absolute path to the image to load.
        //
        // Returns:
        //     The current instance of the ImageProcessor.ImageFactory class.
        public ImageFactory Load(string imagePath)
        {
            return _imfac.Load(imagePath);
        }
        //
        // Summary:
        //     Loads the image to process from an array of bytes. Always call this method first.
        //
        // Parameters:
        //   image:
        //     The System.Drawing.Image to load. The original image is untouched during manipulation
        //     as a copy is made. Disposal of the input image is the responsibility of the user.
        //
        // Returns:
        //     The current instance of the ImageProcessor.ImageFactory class.
        public ImageFactory Load(Image image)
        {
            return _imfac.Load(image);
        }
        //
        // Summary:
        //     Saves the current image to the specified file path. If the extension does not
        //     match the correct extension for the current format it will be replaced by the
        //     correct default value.
        //
        // Parameters:
        //   filePath:
        //     The path to save the image to.
        //
        // Returns:
        //     The current instance of the ImageProcessor.ImageFactory class.
        public ImageFactory Save(string filePath)
        {
            return _imfac.Save(filePath);
        }
        //
        // Summary:
        //     Tints the current image with the given color.
        //
        // Parameters:
        //   color:
        //     The System.Drawing.Color to tint the image with.
        //
        // Returns:
        //     The current instance of the ImageProcessor.ImageFactory class.
        public ImageFactory Tint(Color color)
        {
            return _imfac.Tint(color);
        }
        //
        // Summary:
        //     Resizes the current image to the given dimensions.
        //
        // Parameters:
        //   size:
        //     The System.Drawing.Size containing the width and height to set the image to.
        //
        // Returns:
        //     The current instance of the ImageProcessor.ImageFactory class.
        public ImageFactory Resize(Size size)
        {
            return _imfac.Resize(size);
        }
    }
}
