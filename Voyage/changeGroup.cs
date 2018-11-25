using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class changeGroup : Form
    {
        public changeGroup()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
