using System;
using System.Windows.Forms;

namespace View.RequestForms
{
    public partial class RotateRequestForm : Form
    {

        Action<int[]> _sendRotate;

        public RotateRequestForm(Action<int[]> sendRotate)
        {
            InitializeComponent();

            _sendRotate = sendRotate;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _sendRotate(new int[] { System.Convert.ToInt32(AngleTextbox.Text) });
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
