using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Windows.Forms;

namespace WindowsFormsApp1.Factory
{
    class ComponentFactory : IComponentFactory
    {
        public ComponentFactory()
        {

        }

        /// <summary>
        /// A factory which returns a class which implements IComponent
        /// </summary>
        /// <typeparam name="C"></typeparam>
        /// <returns></returns>
        public IComponent Get<T>() where T : IComponent, new()
        {
            IComponent I = new T();
            return I;
        }
    }
}
