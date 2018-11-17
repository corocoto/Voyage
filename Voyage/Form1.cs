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
    public partial class fAuthorization : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
        SqlConnection connection;
        public fAuthorization()
        {
            InitializeComponent();
            topPanel.BackColor = Color.FromArgb(0, 71, 160);
            headerLabel.ForeColor = Color.White;
            lLogAndPassword.ForeColor = Color.FromArgb(0, 71, 160);
            signInBtn.BackColor = Color.FromArgb(0, 71, 160);
            lLog.ForeColor= Color.FromArgb(0, 71, 160);
            lPassword.ForeColor = Color.FromArgb(0, 71, 160);
            seePassword.ForeColor= Color.FromArgb(0, 71, 160);
            lCopyright.ForeColor = Color.FromArgb(0, 71, 160);
            shutdownBtn.BackColor= Color.FromArgb(0, 71, 160);
            
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked) tbPassword.UseSystemPasswordChar = false;
            else tbPassword.UseSystemPasswordChar = true;
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string role = "";
            string username = "";
            try
            {
                using(connection = new SqlConnection(connectionString))
                {
                    string command = String.Format("Select sLog, sRole From tUser Where " +
                        "(sLog='{0}' Collate SQL_Latin1_General_CP1251_CS_AS) and " +
                        "(sPassword='{1}' Collate SQL_Latin1_General_CP1251_CS_AS)",
                        tbLog.Text, tbPassword.Text);
                    SqlCommand Select = new SqlCommand(command, connection);
                    connection.Open();
                    reader = Select.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            username = reader[0].ToString().Trim();
                            role = reader[1].ToString();
                        }
                        tbLog.Text = "";
                        tbPassword.Text = "";
                        MainMenu mm = new MainMenu(role, username);
                        mm.Owner = this;
                        mm.Show();
                       // this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверные логин или пароль",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
