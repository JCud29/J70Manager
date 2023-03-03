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
        private HtmlGenerator HtmlClient;
        public GalleryGenerator()
        {
            InitializeComponent();
            HtmlClient = new HtmlGenerator();
        }

        private void GalleryGenerator_Load(object sender, EventArgs e)
        {
            TBTitle.Text = " Place Holder text...";
            TBDescription.Text = " Place Holder text...";
            TBFileName.Text = " Place Holder text...";
            TBLocation.Text = " Place Holder text...";
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

        private void TBFileName_Enter(object sender, EventArgs e)
        {
            if (TBFileName.Text == " Place Holder text...")
                TBFileName.Text = "";
        }

        private void TBFileName_Leave(object sender, EventArgs e)
        {
            if (TBFileName.Text == "")
                TBFileName.Text = " Place Holder text...";
        }

        private void TBLocation_Enter(object sender, EventArgs e)
        {
            if (TBLocation.Text == " Place Holder text...")
                TBLocation.Text = "";
        }

        private void TBLocation_Leave(object sender, EventArgs e)
        {
            if (TBLocation.Text == "")
                TBLocation.Text = " Place Holder text...";
        }

        private bool IsEmpty()
        {
            bool empty = false;
            if(string.IsNullOrEmpty(TBTitle.Text.Trim()) || TBTitle.Text == " Place Holder text...")
            {
                empty = true;
                TBTitle.ForeColor = Color.Red;
            }
            if (string.IsNullOrEmpty(TBDescription.Text.Trim()) || TBDescription.Text == " Place Holder text...")
            {
                empty = true;
                TBDescription.ForeColor = Color.Red;
            }
            if (string.IsNullOrEmpty(TBFileName.Text.Trim()) || TBFileName.Text == " Place Holder text...")
            {
                empty = true;
                TBFileName.ForeColor = Color.Red;
            }
            if (string.IsNullOrEmpty(TBLocation.Text.Trim()) || TBLocation.Text == " Place Holder text...")
            {
                empty = true;
                TBLocation.ForeColor = Color.Red;
            }
            if (empty)
                MessageBox.Show("These fields are required", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return empty;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            bool empty = IsEmpty();
            bool valid = true;
            if (NumEnd.Value < NumStart.Value)
            {
                valid = false;
                MessageBox.Show("End Range can't be larger than Start Range", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valid && !empty)
            {
                int success = HtmlClient.GenerateFile(TBTitle.Text, TBDescription.Text, Convert.ToInt32(NumStart.Value), Convert.ToInt32(NumEnd.Value), TBFileName.Text, TBLocation.Text);
                if (success == 0) {
                    TBOutput.Enabled = true;
                    TBOutput.Text = TBTitle.Text + "- File Created";
                }
                else
                {
                    MessageBox.Show("File not created, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }
    }
}
