using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Interface for a factory that returns implementations of a specific abstraction (eg interface) E
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public interface IFactory<E>
    {
        /// <summary>
        /// Instantiate and return an object that supports the Interface 'T'
        /// </summary>
        /// <typeparam name="T">The concrete class to be instantiated</typeparam>
        /// <returns>The new instance of Type T</returns>
        E Create<T>() where T : E, new();
    }
}
