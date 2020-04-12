using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controller
{
    class ComponentInitializator
    {
        // DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;

        ILoader _loader;

        View.CollectionView _collectionView;

        View.ImagePinkifier _displayView;

        IImageGallery _imageGallery;

        public ComponentInitializator()
        {
            _factoryLocator = new FactoryLocator();
            _imageGallery = new ImageGallery();
            _loader = new ImageLoader();
            //_imageGallery = (_factoryLocator.Get<ImageGallery>() as IFactory<IImageGallery>).Create<ImageGallery>();
            //_loader = (_factoryLocator.Get<ImageLoader>() as IFactory<ILoader>).Create<ImageLoader>();
            //Create EventHandler for loading an image
            _collectionView = new View.CollectionView(GetImages);
            //Will include <T,T...> for delegates that should be passed in
            _displayView = (_factoryLocator.Get<View.ImagePinkifier>() as IFactory<View.ImagePinkifier>).Create<View.ImagePinkifier>();

            Application.Run(_collectionView);
        }

        public List<Image> GetImages()
        {
            //Ask to load images
            _loader.Load(_imageGallery);
            //Return a list of images
            return _imageGallery.GetAllImages();
        }
    }
}
