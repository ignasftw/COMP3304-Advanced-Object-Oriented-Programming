using System;
using System.Windows.Forms;

namespace View.RequestForms
{
    public partial class FlipRequestForm : Form
    {
        Action<ICommand> _executor;

        Action<int[]> _sendFlip;

        public FlipRequestForm(Action<int[]> sendFlip, Action<ICommand> executor)
        {
            InitializeComponent();
            _sendFlip = sendFlip;
            _executor = executor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (VerticalFlip.Checked)
            {
                int[] flip = { 0, 0 };
                flip[0] = 1;
                _executor(new Command<int[]>((_sendFlip), flip));
            }
            if (HorizontalFlip.Checked)
            {
                int[] flip = { 0, 0 };
                flip[0] = 1;
                _executor(new Command<int[]>((_sendFlip), flip));
                flip[1] = 1;
                _executor(new Command<int[]>((_sendFlip), flip));
            }
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
