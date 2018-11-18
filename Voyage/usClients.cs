﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Voyage
{
    public partial class usClients : UserControl
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt;
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;

        void LoadDataFromTable()
        {
            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tClients Order By sName", connection);
                ds = new DataSet();
                //заполняем ds
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];

                tbName.DataBindings.Clear();
                tbName.DataBindings.Add(new Binding("Text", bs, "sName"));
                tbSurname.DataBindings.Clear();
                tbSurname.DataBindings.Add(new Binding("Text", bs, "sSurname"));
                tbPatronymic.DataBindings.Clear();
                tbPatronymic.DataBindings.Add(new Binding("Text", bs, "sPatronymic"));

                //photoOfClient.DataBindings.Clear();
                //photoOfClient.DataBindings.Add(new Binding("Text", bs, "sPatronymic"));
                photoOfClient.Image = imageList1.Images[0];
                if (bs.Count > 0) LoadPhoto();


                dtpBithday.DataBindings.Clear();
                dtpBithday.DataBindings.Add(new Binding("Text", bs, "Bithday"));
                cbDoc.DataBindings.Clear();
                cbDoc.DataBindings.Add(new Binding("Text", bs, "sDoc"));
                tbSeries.DataBindings.Clear();
                tbSeries.DataBindings.Add(new Binding("Text", bs, "Series"));
                tbNumber.DataBindings.Clear();

                tbNumber.DataBindings.Add(new Binding("Text", bs, "Number"));
                lbDocIssue.DataBindings.Clear();
                lbDocIssue.DataBindings.Add(new Binding("Text", bs, "sDocIssue"));
                dtpDateIssue.DataBindings.Clear();
                dtpDateIssue.DataBindings.Add(new Binding("Text", bs, "DateIssue"));
                AbroadDoc.DataBindings.Clear();
                AbroadDoc.DataBindings.Add(new Binding("Checked", bs, "AbroadDoc"));

                // Отображаем данные
                dgvClients.DataSource = bs;
                dgvClients.Columns[0].Visible = false;
                dgvClients.Columns[1].HeaderText = "Имя";
                dgvClients.Columns[2].HeaderText = "Фамилия";
                dgvClients.Columns[3].Visible = false;
                dgvClients.Columns[4].Visible = false;
                dgvClients.Columns[5].Visible = false;
                dgvClients.Columns[6].Visible = false;
                dgvClients.Columns[7].Visible = false;
                dgvClients.Columns[8].Visible = false;
                dgvClients.Columns[9].Visible = false;
                dgvClients.Columns[10].Visible = false;
                dgvClients.Columns[11].Visible = false;
                dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvClients.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

                //подсчет клиентов
                lCount.Text = bs.Count.ToString();
            }
        }

        void LoadPhoto()
        {
            string fileName = "";
            photoOfClient.Image = imageList1.Images[0];
            string s = ((DataRowView)this.bs.Current).Row["Photo"].ToString();
            if (s != null)
                if (s != "")
                {
                    photoOfClient.Load(@"img\clients\" + s);
                    fileName = s;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        fileName = fileName.Replace(c, '_');
                    }
                }
            label12.Text = fileName;
        }

        private void ClearText()
        {
            photoOfClient.Image = imageList1.Images[0];
            label12.Text = "";
            tbName.Text = "";
            tbSurname.Text = "";
            tbPatronymic.Text = "";
            tbSeries.Text = "";
            tbNumber.Text = "";
            lbDocIssue.Text = "";
            AbroadDoc.Checked = false;
        }

        public usClients()
        {
            InitializeComponent();
            LoadDataFromTable();
            forBtn = false;
            this.ForeColor=Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor= Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor=Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
            {
                label11.Visible = false;
                tbSearchClient.Visible = false;
            }
            else
            {
                label11.Visible = true;
                tbSearchClient.Visible = true;
            }
        }

        private void usClients_Load(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                //отмена
                forBtn = false;
                saveBtn.Enabled = true;
                LoadDataFromTable();

            }
            else if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
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
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tClients where ID_Client = @ID", connection);
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

        private void photoOfClient_DoubleClick(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = "c:\\";
            Dialog.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = Dialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            photoOfClient.Image = Image.FromFile(Dialog.FileName);
                            label12.Text = Dialog.SafeFileName.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка:" + ex.Message);
                }
            }
        }

        private void tbSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только чисел
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только русских и ангийских символов
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < 'A' || word > 'Z') && word != '\b'  && (word < 'a' || word > 'z') && (word < 'а' || word > 'я'))
            {
                e.Handled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
        }
    }
}
