using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDGenerator;

namespace WindowsFormsApp1
{
    /// <summary>
    /// ImageGallery stores a gallery of images
    /// </summary>
    class ImageGallery : IImageGallery, IComponent, IModel
    {
        //Declare a Data class, for storing Image/Imagepathfile dictionary, call it '_dataStorage'
        Data _dataStorage = new Data();
        //Declare an int, this is id of the image, call it '_id'
        private string _id = "";
        //Declare an int, this is id of which image is currently selected, call it '_currentImageIndex'
        private int _currentImageIndex = 0;
        //Declare a Label which will display image count in current select, call it '_imageCounter'
        private Label _imageCounter;
        //Declare a Label which will display pathfile name in current select, call it '_imageName'
        private Label _imageName;

        PictureBox _pB;

        /// <summary>
        /// Contructor for creating an ImageGallery, on default it should contain a default image so using UI early wouldn't throw an exception
        /// </summary>
        /// <param name="imageCounter"></param>
        public ImageGallery(Label imageCounter, Label imageName, PictureBox pictureBox)
        {
            _pB = pictureBox;
            _imageCounter = imageCounter;
            _imageName = imageName;
            //Begin the list of images with one default image which will be deleted after uploading images
            _dataStorage.AddImage(new Bitmap(1, 1), "");
        }

        /// <summary>
        /// Retrieves the current image from the list
        /// </summary>
        public Image CurrentImage { get { return _dataStorage.GetImage(_currentImageIndex); } }



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
            if (_currentImageIndex < 0) _currentImageIndex = _dataStorage.Count - 1;

            //Loop around to the first one if you get to the end
            if (_currentImageIndex > _dataStorage.Count - 1) _currentImageIndex = 0;

            UpdateImageCounter();

            return CurrentImage;
        }

        /// <summary>
        /// Adds an image to the gallery of images from a file
        /// </summary>
        /// <param name="fileName">The path of the file to add</param>
        public string AddImage(string fileName)
        {
            return AddImage(Image.FromFile(fileName), fileName);
        }

        /// <summary>
        /// Adds an image to the gallery of images if the filepath is empty with a generated ID
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public string AddImage(Image image)
        {
            string id = (_id += IDGenerator.IDGenerator.RandomPhoneme());
            AddImage(image, id);
            return id;
        }

        /// <summary>
        /// Adds an image to the gallery of images
        /// </summary>
        /// <param name="image">The image to add</param>
        public string AddImage(Image image, string imageName)
        {
            _dataStorage.AddImage(image, imageName);
            UpdateImageCounter();
            return imageName;
        }


        /// <summary>
        /// Asks storage to remove unnecessary images
        /// </summary>
        public void DeleteImage()
        {
            _dataStorage.RemoveImage();
            UpdateImageCounter();
        }

        /// <summary>
        /// Updates the text of the image counter GUI element to reflect the count of images, both which is selected and how many there are in total
        /// </summary>
        private void UpdateImageCounter()
        {
            if (_imageCounter != null)
            {
                _imageCounter.Text = _currentImageIndex + 1 + " / " + _dataStorage.Count;
                if (_dataStorage.Count > _currentImageIndex)
                {
                    _imageName.Text = _dataStorage.GetFileName(_currentImageIndex);
                }
            }
        }


        /// <summary>
        /// Loading a list of strings of images. Images and pathfile names will be added to storage. After that return a list with pathfile names
        /// </summary>
        /// <param name="pathfilenames"></param>
        /// <returns>A list of strings with pathfile names</returns>
        public IList<string> Load(IList<string> pathfilenames)
        {
            IList<string> ids = new List<string>();
            foreach (string s in pathfilenames)
            {
                ids.Add(AddImage(s));
            }
            return ids;
        }

        /// <summary>
        /// Implementing IModel which required to return an image of certain width and height, but this is done in a separate class because of Single Responsability Principle
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <returns></returns>
        public Image GetImage(string key, int frameWidth, int frameHeight)
        {
            return _dataStorage.GetImage(key);
        }

        public List<Image> GetAllImages()
        {
            List<Image> tempImages = new List<Image>();
            for (int i = 0; i < _dataStorage.Count; i++)
            {
                tempImages.Add(_dataStorage.GetImage(i));
            }
            return tempImages;
        }
    }
}
