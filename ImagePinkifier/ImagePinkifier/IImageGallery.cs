using System.Drawing;

namespace WindowsFormsApp1
{
    interface IImageGallery
    {
        Image CurrentImage { get; }

        void AddImage(Image image);
        void AddImage(string fileName);
        Image ChangeImage(int amount);
        void DeleteImage();
    }
}