using System;
using System.Windows.Forms;

namespace View.RequestForms
{
    public partial class FlipRequestForm : Form
    {
        Action<ICommand> _executor;

        Action<string, int[]> _sendFlip;

        public FlipRequestForm(Action<string,int[]> sendFlip, Action<ICommand> executor)
        {
            InitializeComponent();
            _sendFlip = sendFlip;
            _executor = executor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int[] flip = { 0, 0 };

            if (VerticalFlip.Checked)
            {
                flip[0] = 1;
            }
            if (HorizontalFlip.Checked)
            {
                flip[1]= 1;
            }
            _executor(new Command<string, int[]>(_sendFlip, "Flip", flip));

            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
