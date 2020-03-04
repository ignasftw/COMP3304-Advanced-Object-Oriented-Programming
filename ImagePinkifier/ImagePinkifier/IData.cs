using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    interface IData
    {
        /// <summary>
        /// Property which returns amount of currently stored images
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Method which returns a required image depending on int id
        /// </summary>
        /// <param name="imageID"></param>
        /// <returns>A required image from the list</returns>
        Image GetImage(int imageID);

        /// <summary>
        /// Method which returns a required image depending on pathfile name or ID
        /// </summary>
        /// <param name="fileName">Pathfile name or ID</param>
        /// <returns>A required image from the list</returns>
        Image GetImage(string fileName);

        /// <summary>
        /// Method which returns a required images ID depending on int ID
        /// </summary>
        /// <param name="imageID">int ID on the dictionary (usually starts from 0 then 1, 2, 3...)</param>
        /// <returns>A string which should be pathfile name or ID</returns>
        string GetFileName(int imageID);

        /// <summary>
        /// Method which adds an image to the storage. Then it returns an ID for later ID generation if it's empty
        /// </summary>
        /// <param name="image">Image which should be added to the dictionary</param>
        /// <param name="imageName">Images pathfile name or ID</param>
        /// <returns>Images pathfile name or ID</returns>
        string AddImage(Image image, string imageName);

        /// <summary>
        /// Remove Default images which doesn't have a pathfile name
        /// </summary>
        void RemoveImage();
    }
}
