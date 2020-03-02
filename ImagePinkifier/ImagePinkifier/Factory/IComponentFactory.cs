using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Factory
{
    interface IComponentFactory
    {
        IComponent Get<T>() where T : IComponent, new();
    }
}
