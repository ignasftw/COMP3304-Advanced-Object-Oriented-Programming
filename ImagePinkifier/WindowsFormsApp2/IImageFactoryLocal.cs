using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Drawing;

namespace Controller
{
    /*
     Code snippets were taken out of SizeMultiplier project to create an interface for IImageFactoryLocal
         */
    public interface IImageFactoryLocal
    {
        /// <summary>
        /// Gets or the local image for manipulation.
        /// </summary>
        /// <returns></returns>
        Image GetImage { get; }

        /// <summary>
        /// Gets the path to the local image for manipulation.
        /// </summary>
        /// <returns></returns>
        string GetImagePath { get; }

        /// <summary>
        /// Disposes the object and frees resources for the Garbage Collector.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Loads the image to process. Always call this method first.
        /// </summary>
        /// <param name="imagePath">The absolute path to the image to load.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        void Load(string imagePath);

        /// <summary>
        /// Loads the image to process from an array of bytes. Always call this method first.
        /// </summary>
        /// <param name="image">The System.Drawing.Image to load. The original image is untouched during manipulation as a copy is made. Disposal of the input image is the responsibility of the user.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        void Load(Image image);

        /// <summary>
        /// Saves the current image to the specified file path. If the extension does not
        /// match the correct extension for the current format it will be replaced by the
        /// correct default value.
        /// </summary>
        /// <param name="filePath">The path to save the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        void Save(string filePath);

        /// <summary>
        /// Tints the current image with the given color.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to tint the image with.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        void Tint(Color color);

        /// <summary>
        /// Resizes the current image to the given dimensions.
        /// </summary>
        /// <param name="size">The System.Drawing.Size containing the width and height to set the image to.</param>
        /// <returns>The current instance of the ImageProcessor.ImageFactory class.</returns>
        void Resize(Size size);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        void Rotate(float degrees);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flipVertically"></param>
        /// <param name="flipBoth"></param>
        /// <returns></returns>
        void Flip(bool[] flips);

    }
}
