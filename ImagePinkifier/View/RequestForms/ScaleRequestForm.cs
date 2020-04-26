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
    public partial class ScaleRequestForm : Form
    {
        Action<int[]> _sendScale;

        public ScaleRequestForm(Action<int[]> sendScale)
        {
            InitializeComponent();
            _sendScale = sendScale;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _sendScale(new int[] { GetTextWidth, GetTextHeight });
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close or Hide the Window
            this.Hide();
        }

        public void PutPictureNumbers(int X, int Y)
        {
            WidthTextbox.Text = X.ToString();
            HeightTextbox.Text = Y.ToString();
        }

        public int GetTextWidth { get { return System.Convert.ToInt16(WidthTextbox.Value); } }

        public int GetTextHeight { get { return System.Convert.ToInt16(HeightTextbox.Value); } }
    }
}
