﻿using System.Drawing;

namespace WindowsFormsApp1
{
    /// <summary>
    /// An IImageGallery stores a gallery of images
    /// </summary>
    interface IImageGallery
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
        /// Changes the image from the list
        /// </summary>
        /// <param name="amount">How much to move in the list. amount = 1 would move forward the list by 1. amount = -1 would go back the list by 1.</param>
        /// <returns></returns>
        Image ChangeImage(int amount);

        /// <summary>
        /// Removes the current image 
        /// </summary>
        void DeleteImage();
    }
}