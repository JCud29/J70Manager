namespace J70Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnGalleryGen = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.BtnGalleryGen);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 669);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnGalleryGen
            // 
            this.BtnGalleryGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGalleryGen.FlatAppearance.BorderSize = 0;
            this.BtnGalleryGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGalleryGen.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGalleryGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnGalleryGen.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnGalleryGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalleryGen.Location = new System.Drawing.Point(0, 150);
            this.BtnGalleryGen.Name = "BtnGalleryGen";
            this.BtnGalleryGen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGalleryGen.Size = new System.Drawing.Size(250, 70);
            this.BtnGalleryGen.TabIndex = 2;
            this.BtnGalleryGen.Text = "  Gallery Generator";
            this.BtnGalleryGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalleryGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGalleryGen.UseVisualStyleBackColor = true;
            this.BtnGalleryGen.Click += new System.EventHandler(this.BtnGalleryGen_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnHome.Image = global::J70Manager.Properties.Resources.homeIcon;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 80);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(250, 70);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "  Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::J70Manager.Properties.Resources.J70_manager_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.panelTop.Controls.Add(this.LabelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1345, 80);
            this.panelTop.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LabelTitle.Location = new System.Drawing.Point(604, 23);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(96, 34);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Home";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 80);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1345, 589);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 669);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1613, 716);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnGalleryGen;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel panelContainer;
    }
}

