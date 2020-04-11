using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class ComponentInitializator
    {
        // DECLARE an IServiceLocator to refer to the factory locator, call it _factoryLocator:
        IServiceLocator _factoryLocator;

        View.CollectionView collectionView;

        View.ImagePinkifier displayView;

        public ComponentInitializator()
        {
            _factoryLocator = new FactoryLocator();
            collectionView = (_factoryLocator.Get<View.CollectionView>() as IFactory<View.CollectionView>).Create<View.CollectionView>();
            //Will include <T,T...> for delegates that should be passed in
            displayView = (_factoryLocator.Get<View.ImagePinkifier>() as IFactory<View.ImagePinkifier>).Create<View.ImagePinkifier>();

            Application.Run();
        }
    }
}
