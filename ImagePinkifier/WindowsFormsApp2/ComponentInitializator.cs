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
        //IServiceLocator _factoryLocator;

        public ComponentInitializator()
        {

            Application.Run(new View.CollectionView());
        }
    }
}
