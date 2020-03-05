using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    /// <summary>
    /// IData inteface which allows to retrieve information from the class
    /// </summary>
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
    }
}
