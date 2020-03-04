namespace WindowsFormsApp1
{
    /// <summary>
    /// This class takes an ImageFactory and prepares to save that factory's current image to a file using a file dialog
    /// </summary>
    interface IImageSaver
    {
        /// <summary>
        /// Saves a current image to the directory
        /// </summary>
        void SaveImage();
    }
}