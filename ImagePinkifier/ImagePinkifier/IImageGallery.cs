using System.Drawing;

namespace WindowsFormsApp1
{
    interface IImageGallery
    {
        //Returns a currently selected image
        Image CurrentImage { get; }

        /// <summary>
        /// Adds an image 
        /// </summary>
        /// <param name="image"></param>
        void AddImage(Image image);

        /// <summary>
        /// Adds an image from path
        /// </summary>
        /// <param name="fileName">string of a path of the image</param>
        void AddImage(string fileName);
        /// <summary>
        /// Changes the image 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        Image ChangeImage(int amount);
        /// <summary>
        /// Removes the current image 
        /// </summary>
        void DeleteImage();
    }
}