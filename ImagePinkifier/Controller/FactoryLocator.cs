using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Factory locator implementation - a Service Locator
    /// </summary>
    public class FactoryLocator : IServiceLocator
    {

        // DECLARE an IDictionary to contain references to IService objects, accessed via the Type that each Factory creates.
        // Call it _factoryRegister:
        private IDictionary<Type, IService> _factoryRegister;


        /// <summary>
        /// Constructor of objects of type FactoryLocator.
        /// </summary>
        public FactoryLocator()
        {
            // INSTANTIATE _factoryRegister:
            _factoryRegister = new Dictionary<Type, IService>();
        }

        /// <summary>
        /// Return a concrete factory for creating a given Type.
        /// </summary>
        /// <typeparam name="T">The type of the abstraction (ie abstract class or interface) of the required factory</typeparam>
        /// <returns></returns>
        public IService Get<T>() where T : class
        {
            // Register factory if a factory for rqd Type is not yet registered:
            if (!_factoryRegister.ContainsKey(typeof(T)))
            {
                _factoryRegister.Add(typeof(T), new Factory<T>());
            }

            // Return the requested factory:
            return _factoryRegister[typeof(T)];
        }

    }
}
