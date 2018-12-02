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
    public partial class workWithClients : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt, dtForAddClients;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs, bsForAddClients;
        int ID_group = 0;
        int PlacesCount = 0;

        public workWithClients()
        {
            InitializeComponent();

            LoadDataFromGroupsClients();
            workWithFreePlaces();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        public workWithClients(int ID, int pCount, string country)
        {
            InitializeComponent();
            ID_group = ID;
            PlacesCount = pCount;
            loadAllClients(country);
            LoadDataFromGroupsClients();
            workWithFreePlaces();
            this.ForeColor = Color.FromArgb(0, 71, 160);
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        /*отображение всего имеющегося списка клиентов*/
        void loadAllClients(string country)
        {
            SqlDataAdapter allClientsAdapter;
            if (country == "Россия")
            {
                allClientsAdapter = new SqlDataAdapter("Select ID_Client, sName, sSurname from tClients Order By sSurname", connection);
            }
            else
            {
                allClientsAdapter = new SqlDataAdapter("Select ID_Client, sName, sSurname from tClients where AbroadDoc=1 Order By sSurname ", connection);
            }
            dt = new DataTable();
            allClientsAdapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbAllClients.DataSource = dt;
            cbAllClients.ValueMember = "ID_Client";
            cbAllClients.DisplayMember = "sSurname";
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addPunct_Click(object sender, EventArgs e)
        {
            bool add = false;
            try
            {
                int id = Convert.ToInt32(cbAllClients.SelectedValue);
                connection.Close();
                connection.Open();
                for (int i = 0; i < cbClientsInThisGroup.Items.Count; i++)
                {
                    cbClientsInThisGroup.SelectedIndex = i;
                    if (id == Convert.ToInt32(cbClientsInThisGroup.SelectedValue)) add = true;
                }
                if (add == false)
                {
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tGroupsClients]" +
                        " VALUES (@ID_Group, @ID_Client)", connection);
                    commandInsert.Parameters.AddWithValue("@ID_Group", ID_group);
                    commandInsert.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(cbAllClients.SelectedValue));
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно добавлен");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
                LoadDataFromGroupsClients();
                workWithFreePlaces();
            }
        }

        private void delPunct_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show(
                    "Вы действительно хотите убрать клиента из данного маршрута",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.No)
                    {
                        LoadDataFromGroupsClients();
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From tGroupsClients where ID_Group = @ID_Group AND ID_Client=@ID_Client", connection);
                        Delete.Parameters.AddWithValue("@ID_Group", ID_group);
                        Delete.Parameters.AddWithValue("@ID_Client", Convert.ToInt32(cbClientsInThisGroup.SelectedValue));
                        Delete.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    if ((uint)ex.ErrorCode == 0x80004005)
                        MessageBox.Show(
                        "В таблицах есть связанные записи",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    else
                        MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromGroupsClients();
                    workWithFreePlaces();
                }
            }
        }

        //загрузка добавленных пунктов
        void LoadDataFromGroupsClients()
        {
            adapter = new SqlDataAdapter("SELECT tGroupsClients.ID_GroupsClients, tGroupsClients.ID_Client, tClients.sName, tClients.sSurname FROM tGroupsClients INNER JOIN tGroups ON tGroups.ID_Group = tGroupsClients.ID_Group" +
       " inner join tClients ON tGroupsClients.ID_Client = tClients.ID_Client WHERE tGroupsClients.ID_Group=" + ID_group, connection);
            dtForAddClients = new DataTable();
            adapter.Fill(dtForAddClients);
            bsForAddClients = new BindingSource();
            bsForAddClients.DataSource = dtForAddClients;
            cbClientsInThisGroup.DataSource = bsForAddClients;
            cbClientsInThisGroup.ValueMember = "ID_Client";
            cbClientsInThisGroup.DisplayMember = "sSurname";
        }

        void workWithFreePlaces()
        {
            lFreePlacesCount.Text = Convert.ToString(PlacesCount - cbClientsInThisGroup.Items.Count);
            if (lFreePlacesCount.Text == "0") addPunct.Enabled = false;
            else addPunct.Enabled = true;
        }

    }
}
