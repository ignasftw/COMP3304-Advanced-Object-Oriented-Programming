using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Implementation of a factory that returns implementations of a specific abstraction (eg interface) E
    /// </summary>
    /// <typeparam name="E">The specific abstraction required (a constraint)</typeparam>
    public class Factory<E> : IFactory<E>
    {
        /// <summary>
        /// Instantiate and return an object that supports the Interface 'E'
        /// </summary>
        /// <typeparam name="T">The concrete class to be instantiated</typeparam>
        /// <returns>The new instance of Type T</returns>
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
