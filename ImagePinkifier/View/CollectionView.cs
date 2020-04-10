﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CollectionView : Form
    {
        //Declare an IImageFactoryLocal which would be responsible for returning modified version of an image, call it '_imfac'
        //private IImageFactoryLocal _imfac;

        //Declare an ILoader which would be responsible for loading images into the galery, call it '_loading'
        //private ILoader _loading;

        //Declare a factory which will be creating and returning components, call it'_factory'
        //private Factory.IComponentFactory _factory = new Factory.ComponentFactory();

        //Declare an IImageGallery which will store Image Galery, call it '_imageGallery'
        //private IImageGallery _imageGallery;

        //Single Image display window
        private ImagePinkifier _imagePinkifier;

        //List of images which has to be displayed
        List<Image> _displayList;

        private void CollectionView_Load(object sender, EventArgs e)
        {

        }

        public CollectionView()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            //_imagePinkifier = new ImagePinkifier();
            //Initialising ImageFactory Component
            //_imfac = (IImageFactoryLocal)_factory.Get<ImageFactoryLocal>();
            //Initialising Image Loader Component
            //_loading = (ILoader)_factory.Get<ImageLoader>();
            //Creating through factory doesn't allow to pass any variables
            //_imageGallery = new ImageGallery(imageCounter, imageName, _imagePinkifier.PictureBox);

            //listView1.Columns.Add("Item");
            //listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //Change into a comand call which calls which adds images if there are not on the list
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            /*Delegate which returns images and adds to the list*/


            //DECLARE an ImageCollection to get currently loaded images
            ImageList.ImageCollection getList = imageList1.Images;
            //Loadgin all the images and storing them into Data class
            //_loading.Load(_imageGallery, _imagePinkifier.PictureBox, _imfac);
            //Retrieve Locally loaded images
            List<Image> tempList;
            //Show the main Image Display Window after the images are loaded
            _imagePinkifier.Show();

            //Setup how the list looks like
            imageList1.ImageSize = new Size(96, 96);
            //listView1.View = View.LargeIcon;
            listView1.LargeImageList = this.imageList1;

        }

        /// <summary>
        /// Method which updates Classes View
        /// </summary>
        void UpdateUI()
        {

        }

        void AddImageElement()
        {
            PictureBox item;
            //item.
        }
    }
}
