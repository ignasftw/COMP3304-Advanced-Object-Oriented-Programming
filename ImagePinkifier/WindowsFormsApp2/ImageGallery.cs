using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    /// <summary>
    /// ImageGallery stores a gallery of images
    /// </summary>
    public class ImageGallery : IImageGallery, IComponent, IModel
    {
        //Declare a Data class, for storing Image/Imagepathfile dictionary, call it '_dataStorage'
        Model.Data _dataStorage = new Model.Data();
        //Declare an int, this is id of the image, call it '_id'
        private string _id = "";
        //Declare an int, this is id of which image is currently selected, call it '_currentImageIndex'
        private int _currentImageIndex = 0;
        //Declare an EventHandler which would check whenever the data has been changed, call it 'DataHasChanged'
        public event EventHandler DataHasChanged;

        /// <summary>
        /// Contructor for creating an ImageGallery, on default it should contain a default image so using UI early wouldn't throw an exception
        /// </summary>
        /// <param name="imageCounter"></param>
        public ImageGallery()
        {

        }

        /// <summary>
        /// Retrieves the current image from the list
        /// </summary>
        public Image CurrentImage { get { return _dataStorage.GetImage(_currentImageIndex); } }

        /// <summary>
        /// Adds an image to the gallery of images from a file
        /// </summary>
        /// <param name="fileName">The path of the file to add</param>
        public string AddImage(string fileName)
        {
            return AddImage(Image.FromFile(fileName), fileName);
        }

        /// <summary>
        /// Adds an image to the gallery of images if the filepath is empty with a custom ID
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public string AddImage(Image image)
        {
            string id = _id + "*NoFilePath*";
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
            OnDataHasChanged();
            return imageName;
        }


        /// <summary>
        /// Asks storage to remove unnecessary images
        /// </summary>
        public void DeleteImage()
        {
            _dataStorage.RemoveImage();
            OnDataHasChanged();
        }

        public void OnDataHasChanged()
        {
            DataHasChanged(this, EventArgs.Empty);
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


        public void Subscribe(EventHandler dataHasBeenChanged)
        {
            DataHasChanged += dataHasBeenChanged;
        }


        public void Unsubscribe(EventHandler dataHasBeenChanged)
        {
            DataHasChanged -= dataHasBeenChanged;
        }
    }
}
