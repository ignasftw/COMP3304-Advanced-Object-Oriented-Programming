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
        // DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;

        ILoader _loader;

        View.CollectionView _collectionView;

        View.ImagePinkifier _displayView;

        IImageGallery _imageGallery;



        public Controller()
        {
            _factoryLocator = new FactoryLocator();
            _imageGallery = new ImageGallery();
            _loader = new ImageLoader();
            //Create EventHandler for loading an image
            _collectionView = new View.CollectionView(LoadImages, GetImages, SingleItemDisplay);
            //Will include <T,T...> for delegates that should be passed in
            _displayView = (_factoryLocator.Get<View.ImagePinkifier>() as IFactory<View.ImagePinkifier>).Create<View.ImagePinkifier>();

            _imageGallery.Subscribe(_collectionView.OnDataHasBeenChanged);

            Application.Run(_collectionView);
        }

        public void SingleItemDisplay()
        {
            _displayView.Show();
            _displayView.PictureBox.Image = _imageGallery.GetAllImages()[_collectionView._selectedImage];
        }

        public void LoadImages()
        {
            //Ask to load images
            _loader.Load(_imageGallery);
        }

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
