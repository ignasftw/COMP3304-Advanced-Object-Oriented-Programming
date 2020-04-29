using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using View;
using System.IO;

namespace Controller
{
    class Controller
    {
        //DECLARE an ILoader which is loading images to the Data, call it '_loader'
        ILoader _loader;
        //DECLARE an IImageSaver which is saving images to the pathfile, call it '_saver'
        IImageSaver _saver;
        //DECLARE a CollectionView which is responsible for displaying collections View, call it '_collectionView'
        View.CollectionView _collectionView;
        //DECLARE a ImagePinkifier which is responsible for displaying one item's View, call it '_displayView'
        View.ImagePinkifier _displayView;
        //DECLARE an IImageGallery which will store interface for dealing with changes in data, call it '_imageGallery'
        IImageGallery _imageGallery;
        //DECLARE a ImageFactoryLocal for making modifications to the Images, call it '_imageFactory'
        IImageFactoryLocal _imageFactory;
        //DECLARE a Video.IVideoModify for video modifying process, call it '_vid'
        Video.IVideoModify _vid;
        //DECLARE a Modifications for storing and using Delegates which will be used to modify Images, call it '_modify'
        IModifications _modify;

        public Controller()
        {
            Factory<IService> factory = new Factory<IService>();
            //Create main objects_________________________________________
            _imageFactory = (factory.Create<ImageFactoryLocal>()) as ImageFactoryLocal;
            _imageGallery = (factory.Create<ImageGallery>()) as ImageGallery;
            _loader = (factory.Create<ImageLoader>()) as ImageLoader;
            _saver = new ImageSaver(_imageFactory);
            _vid = new Video.VideoModify(_imageFactory, ExecuteCommand);
            _modify = new Modifications(_imageGallery,_vid, CheckType);

            //TODO: create a separate class which inplements use of int[] into proper class 
            //Add a modification into a modification list
            _modify.AddModification("Rotate", _imageFactory.Rotate);
            _modify.AddModification("Scale", _imageFactory.Resize);
            _modify.AddModification("Flip", _imageFactory.Flip);
            _modify.AddModification("Tint", _imageFactory.Tint);

            //Create EventHandler for loading an image_____________________
            _collectionView = new View.CollectionView(LoadImages, SingleItemDisplay, ExecuteCommand);


            //IF any of the commands are pressed then open request window
            _displayView = new View.ImagePinkifier(_modify.ApplyModification, SaveImage, SingleItemDisplay, ExecuteCommand);
            //SUBSCRIBE to _imageGallery, so it tells when there are changes in Data
            _imageGallery.Subscribe(OnDataHasBeenChanged);
            //SUBSCRIBE to _imageFactory so it tells when any of the modifications were done
            _imageFactory.Subscribe(UpdateImage);
            //SUBSCRIBE to _vid, so it tells when a modification to a video has been applied
            _vid.Subscribe(UpdateVideo);
            //INITIALIZE the main window___________________________________
            Application.Run(_collectionView);
        }

        /// <summary>
        /// Load Images from ImageGallery
        /// </summary>
        public void LoadImages()
        {
            //Ask to load images
            _loader.Load(_imageGallery);
        }

        /// <summary>
        /// Get all the images which will be used to put into CollectionView
        /// </summary>
        /// <returns></returns>
        public List<Image> GetImages()
        {
            //Return a list of images
            return _imageGallery.GetAllImages();
        }

        /// <summary>
        /// Returns a pathfilename of a video
        /// </summary>
        /// <returns></returns>
        public string GetVideo()
        {
            return _imageGallery.GetPathName;
        }

        /// <summary>
        /// Get all the images converted into thumbnails because it would look streched on collection View
        /// </summary>
        /// <returns></returns>
        public List<Image> GetThumbnails()
        {
            //Return a list of images
            List<Image> temp = _imageGallery.GetAllImages();
            for (int i = 0; i < temp.Count; i++)
            {
                _imageFactory.Load(temp[i]);
                _imageFactory.Resize(_collectionView._thumbnailSize);
                temp[i] = _imageFactory.GetImage;
            }
            return temp;
        }

        /// <summary>
        /// Loading an image the the single into a _displayView
        /// </summary>
        public void SingleItemDisplay()
        {
            //Tell gallery which image is currently selected
            _imageGallery.ImageIndex = _collectionView._selectedImageIndex;
            if (CheckType(_imageGallery.GetPathName) == "Image")
            {
                _displayView.Show();
                _displayView.HidePlayer();
                //Get item from the gallery accordingly which item id was selected
                Image selectedImage = _imageGallery.GetImage();
                //Display Form which shows a single item
                _displayView.PictureBox.Show();
                //Set pictureBox to the selected image
                _displayView.PictureBox.Image = selectedImage;
                //Load that image to image factory
                _imageFactory.Load(selectedImage);
            }
            if (CheckType(_imageGallery.GetPathName) == "Video")
            {
                //Get item from the gallery accordingly which item id was selected
                string selectedVideo = _imageGallery.GetPathName;
                //Display Form which shows a single item
                _displayView.Show();
                _displayView.PictureBox.Hide();

                _displayView.SetVideo(selectedVideo);
            }
        }
         
        /// <summary>
        /// METHOD: which gets the pathfile name and tells(or assumes) what type of media it is
        /// </summary>
        /// <param name="pathname">Pathfile name of file (must have extension for ex. .mp4 or .png)</param>
        /// <returns></returns>
        public string CheckType(string pathname)
        {
            //Get the extension name
            string ext = Path.GetExtension(pathname);
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
                        return "Image";
                    default:
                        //Assume it is video
                        return "Video";
                }
            }
            catch (Exception e)
            {
                //Let the User know that something went wrong
                MessageBox.Show("Error: " + e.Message + " \nIf you think that is a bug please contant the developer.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine("Error: {0}", e);
            }
            return "";
        }

        /// <summary>
        /// Update Single Item View if any modification was applied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateImage(object sender, EventArgs e)
        {
            //Ask the factory to return the current Image after modification
            _displayView.PictureBox.Image = _imageFactory.GetImage;
        }

        /// <summary>
        /// Event receiver from ImageGallery if any changes happened in Data class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDataHasBeenChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Event receiver from Video.IVideoModify after the modification has been applied a new path has been returned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateVideo(object sender, Video.ModificationAppliedArgs e)
        {
            //This should be used to update the Window with loading with a new video
            //But the video has to be loaded first 
            //Currently it can only be loaded manually
        }

        /// <summary>
        /// METHOD which updates form's images with the one's being loaded
        /// </summary>
        private void UpdateUI()
        {
            List<Image> displayList = GetThumbnails();
            if (displayList != null)
            {
                ImageList imageList1 = new ImageList();
                ListView ListView1 = new ListView();
                List<ListViewItem> items = new List<ListViewItem>();

                //Clear the list
                imageList1.Images.Clear();
                ListView1.Clear();
                int imageid = 0;

                //Get images that the list will be made out of
                imageList1.Images.AddRange(displayList.ToArray());
                _collectionView.SetImageList(displayList.ToArray());

                //Create a new item of the list
                for (int i = 0; i < displayList.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = imageid;
                    item.Tag = imageid.ToString();
                    item.Name = imageid.ToString();
                    items.Add(item);
                    imageid++;
                }
                //ListView1.Items.AddRange(items.ToArray());
                _collectionView.SetListView(items.ToArray());
            }
        }

        /// <summary>
        /// Save an image to save a file to pathfile name
        /// </summary>
        public void SaveImage()
        {
            _saver.SaveImage();
        }

        /// <summary>
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
