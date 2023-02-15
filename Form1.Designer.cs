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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.BtnEditKeyword = new System.Windows.Forms.Button();
            this.BtnKeyword = new System.Windows.Forms.Button();
            this.BtnImageTranslator = new System.Windows.Forms.Button();
            this.BtnImageGen = new System.Windows.Forms.Button();
            this.BtnGalleryGen = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.BtnEditKeyword);
            this.panelMenu.Controls.Add(this.BtnKeyword);
            this.panelMenu.Controls.Add(this.BtnImageTranslator);
            this.panelMenu.Controls.Add(this.BtnImageGen);
            this.panelMenu.Controls.Add(this.BtnGalleryGen);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 669);
            this.panelMenu.TabIndex = 0;
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
            // BtnEditKeyword
            // 
            this.BtnEditKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditKeyword.FlatAppearance.BorderSize = 0;
            this.BtnEditKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditKeyword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnEditKeyword.Image = global::J70Manager.Properties.Resources.edit;
            this.BtnEditKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditKeyword.Location = new System.Drawing.Point(0, 430);
            this.BtnEditKeyword.Name = "BtnEditKeyword";
            this.BtnEditKeyword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEditKeyword.Size = new System.Drawing.Size(250, 70);
            this.BtnEditKeyword.TabIndex = 6;
            this.BtnEditKeyword.Text = "  Edit Keywords";
            this.BtnEditKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditKeyword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditKeyword.UseVisualStyleBackColor = true;
            this.BtnEditKeyword.Click += new System.EventHandler(this.BtnEditKeyword_Click);
            // 
            // BtnKeyword
            // 
            this.BtnKeyword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnKeyword.FlatAppearance.BorderSize = 0;
            this.BtnKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKeyword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnKeyword.Image = global::J70Manager.Properties.Resources.keywords;
            this.BtnKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeyword.Location = new System.Drawing.Point(0, 360);
            this.BtnKeyword.Name = "BtnKeyword";
            this.BtnKeyword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnKeyword.Size = new System.Drawing.Size(250, 70);
            this.BtnKeyword.TabIndex = 5;
            this.BtnKeyword.Text = "  Keywords";
            this.BtnKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeyword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKeyword.UseVisualStyleBackColor = true;
            this.BtnKeyword.Click += new System.EventHandler(this.BtnKeyword_Click);
            // 
            // BtnImageTranslator
            // 
            this.BtnImageTranslator.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnImageTranslator.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImageTranslator.FlatAppearance.BorderSize = 0;
            this.BtnImageTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImageTranslator.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageTranslator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnImageTranslator.Image = global::J70Manager.Properties.Resources.convert;
            this.BtnImageTranslator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImageTranslator.Location = new System.Drawing.Point(0, 290);
            this.BtnImageTranslator.Name = "BtnImageTranslator";
            this.BtnImageTranslator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnImageTranslator.Size = new System.Drawing.Size(250, 70);
            this.BtnImageTranslator.TabIndex = 4;
            this.BtnImageTranslator.Text = "  Image Translator";
            this.BtnImageTranslator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImageTranslator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImageTranslator.UseVisualStyleBackColor = true;
            this.BtnImageTranslator.Click += new System.EventHandler(this.BtnImageTranslator_Click);
            // 
            // BtnImageGen
            // 
            this.BtnImageGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImageGen.FlatAppearance.BorderSize = 0;
            this.BtnImageGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImageGen.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnImageGen.Image = global::J70Manager.Properties.Resources.code;
            this.BtnImageGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImageGen.Location = new System.Drawing.Point(0, 220);
            this.BtnImageGen.Name = "BtnImageGen";
            this.BtnImageGen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnImageGen.Size = new System.Drawing.Size(250, 70);
            this.BtnImageGen.TabIndex = 3;
            this.BtnImageGen.Text = "  Image Code";
            this.BtnImageGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImageGen.UseVisualStyleBackColor = true;
            this.BtnImageGen.Click += new System.EventHandler(this.BtnImageGen_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnImageTranslator;
            this.ClientSize = new System.Drawing.Size(1595, 669);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1613, 716);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "J70 Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button BtnEditKeyword;
        private System.Windows.Forms.Button BtnKeyword;
        private System.Windows.Forms.Button BtnImageTranslator;
        private System.Windows.Forms.Button BtnImageGen;
    }
}

