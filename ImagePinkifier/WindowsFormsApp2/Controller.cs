using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using View;

namespace Controller
{
    class Controller
    {
        //DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;
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
        ImageFactoryLocal _imageFactory;

        //DECLARE a Modifications for storing and using Delegates which will be used to modify Images, call it '_modify'
        //Modifications _modify;

        public Controller()
        {
            //Create main objects_________________________________________
            _imageFactory = new ImageFactoryLocal();
            _factoryLocator = new FactoryLocator();
            _imageGallery = new ImageGallery();
            _loader = new ImageLoader();
            _saver = new ImageSaver(_imageFactory);

            //Create commands for UserInputs______________________________
            Size scaleDimensions = new Size(400, 10);
            float rotateAngle = 3456f;
            bool[] flip = { false, true };
            Command resetCommand = new Command(SingleItemDisplay);
            Command<Size> scaleCommand = new Command<Size>(_imageFactory.Resize, scaleDimensions);
            Command<float> rotateCommand = new Command<float>(_imageFactory.Rotate, rotateAngle);
            Command<bool[]> flipCommand = new Command<bool[]>(_imageFactory.Flip, flip);
            Command<string> saveCommand = new Command<string>(_imageFactory.Save, "C:/Users/Viktorija/Desktop");

            //Create EventHandler for loading an image_____________________
            _collectionView = new View.CollectionView(LoadImages, GetImages, SingleItemDisplay);
            //IF any of the commands are pressed then open request window
            _displayView = new View.ImagePinkifier(_imageFactory.Resize, _imageFactory.Rotate, _imageFactory.Flip, saveCommand, SingleItemDisplay, ExecuteCommand);


            //SUBSCRIBE to _imageGallery, so it tells when there are changes in Data
            _imageGallery.Subscribe(OnDataHasBeenChanged);
            //SUBSCRIBE to _imageFactory so it tells when any of the modifications were done
            _imageFactory.Subscribe(UpdateImage);

            //INITIALIZE the main window___________________________________
            Application.Run(_collectionView);
        }

        /// <summary>
        /// Loading an image the the single into a _displayView
        /// </summary>
        public void SingleItemDisplay()
        {
            Image selectedImage = _imageGallery.GetAllImages()[_collectionView._selectedImage];
            _displayView.Show();
            _displayView.PictureBox.Image = selectedImage;
            _imageFactory.Load(selectedImage);
        }

        /// <summary>
        /// Update Single Item View if any modification was applied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateImage(object sender, EventArgs e)
        {
            //Ask the factory to return the current Image
            _displayView.PictureBox.Image = _imageFactory.GetImage;
        }

        public void OnDataHasBeenChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            List<Image> displayList = GetImages();
            if (displayList != null)
            {
                ImageList imageList1 = new ImageList();
                ListView ListView1 = new ListView();
                List<ListViewItem> items = new List<ListViewItem>();

                imageList1.Images.Clear();
                ListView1.Clear();
                int imageid = 0;

                imageList1.Images.AddRange(displayList.ToArray());
                _collectionView.SetImageList(displayList.ToArray());


                for (int i = 0; i < displayList.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = imageid;
                    item.Tag = imageid.ToString();
                    items.Add(item);
                    imageid++;
                }
                //ListView1.Items.AddRange(items.ToArray());
                _collectionView.SetListView(items.ToArray());
            }
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
        /// Save an image to save a file to pathfile name
        /// </summary>
        public void SaveImage()
        {
            //Ask an ImageSaver to save a file to pathfile name
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Let the dialog form assume that the default extension is "jpg"
                DefaultExt = "jpg"
            };

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _saver.SaveImage();
            }
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
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
