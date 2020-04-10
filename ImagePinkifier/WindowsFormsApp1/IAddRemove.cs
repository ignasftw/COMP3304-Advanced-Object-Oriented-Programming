using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    /// <summary>
    /// IAddRemove interface which adds and removes images
    /// </summary>
    interface IAddRemove
    {
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
