using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J70Manager
{
    public partial class Form1 : Form
    {
        private Button currentBtn;
        private Form currentForm;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHome.PerformClick();
        }

        private void HighlightButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    HideButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(33, 191, 181);
                    currentBtn.ForeColor = Color.FromArgb(242, 242, 242);
                    currentBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        private void HideButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 51);
                    previousBtn.ForeColor = Color.FromArgb(242, 242, 242);
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }

        

        private void OpenChildForm(Form child, object btnSender)
        {
            if(currentForm != null)
                currentForm.Close();
            HighlightButton(btnSender);
            currentForm = child;
            child.TopLevel = false;
            child.FormBorderStyle= FormBorderStyle.None;
            child.Dock= DockStyle.Fill;
            this.panelContainer.Controls.Add(child);
            this.panelContainer.Tag = child;
            child.BringToFront();
            child.Show();
            LabelTitle.Text = child.Text;
            var labelWidth = LabelTitle.Width;
            var formWidth = this.Width;
            var labelPos = (formWidth-250)/2 - (labelWidth/2);
            LabelTitle.Left = labelPos;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void BtnGalleryGen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GalleryGenerator(), sender);
        }

        
    }
}
