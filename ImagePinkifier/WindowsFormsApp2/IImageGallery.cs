using System;
using System.Collections.Generic;
using System.Drawing;


namespace Controller
{
    /// <summary>
    /// An IImageGallery stores a gallery of images
    /// </summary>
    public interface IImageGallery
    {
        //Returns a currently selected image
        Image CurrentImage { get; }

        /// <summary>
        /// Adds an image 
        /// </summary>
        /// <param name="image"></param>
        string AddImage(Image image);

        /// <summary>
        /// Adds an image from path
        /// </summary>
        /// <param name="fileName">string of a path of the image</param>
        string AddImage(string fileName);

        /// <summary>
        /// Return all images contained insede Data
        /// </summary>
        /// <returns></returns>
        List<Image> GetAllImages();

        /// <summary>
        /// Removes the current image 
        /// </summary>
        void DeleteImage();

        void Subscribe(EventHandler dataHasBeenChanged);


        void Unsubscribe(EventHandler dataHasBeenChanged);
    }
}