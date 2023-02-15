using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J70Manager.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var logoWidth = PBLogo.Width;
            var formWidth = this.Width;
            var logoPos = formWidth / 2 - (logoWidth / 2);
            PBLogo.Left = logoPos;
        }
    }
}
