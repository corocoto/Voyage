using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class usRoutes : UserControl
    {
        public usRoutes()
        {
            InitializeComponent();
        }

        private void firstStar_MouseEnter(object sender, EventArgs e)
        {
            firstStar.BackgroundImage = Image.FromFile(@"img/btn/star_orange.png");
        }

        private void firstStar_MouseLeave(object sender, EventArgs e)
        {
            firstStar.BackgroundImage = Image.FromFile(@"img/btn/star_blue.png");
        }

        private void secondStar_Click(object sender, EventArgs e)
        {

        }
    }
}
