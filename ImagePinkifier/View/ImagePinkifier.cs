﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// This class controls the GUI for the program, it has references to all the classes that do the actual work
    /// </summary>
    public partial class ImagePinkifier : Form
    {
        /*Delegates which will be used as commands*/

        //DECLARE a Delegate which asks to Save Image
        private Action _saveImageDelegate;

        //DECLARE a Delegate which reloads the Image
        private Action _reloadDelegate;

        Action<string, int[]> _applyMod;

        private Action<ICommand> _executeCommand;

        /// <summary>
        /// ImagePinkifier's constructor which will initialise the Component for User-Interface, an ImageGallery, an ImageSaver
        /// </summary>
        public ImagePinkifier(Action<string, int[]> applyMod, Action saveImage, Action resetCommand, Action<ICommand> execute)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();
            _saveImageDelegate = saveImage;
            _reloadDelegate = resetCommand;

            _applyMod = applyMod;
            _executeCommand = execute;
        }

        private void ImagePinkifier_Load(object sender, EventArgs e)
        {

        }

        public PictureBox PictureBox { get { return pictureBox; } }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            RequestForms.ScaleRequestForm scaleRequest = new RequestForms.ScaleRequestForm(_applyMod);
            scaleRequest.PutPictureNumbers(PictureBox.Image.Width, PictureBox.Image.Height);
            scaleRequest.Show();
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            RequestForms.RotateRequestForm rotateRequest = new RequestForms.RotateRequestForm(_applyMod);
            rotateRequest.Show();
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            RequestForms.FlipRequestForm flipRequest = new RequestForms.FlipRequestForm(_applyMod, _executeCommand);
            flipRequest.Show();
        }

        private void MakePinkerButton_Click(object sender, EventArgs e)
        {
            _executeCommand(new Command<string, int[]>(_applyMod, "Tint",new int[] { }));
        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            _executeCommand(new Command(_reloadDelegate));
        }

        /// <summary>
        /// Calling a SaveImage Command after the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _executeCommand(new Command(_saveImageDelegate));
        }

            public void SetVideo(string name)
        {
            videoPlayerBox.Show();
            axWindowsMediaPlayer1.URL = name;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        public void HidePlayer()
        {
            videoPlayerBox.Hide();
        }
    }
}
