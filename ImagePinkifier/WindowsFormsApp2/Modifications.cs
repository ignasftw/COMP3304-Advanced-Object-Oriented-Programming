using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Controller
{
    class Modifications
    {
        private IImageFactoryLocal _imageFactory;
        private Dictionary<String, Action<int[]>> _modifications;

        public Modifications(IImageFactoryLocal imageFactory)
        {
            _imageFactory = imageFactory;
            _modifications = new Dictionary<string, Action<int[]>>();
        }

        public void AddModification(string name, Action<int[]> del)
        {
            _modifications.Add(name, del);
        }

        public void ApplyModification(string modificationName, params int[] data)
        {
            Action<int[]> modify = _modifications[modificationName];
            modify(data);
        }

        public Action<int[]> GetModification(string name)
        {
            return _modifications[name];
        }
    }
}
