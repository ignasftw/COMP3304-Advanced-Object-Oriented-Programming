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
        int ImageIndex { get; set; }

        //Returns a pathname of the file
        string GetPathName { get; }

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
        /// Return currently loaded image within given Size
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <returns></returns>
        Image GetImage(string key, int frameWidth, int frameHeight);

        /// <summary>
        /// Return currently loaded image
        /// </summary>
        /// <returns></returns>
        Image GetImage();

        /// <summary>
        /// Removes the current image 
        /// </summary>
        void DeleteImage();

        void Subscribe(EventHandler dataHasBeenChanged);


        void Unsubscribe(EventHandler dataHasBeenChanged);
    }
}