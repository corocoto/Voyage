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
    public partial class usSales : UserControl
    {
        public usSales()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
        }

        private void addNewClientsWithSales_Click(object sender, EventArgs e)
        {
            using (ClientsWithSales cws = new ClientsWithSales())
            {
                cws.ShowDialog();
            }
        }
    }
}
