using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class usGroups : UserControl
    {
        public usGroups()
        {
            InitializeComponent();
            headerPanel.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void createNewGroupBtn_Click(object sender, EventArgs e)
        {
            createNewGroup cng = new createNewGroup();
            cng.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            changeGroup cg = new changeGroup();
            cg.Show();
        }
    }
}
