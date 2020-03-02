using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ImageGallery : IImageGallery, IComponent
    {
        //Declare a List of Image, store a list of images, call it '_images'
        private List<Image> _images = new List<Image>();
        //Declare an int, this is id of which image is currently selected, call it '_currentImageIndex'
        private int _currentImageIndex = 0;
        //Declare a Label which will display image count in current select, call it '_imageCounter'
        private Label _imageCounter;

        /// <summary>
        /// Contructor for creating an ImageGallery, on default it should contain a default image so using UI early wouldn't throw an exception
        /// </summary>
        /// <param name="imageCounter"></param>
        public ImageGallery(Label imageCounter)
        {
            _imageCounter = imageCounter;

            //Begin the list of images with one default image
            _images.Add(new Bitmap(1, 1));
        }

        /// <summary>
        /// Retrieves the current image from the list
        /// </summary>
        public Image CurrentImage { get { return _images[_currentImageIndex]; } }

        /// <summary>
        /// Changes which image is currently selected
        /// </summary>
        /// <param name="amount">The amount to change the index by, can be positive or negative</param>
        /// <returns>Returns the currently selected image</returns>
        public Image ChangeImage(int amount)
        {
            //Display the previous image on the list
            _currentImageIndex += amount;

            //Loop around to the last one if you get to the beginning
            if (_currentImageIndex < 0) _currentImageIndex = _images.Count - 1;

            //Loop around to the first one if you get to the end
            if (_currentImageIndex > _images.Count - 1) _currentImageIndex = 0;

            UpdateImageCounter();

            return CurrentImage;
        }

        /// <summary>
        /// Adds an image to the gallery of images from a file
        /// </summary>
        /// <param name="fileName">The path of the file to add</param>
        public void AddImage(string fileName)
        {
            AddImage(Image.FromFile(fileName));
        }
        /// <summary>
        /// Adds an image to the gallery of images
        /// </summary>
        /// <param name="image">The image to add</param>
        public void AddImage(Image image)
        {
            _images.Add(image);

            UpdateImageCounter();
        }

        /// <summary>
        /// Deletes the first image in the gallery
        /// </summary>
        public void DeleteImage()
        {
            _images.RemoveAt(0);
        }

        /// <summary>
        /// Updates the text of the image counter GUI element to reflect the count of images, both which is selected and how many there are in total
        /// </summary>
        private void UpdateImageCounter()
        {
            if (_imageCounter != null)
            {
                _imageCounter.Text = _currentImageIndex + 1 + " / " + _images.Count;
            }
        }
    }
}
