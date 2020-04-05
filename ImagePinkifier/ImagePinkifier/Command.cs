using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Command class which requires no parameters
    /// </summary>
    class Command : ICommand
    {
        //DECLARE an Action which will be used to execute, call it '_action'
        private Action _action;

        /// <summary>
        /// Constructor which requires an action to work
        /// </summary>
        /// <param name="action">An action which will be used to execute</param>
        public Command(Action action)
        {
            _action = action;
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        public void Execute()
        {
            _action();
        }
    }
}
