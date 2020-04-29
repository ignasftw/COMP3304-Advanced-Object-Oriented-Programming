using System;
using System.Windows.Forms;

namespace View.RequestForms
{
    public partial class FlipRequestForm : Form
    {
        Action<ICommand> _executor;

        Action<string, int[]> _sendFlip;

        public FlipRequestForm(Action<string, int[]> sendFlip, Action<ICommand> executor)
        {
            InitializeComponent();
            _sendFlip = sendFlip;
            _executor = executor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Check the inputs of a window and send with a created command
            _executor(new Command<string, int[]>(
                _sendFlip,
                "Flip",
                new int[] { System.Convert.ToInt16(VerticalFlip.Checked), System.Convert.ToInt16(HorizontalFlip.Checked) }));
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
