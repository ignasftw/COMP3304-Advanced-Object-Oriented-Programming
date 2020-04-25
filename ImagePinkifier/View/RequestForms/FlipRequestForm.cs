﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.RequestForms
{
    public partial class FlipRequestForm : Form
    {
        Action<ICommand> _executor;

        Action<bool[]> _sendFlip;

        public FlipRequestForm(Action<bool[]> sendFlip, Action<ICommand> executor)
        {
            InitializeComponent();
            _sendFlip = sendFlip;
            _executor = executor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (VerticalFlip.Checked)
            {
                bool[] flip = { false, false };
                flip[0] = true;
                _executor(new Command<bool[]>((_sendFlip), flip));
            }
            if (HorizontalFlip.Checked)
            {
                bool[] flip = { false, false };
                flip[0] = true;
                _executor(new Command<bool[]>((_sendFlip), flip));
                flip[1] = true;
                _executor(new Command<bool[]>((_sendFlip), flip));
            }
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
