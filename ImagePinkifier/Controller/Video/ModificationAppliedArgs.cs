using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Video
{
    public class ModificationAppliedArgs : EventArgs
    {
        public string Pathfile { get; set; }
    }
}
