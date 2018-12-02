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
using Excel = Microsoft.Office.Interop.Excel;

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

        /*для редактирования необходимой записи*/
        private void EditApplic(string command)
        {
            if ((bs.Count > 0) && (dgvGroups.SelectedRows.Count > 0))
            {
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
                if (command == "editGroup")
                {
                    changeGroup cg = new changeGroup(ID_SS);
                    cg.ShowDialog();
                }
                else
                {
                    string thisCountry=Convert.ToString(((DataRowView)this.bs.Current).Row["sCountry"]);
                    int PlacesCount = Convert.ToInt32(((DataRowView)this.bs.Current).Row["sCount"]);
                    workWithClients wwc = new workWithClients(ID_SS, PlacesCount, thisCountry);
                    wwc.ShowDialog();
                }
                LoadDataFromTables();
                bs.Position = bs.Find("ID_Group", ID_SS);
            }
        }
        /*загрузка данных в DataGridView*/
        void LoadDataFromTables()
        {
            adapter = new SqlDataAdapter("select tGroups.ID_Group, tGroups.sName, tRoutes.sNameOfRoute, tRoutes.sCountry, tWorkers.sName, tWorkers.sSurname, tRoutes.DayStart, tGroups.sCount " +
            " FROM tGroups INNER JOIN tGroupsRoutes ON tGroups.ID_Group = tGroupsRoutes.ID_Group" +
            " inner join tRoutes ON tGroupsRoutes.ID_Route = tRoutes.ID_Route" +
            " inner join tWorkers on tRoutes.ID_Worker = tWorkers.ID_Worker", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;

            dgvGroups.DataSource = bs;
            dgvGroups.Columns[0].Visible = false;
            dgvGroups.Columns[1].HeaderText = "Название группы";
            dgvGroups.Columns[2].HeaderText = "Название маршрута";
            dgvGroups.Columns[3].HeaderText = "Страна пребывания";
            dgvGroups.Columns[4].HeaderText = "Имя представителя";
            dgvGroups.Columns[5].HeaderText = "Фамилия представителя";
            dgvGroups.Columns[6].HeaderText = "Дата вылета";
            dgvGroups.Columns[7].HeaderText = "Общ. кол-во мест";
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGroups.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private void createNewGroupBtn_Click(object sender, EventArgs e)
        {
            createNewGroup cng = new createNewGroup();
            cng.ShowDialog();
            LoadDataFromTables();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditApplic("editGroup");
        }

        private void workWithClientsBtn_Click(object sender, EventArgs e)
        {
            EditApplic("workWithClients");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Group"]);
                try
                {
                    DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить данную запись",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.No)
                    {
                        LoadDataFromTables();
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        /*удаление связанных записей*/
                        connection.Open();
                        SqlCommand forGroupsPuncts = new SqlCommand("UPDATE tGroupsRoutes SET " +
                            "ID_Group=NULL, ID_Route=NULL WHERE ID_Group='"+delId+"'", connection);
                        forGroupsPuncts.ExecuteNonQuery();
                        forGroupsPuncts = new SqlCommand("Delete From tGroupsRoutes where ID_Group is NULL", connection);
                        forGroupsPuncts.ExecuteNonQuery();
                        connection.Close();

                        connection.Open();
                        SqlCommand forGroupsClients = new SqlCommand("UPDATE tGroupsClients SET " +
                            "ID_Group=NULL, ID_Client=NULL WHERE ID_Group='" + delId + "'", connection);
                        forGroupsClients.ExecuteNonQuery();
                        forGroupsClients = new SqlCommand("Delete From tGroupsClients where ID_Group is NULL", connection);
                        forGroupsClients.ExecuteNonQuery();
                        connection.Close();

                        connection.Open();
                        SqlCommand del = new SqlCommand("Delete From tGroups where ID_Group=@ID", connection);
                        del.Parameters.AddWithValue("@ID", delId);
                        del.ExecuteNonQuery();
                        connection.Close();
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
                    LoadDataFromTables();
                }
            }
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список групп";
            workSheet.Cells[1, 1] = "Название группы";
            workSheet.Cells[1, 2] = "Название маршрута";
            workSheet.Cells[1, 3] = "Страна пребывания";
            workSheet.Cells[1, 4] = "Представитель";
            workSheet.Cells[1, 5] = "Дата вылета";
            workSheet.Cells[1, 6] = "Общ. кол-во мест";
            //workSheet.Cells[1, 7] = "Кол-во свободных мест";
            Excel.Range title = workSheet.Range["A1:F1"];
            title.Cells.Font.Name = "Tahoma";
            title.Font.Size = "16";
            title.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
            title.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xCC));
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.EntireColumn.AutoFit();
            title.EntireRow.AutoFit();
            title.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for (int i = 0; i < dgvGroups.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvGroups.RowCount; j++)
                {
                    if (i >= 4)
                    {
                        if (i==4)
                            workSheet.Cells[j + 2, i] = workSheet.Cells[j + 2, i].Value+" " + dgvGroups.Rows[j].Cells[i + 1].Value.ToString();
                        else
                            workSheet.Cells[j + 2, i].Value = dgvGroups.Rows[j].Cells[i + 1].Value.ToString();
                            workSheet.Cells[j + 2, i].Font.Name = "Tahoma";
                            workSheet.Cells[j + 2, i].Font.Size = "14";
                            workSheet.Cells[j + 2, i].EntireColumn.AutoFit();
                            workSheet.Cells[j + 2, i].EntireRow.AutoFit();
                            workSheet.Cells[j + 2, i].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            workSheet.Cells[j + 2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    }
                    else
                    {
                        workSheet.Cells[j + 2, i + 1] = dgvGroups.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i + 1].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i + 1].Font.Size = "14";
                        workSheet.Cells[j + 2, i + 1].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i + 1].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                }

            }
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
