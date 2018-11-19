using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Voyage
{
    public partial class usWorkers : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;
        public usWorkers()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor = Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(tbSearch.Visible)
            {
                tbSearch.Visible = false;
                label11.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
                label11.Visible = true;
            }
        }
    }
}
