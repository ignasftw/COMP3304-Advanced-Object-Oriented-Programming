using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video.FFMPEG;

namespace Controller
{
    /// <summary>
    /// ImageGallery stores a gallery of images
    /// </summary>
    public class ImageGallery : IImageGallery, IComponent, IModel
    {
        //Declare a Data class, for storing Image/Imagepathfile dictionary, call it '_dataStorage'
        Model.IData _dataStorage = new Model.Data();
        //Declare an int, this is id of the image, call it '_id'
        private string _id = "";
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
        public int ImageIndex { set; get; } = 0;

        /// <summary>
        /// PROPERTY tells the pathfilename which is currently loaded
        /// </summary>
        public string GetPathName { get { return _dataStorage.GetFileName(ImageIndex); } }

        /// <summary>
        /// Adds an image to the gallery of images from a file
        /// </summary>
        /// <param name="fileName">The path of the file to add</param>
        public string AddImage(string fileName)
        {
            return AddImage(Image.FromFile(fileName), fileName);
        }

        /// <summary>
        /// Adds an image to the gallery of images from a file
        /// </summary>
        /// <param name="fileName">The path of the file to add</param>
        public string AddVideo(string fileName)
        {
            VideoFileReader _reader = new VideoFileReader();
            _reader.Open(fileName);
            return AddImage(_reader.ReadVideoFrame() as Image, fileName);
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
            (_dataStorage as Model.IAddRemove).AddImage(image, imageName);
            OnDataHasChanged();
            return imageName;
        }


        /// <summary>
        /// Asks storage to remove unnecessary images
        /// </summary>
        public void DeleteImage()
        {
            (_dataStorage as Model.IAddRemove).RemoveImage();
            OnDataHasChanged();
        }

        /// <summary>
        /// METHOD: setting up DataHasChanged Event
        /// </summary>
        private void OnDataHasChanged()
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
            //Get a new list where pathnames will be stores
            IList<string> ids = new List<string>();
            //Cycle through every selected pathfilename
            foreach (string s in pathfilenames)
            {
                //Get the extension name
                string ext = Path.GetExtension(s);
                try
                {
                    switch (ext)
                    {
                        //Check image types
                        case (".jpg"):
                        case (".jpeg"):
                        case (".jpe"):
                        case (".jfif"):
                        case (".png"):
                            ids.Add(AddImage(s));
                            break;
                        default:
                            //Assume it is video
                            ids.Add(AddVideo(s));
                            break;
                    }
                }
                catch (Exception e)
                {
                    //Let the User know that something went wrong
                    MessageBox.Show("Error: " + e.Message + " \nIf you think that is a bug please contant the developer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Console.WriteLine("Error: {0}", e);
                }
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

        /// <summary>
        /// Implementing IModel which required to return an image of certain width and height, but this is done in a separate class because of Single Responsability Principle
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Image GetImage()
        {
            return _dataStorage.GetImage(ImageIndex);
        }

        /// <summary>
        /// METHOD: returns all the images contained within the Data
        /// </summary>
        /// <returns></returns>
        public List<Image> GetAllImages()
        {
            List<Image> tempImages = new List<Image>();
            for (int i = 0; i < _dataStorage.Count; i++)
            {
                tempImages.Add(_dataStorage.GetImage(i));
            }
            return tempImages;
        }

        /// <summary>
        /// SUBSCRIBE to DataHasChanged event
        /// </summary>
        /// <param name="dataHasBeenChanged"></param>
        public void Subscribe(EventHandler dataHasBeenChanged)
        {
            DataHasChanged += dataHasBeenChanged;
        }

        /// <summary>
        /// UNSUBSCRIBE to DataHasChanged event
        /// </summary>
        /// <param name="dataHasBeenChanged"></param>
        public void Unsubscribe(EventHandler dataHasBeenChanged)
        {
            DataHasChanged -= dataHasBeenChanged;
        }
    }
}
