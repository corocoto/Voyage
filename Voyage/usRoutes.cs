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
    public partial class usRoutes : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dtForRoutes, dtForWorkers, dtForPuncts, dtForAddPuncts;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bsForRoutes, bsForWorkers, bsForPuncts, bsForAddPuncts;
        bool forBtn;

        void loadWorkersWithoutAbroadDoc()
        {
            adapter = new SqlDataAdapter("SELECT ID_Worker, sName, sSurname from tWorkers Order by sName, sSurname", connection);
        }

        void loadWorkersWithAbroadDoc()
        {
            adapter = new SqlDataAdapter("SELECT ID_Worker, sName, sSurname from tWorkers WHERE AbroadDoc=1 Order by sName, sSurname", connection);
        }

        //загрузка представителей компании
        void LoadDataFromWorkers(string country)
        {        
            if (country == "Россия") loadWorkersWithoutAbroadDoc();
            else loadWorkersWithAbroadDoc();
            dtForWorkers = new DataTable();
            adapter.Fill(dtForWorkers);
            bsForWorkers = new BindingSource();
            bsForWorkers.DataSource = dtForWorkers;
            cbWorker.DataSource = bsForWorkers;
            cbWorker.ValueMember = "ID_Worker";
            cbWorker.DisplayMember = "sSurname";/*добавить sName*/
            if (bsForRoutes.Count>0)
            cbWorker.SelectedValue = Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Worker"]);/*отмечает выбранный эл-т*/
        }

        //загрузка всевозможных пунктов
        void LoadDataFromPuncts(string country)
        {
            adapter = new SqlDataAdapter("SELECT ID_Punct, sPunct from tPuncts WHERE sCountry="+"'"+country+"'",connection);
            dtForPuncts = new DataTable();
            adapter.Fill(dtForPuncts);
            bsForPuncts = new BindingSource();
            bsForPuncts.DataSource = dtForPuncts;
            cbAllPuncts.DataSource = bsForPuncts;
            cbAllPuncts.ValueMember = "ID_Punct";
            cbAllPuncts.DisplayMember = "sPunct";
        }

        //загрузка добавленных пунктов
        void LoadDataFromRoutesPuncts(int id)
        {
            adapter = new SqlDataAdapter("SELECT  tRoutesPuncts.ID_RoutesPuncts, tRoutesPuncts.ID_Punct, tPuncts.sPunct FROM dbo.tRoutesPuncts INNER JOIN tRoutes ON dbo.tRoutesPuncts.ID_Route = dbo.tRoutes.ID_Route" +
       " inner join tPuncts ON dbo.tRoutesPuncts.ID_Punct = dbo.tPuncts.ID_Punct WHERE tRoutesPuncts.ID_Route=" + id, connection);
            dtForAddPuncts = new DataTable();
            adapter.Fill(dtForAddPuncts);
            bsForAddPuncts = new BindingSource();
            bsForAddPuncts.DataSource = dtForAddPuncts;
            cbAddPuncts.DataSource = bsForAddPuncts;
            cbAddPuncts.ValueMember = "ID_Punct";
            cbAddPuncts.DisplayMember = "sPunct";
            if (cbAddPuncts.Items.Count > 0) cbCountries.Enabled = false;
            else cbCountries.Enabled = true;
        }

        void LoadDataFromTable()
        {
            adapter = new SqlDataAdapter("SELECT tRoutes.ID_Route, tRoutes.sNameOfRoute, tRoutes.sCountry, tRoutes.sDays, tWorkers.ID_Worker, tWorkers.sName, tWorkers.sSurname," +
                " tRoutes.Price, tRoutes.Sale, tRoutes.sReturn, tRoutes.DayStart FROM tWorkers INNER JOIN tRoutes ON tWorkers.ID_Worker = tRoutes.ID_Worker; ", connection);
            dtForRoutes = new DataTable();
            adapter.Fill(dtForRoutes);
            bsForRoutes = new BindingSource();
            bsForRoutes.DataSource = dtForRoutes;

            nameOfRoute.DataBindings.Clear();
            nameOfRoute.DataBindings.Add(new Binding("Text", bsForRoutes, "sNameOfRoute"));
            cbCountries.DataBindings.Clear();
            cbCountries.DataBindings.Add(new Binding("Text", bsForRoutes, "sCountry"));
            mtbDays.DataBindings.Clear();
            mtbDays.DataBindings.Add(new Binding("Text", bsForRoutes, "sDays"));
            mtbMoney.DataBindings.Clear();
            mtbMoney.DataBindings.Add(new Binding("Text", bsForRoutes, "Price"));
            mtbSale.DataBindings.Clear();
            mtbSale.DataBindings.Add(new Binding("Text", bsForRoutes, "Sale"));
            mtbReturn.DataBindings.Clear();
            mtbReturn.DataBindings.Add(new Binding("Text", bsForRoutes, "sReturn"));
            dateOfFly.DataBindings.Clear();
            dateOfFly.DataBindings.Add(new Binding("Text", bsForRoutes, "DayStart"));

            dgvRoutes.DataSource = bsForRoutes;
            dgvRoutes.Columns[0].Visible = false;
            dgvRoutes.Columns[1].HeaderText = "Название маршрута";
            dgvRoutes.Columns[2].HeaderText = "Страна пребывания";
            dgvRoutes.Columns[3].Visible = false;
            dgvRoutes.Columns[4].Visible = false;
            dgvRoutes.Columns[5].Visible = false;
            dgvRoutes.Columns[6].Visible = false;
            dgvRoutes.Columns[7].Visible = false;
            dgvRoutes.Columns[8].Visible = false;
            dgvRoutes.Columns[9].Visible = false;
            dgvRoutes.Columns[10].Visible = false;
            dgvRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoutes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRoutes.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (bsForRoutes.Count > 0)
            {
                LoadDataFromWorkers(Convert.ToString(((DataRowView)this.bsForRoutes.Current).Row["sCountry"]));
                LoadDataFromPuncts(Convert.ToString(((DataRowView)this.bsForRoutes.Current).Row["sCountry"]));
                LoadDataFromRoutesPuncts(Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]));
            }
            else
            {
                cbCountries.SelectedIndex = 0;
                LoadDataFromWorkers("Россия");
                LoadDataFromPuncts("Россия");
            }
            lCount.Text = bsForRoutes.Count.ToString();
            if (cbAddPuncts.Items.Count > 0) cbCountries.Enabled = false;
            else cbCountries.Enabled = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
            {
                label11.Visible = false;
                tbSearchRoutes.Visible = false;
            }
            else
            {
                label11.Visible = true;
                tbSearchRoutes.Visible = true;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn)
            {
                forBtn = false;
                LoadDataFromTable();
                cbAddPuncts.Visible = true;
                cbAllPuncts.Visible = true;
                label10.Visible = true;
                addPunct.Visible = true;
                delPunct.Visible = true;

            }
            else if (bsForRoutes.Count > 0)
            {
                int rowPosition = bsForRoutes.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]);
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
                        LoadDataFromTable();
                        cbAddPuncts.Visible = true;
                        cbAllPuncts.Visible = true;
                        label10.Visible = true;
                        addPunct.Visible = true;
                        delPunct.Visible = true;
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand del = new SqlCommand("Delete From tRoutesPuncts where ID_Route=@ID", connection);
                        del.Parameters.AddWithValue("@ID", delId);
                        del.ExecuteNonQuery();
                        connection.Close();
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From tRoutes where ID_Route = @ID", connection);
                        Delete.Parameters.AddWithValue("@ID", delId);
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
                    LoadDataFromTable();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Route) from tRoutes", connection);
                    int max = int.Parse(dgvRoutes.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tRoutes]" +
                        " VALUES(@Name, @Country, @Days, @Worker, @Price, @Sale, @Return, @DayStart)", connection);
                    commandInsert.Parameters.AddWithValue("@Name", nameOfRoute.Text);
                    commandInsert.Parameters.AddWithValue("@Country", cbCountries.Text);
                    commandInsert.Parameters.AddWithValue("@Days", mtbDays.Text);
                    commandInsert.Parameters.AddWithValue("@Worker", cbWorker.SelectedValue);
                    commandInsert.Parameters.AddWithValue("@Price", mtbMoney.Text);
                    commandInsert.Parameters.AddWithValue("@Sale", mtbSale.Text);
                    commandInsert.Parameters.AddWithValue("@Return", mtbReturn.Text);
                    commandInsert.Parameters.AddWithValue("@DayStart", dateOfFly.Text);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена");
                    forBtn = false;
                    cbAddPuncts.Visible = true;
                    cbAllPuncts.Visible = true;
                    label10.Visible = true;
                    addPunct.Visible = true;
                    delPunct.Visible = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromTable();
                }

            }
            else if (bsForRoutes.Count > 0)
            {
                int i = bsForRoutes.Position;
                int ID_SS = Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tRoutes SET " +
                        "sNameOfRoute=@Name, sCountry=@Country, sDays=@Days, ID_Worker=@Worker, Price=@Price, Sale=@Sale, sReturn=@Return," +
                        " DayStart=@DayStart WHERE ID_Route=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Name", nameOfRoute.Text);
                    commandUpdate.Parameters.AddWithValue("@Country", cbCountries.Text);
                    commandUpdate.Parameters.AddWithValue("@Days", mtbDays.Text);
                    commandUpdate.Parameters.AddWithValue("@Worker", cbWorker.SelectedValue);
                    commandUpdate.Parameters.AddWithValue("@Price", mtbMoney.Text);
                    commandUpdate.Parameters.AddWithValue("@Sale", mtbSale.Text);
                    commandUpdate.Parameters.AddWithValue("@Return", mtbReturn.Text);
                    commandUpdate.Parameters.AddWithValue("@DayStart", dateOfFly.Text);
                    commandUpdate.Parameters.AddWithValue("@IDSS", ID_SS);
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
                    LoadDataFromTable();
                    bsForRoutes.Position = i;
                }

            }
            saveBtn.Enabled = false;
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список маршрутов";
            workSheet.Cells[1, 1] = "Название маршрута";
            workSheet.Cells[1, 2] = "Страна пребывания";
            workSheet.Cells[1, 3] = "Срок пребывания";
            workSheet.Cells[1, 4] = "Представитель";
            workSheet.Cells[1, 5] = "Стоимость путевки (руб)";
            workSheet.Cells[1, 6] = "Скидка (%)";
            workSheet.Cells[1, 7] = "Неустойка (%)";
            workSheet.Cells[1, 8] = "Дата вылета";
            Excel.Range title = workSheet.Range["A1:H1"];
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
            for (int i = 0; i < dgvRoutes.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvRoutes.RowCount; j++)
                {
                    if (i ==4)
                    {
                        workSheet.Cells[j + 2, i] = dgvRoutes.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i].Font.Size = "14";
                        workSheet.Cells[j + 2, i].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }else if (i >= 5)
                    {
                        if (i == 5)  workSheet.Cells[j + 2, i - 1].Value += " " + dgvRoutes.Rows[j].Cells[i + 1].Value.ToString(); 
                        else workSheet.Cells[j + 2, i - 1].Value = dgvRoutes.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i - 1].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i - 1].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i - 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i - 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        workSheet.Cells[j + 2, i - 1].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i - 1].Font.Size = "14";
                    }
                    else
                    {
                        workSheet.Cells[j + 2, i + 1] = dgvRoutes.Rows[j].Cells[i + 1].Value.ToString();
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

        private void tbSearchRoutes_TextChanged(object sender, EventArgs e)
        {
            bsForRoutes.Filter = "sNameOfRoute LIKE '%" + tbSearchRoutes.Text + "%' OR sCountry LIKE '%" + tbSearchRoutes.Text + "%'";
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFromWorkers(cbCountries.SelectedItem.ToString());
            LoadDataFromPuncts(cbCountries.SelectedItem.ToString());
            EnabledBtnForMask(mtbDays);
        }

        private void dgvRoutes_SelectionChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            LoadDataFromRoutesPuncts(Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]));
            if (bsForRoutes.Count > 0)
            {
                cbWorker.SelectedValue = Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Worker"]);
            }
        }

        private void ClearText()
        {
            nameOfRoute.Text = "";
            cbCountries.SelectedIndex = 0;
            mtbDays.Text = "";
            cbWorker.SelectedIndex = 0;
            mtbMoney.Text = "";
            mtbSale.Text = "";
            mtbReturn.Text = "";
            dateOfFly.Text = DateTime.Now.ToString();
            cbCountries.Enabled = true;
            label10.Visible = false;
            cbAddPuncts.Visible = false;
            cbAllPuncts.Visible = false;
            addPunct.Visible = false;
            delPunct.Visible = false;
        }

        private void nameOfRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnabledBtn(nameOfRoute);
        }

        //добавление пунктов маршрута
        private void addPunct_Click(object sender, EventArgs e)
        {
            bool add = false;
            try
            {
                int id = Convert.ToInt32(cbAllPuncts.SelectedValue);
                connection.Close();
                connection.Open();
                for (int i=0; i < cbAddPuncts.Items.Count; i++)
                {
                  cbAddPuncts.SelectedIndex = i;
                  if (id == Convert.ToInt32(cbAddPuncts.SelectedValue)) add = true;
                }
                if (add == false)
                {
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tRoutesPuncts]" +
                        " VALUES (@ID_Route, @ID_Punct)", connection);
                    commandInsert.Parameters.AddWithValue("@ID_Route", Convert.ToString(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]));
                    commandInsert.Parameters.AddWithValue("@ID_Punct", Convert.ToInt32(cbAllPuncts.SelectedValue));
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Маршрут добавлен");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
                LoadDataFromTable();
                saveBtn.Enabled = false;
            }
        }

        //удаление добавленных пунктов маршрута
        private void delPunct_Click(object sender, EventArgs e)
        {
            if (bsForAddPuncts.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить данный маршрут",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.No)
                    {
                        LoadDataFromTable();
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From tRoutesPuncts where ID_Punct = @ID_Punct AND ID_Route=@ID_Route", connection);
                        Delete.Parameters.AddWithValue("@ID_Punct", Convert.ToInt32(cbAddPuncts.SelectedValue));
                        Delete.Parameters.AddWithValue("@ID_Route", Convert.ToInt32(((DataRowView)this.bsForRoutes.Current).Row["ID_Route"]));
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
                    LoadDataFromTable();
                }
            }
            saveBtn.Enabled = false;
        }

        void EnabledBtn(TextBox tb)
        {
            if (nameOfRoute.Text != "")
            {
                saveBtn.Enabled = true;
            }
        }

        private void mtbDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnabledBtnForMask(mtbDays);
        }

        private void cbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledBtnForMask(mtbDays);
        }

        private void dateOfFly_ValueChanged(object sender, EventArgs e)
        {
            EnabledBtnForMask(mtbDays);
        }

        void EnabledBtnForMask(MaskedTextBox tb)
        {
            if (nameOfRoute.Text != "")
            {
                saveBtn.Enabled = true;
            }
        }

        public usRoutes()
        {
            InitializeComponent();
            LoadDataFromTable();
            forBtn = false;
            saveBtn.Enabled = false;
            this.ForeColor=Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor = Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }
    }
}