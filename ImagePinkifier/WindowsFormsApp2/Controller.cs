using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controller
{
    class Controller
    {
        public Controller()
        {
            // Fire-up UI by instantiating FishyNotes:
            Application.Run(new View.CollectionView());
        }

        /// <summary>
        /// Implementation of the ExecuteDelegate, for the Command Pattern
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
