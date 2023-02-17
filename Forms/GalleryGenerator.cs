using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace J70Manager.Forms
{
    public partial class GalleryGenerator : Form
    {
        public GalleryGenerator()
        {
            InitializeComponent();
        }

        private void GalleryGenerator_Load(object sender, EventArgs e)
        {
            TBTitle.Text = " Place Holder text...";
            TBDescription.Text = " Place Holder text...";

        }

        private void TBTitle_Enter(object sender, EventArgs e)
        {
            if (TBTitle.Text == " Place Holder text...")
                TBTitle.Text = "";
        }

        private void TBTitle_Leave(object sender, EventArgs e)
        {
            if (TBTitle.Text == "")
                TBTitle.Text = " Place Holder text...";
        }

        private void TBDescription_Enter(object sender, EventArgs e)
        {
            if (TBDescription.Text == " Place Holder text...")
                TBDescription.Text = "";
        }

        private void TBDescription_Leave(object sender, EventArgs e)
        {
            if (TBDescription.Text == "")
                TBDescription.Text = " Place Holder text...";
        }


    }
}
