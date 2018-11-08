using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class MainMenu : Form
    {
        int panelWidth;
        /*свернуть/развернуть меню*/
        bool isCollapsed;
        public MainMenu()
        {
            InitializeComponent();
            pItemsOfMenu.BackColor=Color.FromArgb(0, 71, 160);
            pSection.BackColor = Color.FromArgb(0, 71, 160);
            lHeaderNameOfComapny.ForeColor= Color.FromArgb(0, 71, 160);
            isCollapsed = false;
            panelWidth = pItemsOfMenu.Width;

            usMain mainPage = new usMain();
            loadNecessaryPage(mainPage);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pItemsOfMenu.Width += 35;
                if (pItemsOfMenu.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pItemsOfMenu.Width -= 35;
                if (pItemsOfMenu.Width <= 76)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /*метод для перемещения левого ползунка меню*/
        private void moveSidePanel (Control btn)
        {
            pYourChoice.Top = btn.Top;
            pYourChoice.Height = btn.Height;

        }
        /*метод загрузки необходимой страницы в полном размере*/
        private void loadNecessaryPage(Control page)
        {
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(homeBtn);
            usMain mainPage=new usMain();
            loadNecessaryPage(mainPage);
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(clientsBtn);
            usClients clients = new usClients();
            loadNecessaryPage(clients);
        }

        private void routesBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(routesBtn);
            usRoutes routes = new usRoutes();
            loadNecessaryPage(routes);
        }

        private void groupsBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(groupsBtn);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(salesBtn);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(returnBtn);
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            moveSidePanel(workersBtn);
        }
    }
}
