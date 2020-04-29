using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    interface IModifications
    {
        /// <summary>
        /// Property which tell how many modifications are in the disctionary
        /// </summary>
        int Count { get; }

        /// <summary>
        /// METHOD: Adds a void Delegate to a list which modifies an Image
        /// </summary>
        /// <param name="name">Naming of a modification</param>
        /// <param name="del">An action which takes int[] as a parameter</param>
        void AddModification(string name, Action<int[]> del);

        /// <summary>
        /// METHOD: Applies a modification to an Image
        /// </summary>
        /// <param name="modificationName">Name of modification, what should be done</param>
        /// <param name="data">Parameters of modification, how it should be done</param>
        void ApplyModification(string modificationName, params int[] data);

        /// <summary>
        /// METHOD: Returns a modification of a modification by name
        /// </summary>
        /// <param name="name">A already named modification</param>
        /// <returns>Action<int[]> Modification</returns>
        Action<int[]> GetModification(string name);
    }
}
