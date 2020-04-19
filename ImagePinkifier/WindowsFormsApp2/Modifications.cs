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
        private ImageFactoryLocal _imageFactory;
        private Dictionary<String, Func<Image,object[],ImageFactoryLocal, ImageFactoryLocal>> _modifications;

        public Modifications()
        {
            _imageFactory = new ImageFactoryLocal();
            _modifications = new Dictionary<string, Func<Image, object[], ImageFactoryLocal, ImageFactoryLocal>>();
        }

        public void AddModification(string name, Func<Image, object[], ImageFactoryLocal, ImageFactoryLocal> del)
        {
            _modifications.Add(name, del);
        }

        public void ApplyModification(DataPackage data)
        {
            Func<Image, object[], ImageFactoryLocal, ImageFactoryLocal> modify = _modifications[data._modificationName];
            _imageFactory = modify(data._modifyImage,data._parameters, _imageFactory);
        }

        public Func<Image, object[], ImageFactoryLocal, ImageFactoryLocal> GetModification(string name)
        {
            return _modifications[name];
        }
    }
}
