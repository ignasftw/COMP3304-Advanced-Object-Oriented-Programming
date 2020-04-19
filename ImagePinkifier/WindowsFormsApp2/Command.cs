 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Command : ICommand
    {
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

    /// <summary>
    /// Command class which requires no parameters
    /// </summary>
    class Command<T> : ICommand
    {
        //DECLARE an Action which will be used to execute, call it '_action'
        private Action<T> _action;

        //DECLARE Generic Type, which will store parameters of method, call it '_data'
        private T _data;

        /// <summary>
        /// Constructor which requires an action and Generic Type to work
        /// </summary>
        /// <param name="action">An action which will be used to execute</param>
        /// <param name="data">Type which describes parameters</param>
        public Command(Action<T> action, T data)
        {
            _action = action;
            _data = data;
        }

        /// <summary>
        /// Executes the command with the data inside
        /// </summary>
        public void Execute()
        {
            _action(_data);
        }
    }
}
