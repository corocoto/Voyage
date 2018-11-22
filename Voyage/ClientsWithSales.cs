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
    public partial class ClientsWithSales : Form
    {
        public ClientsWithSales()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }
    }
}
