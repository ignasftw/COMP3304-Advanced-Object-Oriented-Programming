﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Controller
{
    class Modifications : IModifications, IService
    {
        //DELCAIRE a Dictionary where all the Action<int[]> will be stored, and string will be modification's name, call it '_modifications'
        private Dictionary<String, Action<int[]>> _modifications;
        //DECLARE an IImageGallery interface for communicating with Data, call it '_galery'
        private IImageGallery _galery;
        //DECALRE a IVideoModify Interface for modifying videos, call it '_modify'
        private Video.IVideoModify _modify;
        //DECLARE a delegate which takes in a string and outputs a string which checks extension type, call it '_extensionCheck'
        private Func<string, string> _extensionCheck;

        public Modifications(IImageGallery galery, Video.IVideoModify modify, Func<string, string> extensioncheck)
        {
            _modifications = new Dictionary<string, Action<int[]>>();
            _modify = modify;
            _galery = galery;
            _extensionCheck = extensioncheck;
        }

        /// <summary>
        /// Property which tell how many modifications are in the disctionary
        /// </summary>
        public int Count { get { return _modifications.Count; } }

        /// <summary>
        /// METHOD: Adds a void Delegate to a list which modifies an Image
        /// </summary>
        /// <param name="name">Naming of a modification</param>
        /// <param name="del">An action which takes int[] as a parameter</param>
        public void AddModification(string name, Action<int[]> del)
        {
            _modifications.Add(name, del);
        }

        /// <summary>
        /// METHOD: Applies a modification to an Image
        /// </summary>
        /// <param name="modificationName">Name of modification, what should be done</param>
        /// <param name="data">Parameters of modification, how it should be done</param>
        public void ApplyModification(string modificationName, params int[] data)
        {

            if (_extensionCheck(_galery.GetPathName) == "Image")
            {
                _modifications[modificationName](data);
            }
            else
            {
                if(modificationName != "Scale")
                {
                    _modify.SaveVideo(_galery.GetPathName, GetModification(modificationName), _galery.GetImage().Size, data);
                }
                else
                {
                    if(data[0]%2 == 1 || data[1] % 2 == 1)
                    {
                        //Let the User know that something went wrong
                        MessageBox.Show("Error: " + "Size of a video must be multiplier of 2" + " \nIf you think that is a bug please contant the developer.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        _modify.SaveVideo(_galery.GetPathName, GetModification(modificationName), new Size(data[0], data[1]), data);
                    }
                }
            }
        }

        /// <summary>
        /// METHOD: Returns a modification of a modification by name
        /// </summary>
        /// <param name="name">A already named modification</param>
        /// <returns>Action<int[]> Modification</returns>
        public Action<int[]> GetModification(string name)
        {
            return _modifications[name];
        }
    }
}