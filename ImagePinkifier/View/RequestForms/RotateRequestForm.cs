using System;
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
    public partial class RotateRequestForm : Form
    {

        Action<float> _sendRotate;

        public RotateRequestForm(Action<float> sendRotate)
        {
            InitializeComponent();

            _sendRotate = sendRotate;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _sendRotate(float.Parse(AngleTextbox.Text));
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
