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
    public partial class fAuthorization : Form
    {
        public fAuthorization()
        {
            InitializeComponent();
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            headerLabel.ForeColor = Color.White;
            lLogAndPassword.ForeColor = Color.FromArgb(0, 71, 160);
            signInBtn.BackColor = Color.FromArgb(0, 71, 160);
            lLog.ForeColor= Color.FromArgb(0, 71, 160);
            lPassword.ForeColor = Color.FromArgb(0, 71, 160);
            seePassword.ForeColor= Color.FromArgb(0, 71, 160);
            lCopyright.ForeColor = Color.FromArgb(0, 71, 160);
            shutdownBtn.BackColor= Color.FromArgb(0, 71, 160);
            
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked) tbPassword.UseSystemPasswordChar = false;
            else tbPassword.UseSystemPasswordChar = true;
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            using(MainMenu mm= new MainMenu())
            {
                mm.ShowDialog();
            }
        }
    }
}
