using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Controller
{
    class Controller
    {
        //DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;
        //DECLARE an ILoader which is loading images to the Data, call it '_loader'
        ILoader _loader;
        //DECLARE a CollectionView which is responsible for displaying collections View, call it '_collectionView'
        View.CollectionView _collectionView;
        //DECLARE a ImagePinkifier which is responsible for displaying one item's View, call it '_displayView'
        View.ImagePinkifier _displayView;
        //DECLARE an IImageGallery which will store interface for dealing with changes in data, call it '_imageGallery'
        IImageGallery _imageGallery;
        //DECLARE a ImageFactoryLocal for making modifications to the Images, call it '_imageFactory'
        ImageFactoryLocal _imageFactory;
        //DECLARE a Modifications for storing and using Delegates which will be used to modify Images, call it '_modify'
        Modifications _modify;

        public Controller()
        {
            _imageFactory = new ImageFactoryLocal();
            _factoryLocator = new FactoryLocator();
            _imageGallery = new ImageGallery();
            _loader = new ImageLoader();
            _modify = new Modifications();

            Size scaleDimensions = new Size(400,10);
            float rotateAngle = 3456f;
            bool[] flip = { false, true };
            Command resetCommand = new Command(SingleItemDisplay);
            Command<Size> scaleCommand = new Command<Size>(_imageFactory.Resize, scaleDimensions);
            Command<float> rotateCommand = new Command<float>(_imageFactory.Rotate, rotateAngle);
            Command<bool[]> flipCommand = new Command<bool[]>(_imageFactory.Flip, flip);
            Command<string> saveCommand = new Command<string>(_imageFactory.Save, "C:/Users/Viktorija/Desktop");

            //Create EventHandler for loading an image
            _collectionView = new View.CollectionView(LoadImages, GetImages, SingleItemDisplay);
            //IF any of the commands are pressed then open request window
            _displayView = new View.ImagePinkifier(_imageFactory.Resize, _imageFactory.Rotate, _imageFactory.Flip, _imageFactory.Save, SingleItemDisplay);
            //SUBSCRIBE to _imageGallery, so it tells when there are changes in Data
            _imageGallery.Subscribe(_collectionView.OnDataHasBeenChanged);
            //SUBSCRIBE to _imageFactory so it tells when any of the modifications were done
            _imageFactory.Subscribe(UpdateImage);
            //INITIALIZE the main window
            Application.Run(_collectionView);
        }

        /// <summary>
        /// Loading an image the the single into a _displayView
        /// </summary>
        public void SingleItemDisplay()
        {
            _displayView.Show();
            _displayView.PictureBox.Image = _imageGallery.GetAllImages()[_collectionView._selectedImage];
            _imageFactory.Load(_imageGallery.GetAllImages()[_collectionView._selectedImage]);
        }

        /// <summary>
        /// Update Single Item View if any modification was applied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateImage(object sender, EventArgs e)
        {
            _displayView.PictureBox.Image = _imageFactory.GetImage;
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
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }


        public void SaveImage()
        {
            //Open file select dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //Let the dialog form assume that the default extension is "jpg"
                DefaultExt = "jpg"
            };

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _imageFactory.Save(saveFileDialog.FileName);
            }
        }
    }
}
