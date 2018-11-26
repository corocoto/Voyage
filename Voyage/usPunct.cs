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
    public partial class usPunct : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;

        //переменные для корректной работы рейтинга
        bool clickImg;
        string click="";
       // int rating = 0;

        void LoadDataFromTable()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tPuncts Order By sPunct, sHotel", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                cbCountry.DataBindings.Clear();
                cbCountry.DataBindings.Add(new Binding("Text", bs, "sCountry"));
                tbPunct.DataBindings.Clear();
                tbPunct.DataBindings.Add(new Binding("Text", bs, "sPunct"));
                tbHotel.DataBindings.Clear();
                tbHotel.DataBindings.Add(new Binding("Text", bs, "sHotel"));
                dateStart.DataBindings.Clear();
                dateStart.DataBindings.Add(new Binding("Text", bs, "dateStart"));
                dateEnd.DataBindings.Clear();
                dateEnd.DataBindings.Add(new Binding("Text", bs, "dateEnd"));
                if (bs.Count > 0) LoadRating();
                tbExcurse.DataBindings.Clear();
                tbExcurse.DataBindings.Add(new Binding("Text", bs, "sExcurse"));

                dgvPuncts.DataSource = bs;
                dgvPuncts.Columns[0].Visible = false;
                dgvPuncts.Columns[1].HeaderText = "Страна";
                dgvPuncts.Columns[2].HeaderText = "Пункт маршрута";
                dgvPuncts.Columns[3].HeaderText = "Название отеля";
                dgvPuncts.Columns[4].Visible = false;
                dgvPuncts.Columns[5].Visible = false;
                dgvPuncts.Columns[6].Visible = false;
                dgvPuncts.Columns[7].Visible = false;
                
                dgvPuncts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPuncts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvPuncts.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        void LoadRating()
        {
            string s = ((DataRowView)this.bs.Current).Row["class"].ToString();
            if (s != null)
                if (s != "" && s!=0.ToString())
                {
                    clickImg = true;
                    lRaiting.Text = s;
                    switch (lRaiting.Text)
                    {
                        case "1":
                            click = "oneStar";
                            printStarsBack(oneStar, clickImg, click);
                            break;
                        case "2":
                            click = "twoStars";
                            printStarsBack(twoStars, clickImg, click);
                            break;
                        case "3":
                            click = "threeStars";
                            printStarsBack(threeStars, clickImg, click);
                            break;
                        case "4":
                            click = "fourStars";
                            printStarsBack(fourStars, clickImg, click);
                            break;
                        case "5":
                            click = "fiveStars";
                            printStarsBack(fiveStars, clickImg, click);
                            break;
                    }
                }
                else
                {
                    clickImg = false;
                    click = "";
                    lRaiting.Text = "0";
                    printStarsBack(fiveStars, clickImg, click);
                }
        }
        void printStars(PictureBox nameOfPicture)
        {
            switch (nameOfPicture.Name.ToString())
            {
                case "oneStar":
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "twoStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "threeStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "fourStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    threeStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "fiveStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    threeStars.Load(@"img\btn\star_orange.png");
                    fourStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
            }
        }

        void printStarsBack(PictureBox nameOfPicture, bool star,string click)
        {
            if (star)
            {
               if (click!= "")
               {
                    switch (click)
                    {
                        case "oneStar":
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_blue.png");
                            threeStars.Load(@"img\btn\star_blue.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            //rating = 1;
                            lRaiting.Text = "1";
                            break;
                        case "twoStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_blue.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            //rating = 2;
                            lRaiting.Text = "2";
                            break;
                        case "threeStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            //rating = 3;
                            lRaiting.Text = "3";
                            break;
                        case "fourStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                          //  rating = 4;
                            lRaiting.Text = "4";
                            break;
                        case "fiveStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_orange.png");
                            fourStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            //rating = 5;
                            lRaiting.Text = "5";
                            break;
                    }
               }
            }
            else
            {
                oneStar.Load(@"img\btn\star_blue.png");
                twoStars.Load(@"img\btn\star_blue.png");
                threeStars.Load(@"img\btn\star_blue.png");
                fourStars.Load(@"img\btn\star_blue.png");
                fiveStars.Load(@"img\btn\star_blue.png");
            }
        }

        private void ClearText()
        {
            cbCountry.SelectedIndex = 0;
            clickImg = false;
           // rating = 0;
            lRaiting.Text = "0";
            click = "";
            tbPunct.Text = "";
            tbHotel.Text = "";
            tbExcurse.Text = "";
            dateStart.Text = DateTime.Now.ToString();
            dateEnd.Text = DateTime.Now.ToString();
            printStarsBack(fiveStars, clickImg, "fiveStars");
        }

        void EnabledBtn(TextBox tb)
        {
            if (tbPunct.Text != "" && tbHotel.Text!="")
            {
                saveBtn.Enabled = true;
            }
        }

        public usPunct()
        {
            InitializeComponent();
            LoadDataFromTable();
            forBtn = false;
            saveBtn.Enabled = false;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor = Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void oneStar_MouseEnter(object sender, EventArgs e)
        {
            printStars((sender as PictureBox));
        }

        private void oneStar_MouseLeave(object sender, EventArgs e)
        {
           
            printStarsBack((sender as PictureBox), clickImg,click);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
            {
                label11.Visible = false;
                tbSearchPuncts.Visible = false;
            }
            else
            {
                label11.Visible = true;
                tbSearchPuncts.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Punct) from tPuncts", connection);
                    int max = int.Parse(dgvPuncts.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tPuncts]" +
                        " VALUES(@Country, @Punct, @Hotel, @dateStart, @dateEnd, @class, @Excurse)", connection);
                    commandInsert.Parameters.AddWithValue("@Country", cbCountry.Text);
                    commandInsert.Parameters.AddWithValue("@Punct", tbPunct.Text);
                    commandInsert.Parameters.AddWithValue("@Hotel", tbHotel.Text);
                    commandInsert.Parameters.AddWithValue("@dateStart", dateStart.Text);
                    commandInsert.Parameters.AddWithValue("@dateEnd", dateEnd.Text);
                    commandInsert.Parameters.AddWithValue("@class", lRaiting.Text);
                    commandInsert.Parameters.AddWithValue("@Excurse", tbExcurse.Text);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена");
                    forBtn = false;
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
            else if (bs.Count > 0)
            {
                int i = bs.Position;
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Punct"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tPuncts SET " +
                        "sCountry=@Country, sPunct=@Punct, sHotel=@Hotel, dateStart=@dateStart, dateEnd=@dateEnd, class=@class, sExcurse=@Excurse WHERE ID_Punct=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Country", cbCountry.Text);
                    commandUpdate.Parameters.AddWithValue("@Punct", tbPunct.Text);
                    commandUpdate.Parameters.AddWithValue("@Hotel", tbHotel.Text);
                    commandUpdate.Parameters.AddWithValue("@dateStart", dateStart.Text);
                    commandUpdate.Parameters.AddWithValue("@dateEnd", dateEnd.Text);
                    commandUpdate.Parameters.AddWithValue("@class", lRaiting.Text);
                    commandUpdate.Parameters.AddWithValue("@Excurse", tbExcurse.Text);
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
                    bs.Position = i;
                }

            }
            saveBtn.Enabled = false;
        }

        private void oneStar_Click(object sender, EventArgs e)
        {
            clickImg = true;
            click = (sender as PictureBox).Name.ToString();
            printStarsBack((sender as PictureBox), clickImg, click);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn)
            {
                forBtn = false;
                LoadDataFromTable();
            }
            else if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Punct"]);
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
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tPuncts where ID_Punct = @ID", connection);
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

        private void tbPunct_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnabledBtn(tbPunct);
        }

        private void tbHotel_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnabledBtn(tbHotel);
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledBtn(tbExcurse);
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            EnabledBtn(tbExcurse);
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            EnabledBtn(tbExcurse);
        }

        private void tbExcurse_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn(tbExcurse);
        }

        private void lRaiting_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn(tbExcurse);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
        }

        private void dgvPuncts_SelectionChanged(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                LoadRating();
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
            workSheet.Name = "Пункты маршрутов";
            workSheet.Cells[1, 1] = "Страна";
            workSheet.Cells[1, 2] = "Пункт маршрута";
            workSheet.Cells[1, 3] = "Название отеля";
            workSheet.Cells[1, 4] = "Дата прибытия";
            workSheet.Cells[1, 5] = "Дата убытия";
            workSheet.Cells[1, 6] = "Класс гостиницы";
            workSheet.Cells[1, 7] = "Экскурсионная программа";
            Excel.Range title = workSheet.Range["A1:G1"];
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
            for (int i = 0; i < dgvPuncts.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvPuncts.RowCount; j++)
                {
                    workSheet.Cells[j + 2, i + 1] = dgvPuncts.Rows[j].Cells[i + 1].Value.ToString();
                    workSheet.Cells[j + 2, i + 1].Font.Name = "Tahoma";
                    workSheet.Cells[j + 2, i + 1].Font.Size = "14";
                    workSheet.Cells[j + 2, i + 1].EntireColumn.AutoFit();
                    workSheet.Cells[j + 2, i + 1].EntireRow.AutoFit();
                    workSheet.Cells[j + 2, i + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    workSheet.Cells[j + 2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
            }
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void tbSearchPuncts_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "sPunct LIKE '%" + tbSearchPuncts.Text + "%' OR sHotel LIKE '%" + tbSearchPuncts.Text + "%'";
        }
    }
}
