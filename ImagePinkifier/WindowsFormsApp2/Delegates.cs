using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using View;

namespace Controller
{
    public class Delegates
    {
        /*____________________________________________________*/
        // Declare a generic delegate with no parameters and no return value to implement Strategy Pattern, call it StrategyDelegate.
        public delegate void StrategyDelegate();

        // Declare a delegate that is used to excute commands, call it ExecuteDelegate.
        public delegate void ExecuteDelegate(ICommand command);

        /*____________________________________________________*/
        //DECLARE a Delegate which asks to Scale Image
        public delegate void ScaleImageDelegate(Size scaleToSize);

        //DECLARE a Delegate which asks to Rotate Image
        public delegate void RotateImageDelegate(int angle);

        //DECLARE a Delegate which asks to Flip Image
        public delegate void FlipImageDelegate();

        //DECLARE a Delegate which asks to Save Image
        public delegate void SaveImageDelegate();

        /*____________________________________________________*/
        //DECLARE a Delegate which loads an image to the List
        public delegate void LoadImageListDelegate();

        //DECLARE a Delegate which loads an image the the View
        public delegate void LoadImageViewDelegate();


    }
}
