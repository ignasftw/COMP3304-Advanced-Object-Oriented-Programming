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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            frameProgressBar.Step = 1;
        }

        public void SetBar(int min, int max)
        {
            frameProgressBar.Minimum = min;
            frameProgressBar.Maximum = max;
        }
        public void Step()
        {
            frameProgressBar.PerformStep();
        }

        public void UpdateText(string text)
        {
            label1.Text = text;
            label1.Refresh();
        }
    }
}
