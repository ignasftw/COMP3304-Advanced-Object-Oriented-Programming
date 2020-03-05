using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Data class which stores a dictionary which contain Images and pathfile names or ID. This class only adds and return and stores data
    /// </summary>
    class Data : IData, IAddRemove
    {
        //Declare a List of Image, store a list of images and pathfile names, call it '_images'
        private Dictionary<string, Image> _images = new Dictionary<string, Image>();

        /// <summary>
        /// Property which returns amount of currently stored images
        /// </summary>
        public int Count { get { return _images.Count; } }

        /// <summary>
        /// Method which returns a required image depending on int id
        /// </summary>
        /// <param name="imageID"></param>
        /// <returns>A required image from the list</returns>
        public Image GetImage(int imageID)
        {
            return _images.ElementAt(imageID).Value;
        }

        /// <summary>
        /// Method which returns a required image depending on pathfile name or ID
        /// </summary>
        /// <param name="fileName">Pathfile name or ID</param>
        /// <returns>A required image from the list</returns>
        public Image GetImage(string fileName)
        {
            return _images[fileName];
        }

        /// <summary>
        /// Method which returns a required images ID depending on int ID
        /// </summary>
        /// <param name="imageID">int ID on the dictionary (usually starts from 0 then 1, 2, 3...)</param>
        /// <returns>A string which should be pathfile name or ID</returns>
        public string GetFileName(int imageID)
        {
            return _images.ElementAt(imageID).Key;
        }

        /// <summary>
        /// Method which adds an image to the storage. Then it returns an ID for later ID generation if it's empty
        /// </summary>
        /// <param name="image">Image which should be added to the dictionary</param>
        /// <param name="imageName">Images pathfile name or ID</param>
        /// <returns>Images pathfile name or ID</returns>
        public string AddImage(Image image, string imageName)
        {
            //Begin the list of images with one default image

            if (!_images.ContainsKey(imageName))
            {
                _images.Add(imageName, image);
            }
            return imageName;
        }

        /// <summary>
        /// Remove Default images which doesn't have a pathfile name
        /// </summary>
        public void RemoveImage()
        {
            if (_images.ContainsKey(""))
            {
                _images.Remove("");
            }
        }
    }
}
