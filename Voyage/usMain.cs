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
    public partial class usMain : UserControl
    {
        public usMain()
        {
            InitializeComponent();
            lSlogan.ForeColor = Color.FromArgb(0, 71, 160);
            lContact.ForeColor = Color.FromArgb(0, 71, 160);
            lCountries.ForeColor = Color.FromArgb(0, 71, 160);
        }
    }
}
