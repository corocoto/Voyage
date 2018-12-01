using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class changeGroup : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt, dtRoutes;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs, bsRoutes;
        int ID_group = 0;

        public changeGroup()
        {
            InitializeComponent();
            loadComboRoutes();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        public changeGroup(int ID)
        {
            InitializeComponent();
            ID_group = ID;
            loadComboRoutes();
            loadData(ID_group);
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                SqlCommand commandUpdate = new SqlCommand("UPDATE tGroups SET sName=@Name, sCount=@Count WHERE ID_Group=@IDSS", connection);
                commandUpdate.Parameters.AddWithValue("@Name", tbName.Text);
                commandUpdate.Parameters.AddWithValue("@Count", Convert.ToInt32(tbCount.Text));
                commandUpdate.Parameters.AddWithValue("@IDSS", ID_group);
                commandUpdate.ExecuteNonQuery();
                commandUpdate = new SqlCommand("UPDATE tGroupsRoutes SET ID_Route=@ID_Route WHERE ID_Group=@IDSS", connection);
                commandUpdate.Parameters.AddWithValue("@ID_Route", cbRoutes.SelectedValue);
                commandUpdate.Parameters.AddWithValue("@IDSS", ID_group);
                commandUpdate.ExecuteNonQuery();
                MessageBox.Show("Запись обновлена");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                this.Dispose();
            }
        }

        void loadComboRoutes()
        {
            SqlDataAdapter dataAdapterRoutes = new SqlDataAdapter("Select ID_Route, sNameOfRoute from tRoutes Order By sNameOfRoute", connection);
            dtRoutes = new DataTable();
            dataAdapterRoutes.Fill(dtRoutes);
            bsRoutes = new BindingSource();
            bsRoutes.DataSource = dtRoutes;
            cbRoutes.DataSource = dtRoutes;
            cbRoutes.ValueMember = "ID_Route";
            cbRoutes.DisplayMember = "sNameOfRoute";
        }

        void loadData(int ID)
        {
            SqlCommand SelectCommand = new SqlCommand("SELECT tGroups.ID_Group, tGroups.sName, tGroups.sCount, tRoutes.ID_Route " +
            "FROM tGroups INNER JOIN tGroupsRoutes ON tGroups.ID_Group = tGroupsRoutes.ID_Group INNER JOIN tRoutes on tGroupsRoutes.ID_Route = tRoutes.ID_Route WHERE(tGroups.ID_Group =" + ID + "); ", connection);
            connection.Open();
            SqlDataReader reader = SelectCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ID_group = Convert.ToInt32(reader.GetValue(0));
                    tbName.Text = Convert.ToString(reader.GetValue(1));
                    tbCount.Text = Convert.ToString(reader.GetValue(2));
                    cbRoutes.SelectedValue = Convert.ToInt32(reader.GetValue(3));
                }
            }
            connection.Close();
        }
    }
}
