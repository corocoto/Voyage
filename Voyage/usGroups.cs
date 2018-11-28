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
    public partial class usGroups : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        SqlDataAdapter adapter;
        BindingSource bs;
        public usGroups()
        {
            InitializeComponent();
            LoadDataFromTables();
            headerPanel.BackColor = Color.FromArgb(0, 71, 160);
        }
        void LoadDataFromTables()
        {
            adapter = new SqlDataAdapter("select  tGroups.sName, tRoutes.sNameOfRoute, tWorkers.sName, tWorkers.sSurname, tRoutes.DayStart, tGroups.sCount " +
            " FROM tGroups INNER JOIN tGroupsRoutes ON tGroups.ID_Group = tGroupsRoutes.ID_Group"+
            " inner join tRoutes ON tGroupsRoutes.ID_Route = tRoutes.ID_Route"+
            " inner join tWorkers on tRoutes.ID_Worker = tWorkers.ID_Worker", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;

            dgvGroups.DataSource = bs;
            dgvGroups.Columns[0].HeaderText = "Название группы";
            dgvGroups.Columns[1].HeaderText = "Название маршрута";
            dgvGroups.Columns[2].HeaderText = "Имя представителя";
            dgvGroups.Columns[3].HeaderText = "Фамилия представителя";
            dgvGroups.Columns[4].HeaderText = "Дата вылета";
            dgvGroups.Columns[5].HeaderText = "Общ. кол-во мест";
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGroups.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
        }
        private void createNewGroupBtn_Click(object sender, EventArgs e)
        {
            createNewGroup cng = new createNewGroup();
            cng.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            changeGroup cg = new changeGroup();
            cg.ShowDialog();
        }

        private void workWithClientsBtn_Click(object sender, EventArgs e)
        {
            workWithClients wwc = new workWithClients();
            wwc.ShowDialog();
        }
    }
}
