using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ScaleRequestForm : Form
    {
        public ScaleRequestForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Check if Width is not null and more than zero
                //Send Height and Width to Controller
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close or Hide the Window
        }
    }
}
