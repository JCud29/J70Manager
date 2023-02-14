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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnGalleryGen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOther1 = new System.Windows.Forms.Button();
            this.BtnOther2 = new System.Windows.Forms.Button();
            this.BtnOther3 = new System.Windows.Forms.Button();
            this.BtnOther4 = new System.Windows.Forms.Button();
            this.BtnOther5 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.BtnOther5);
            this.panelMenu.Controls.Add(this.BtnOther4);
            this.panelMenu.Controls.Add(this.BtnOther3);
            this.panelMenu.Controls.Add(this.BtnOther2);
            this.panelMenu.Controls.Add(this.BtnOther1);
            this.panelMenu.Controls.Add(this.BtnGalleryGen);
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
            // BtnGalleryGen
            // 
            this.BtnGalleryGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGalleryGen.FlatAppearance.BorderSize = 0;
            this.BtnGalleryGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGalleryGen.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGalleryGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnGalleryGen.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnGalleryGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalleryGen.Location = new System.Drawing.Point(0, 80);
            this.BtnGalleryGen.Name = "BtnGalleryGen";
            this.BtnGalleryGen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGalleryGen.Size = new System.Drawing.Size(250, 70);
            this.BtnGalleryGen.TabIndex = 1;
            this.BtnGalleryGen.Text = "  Gallery Generator";
            this.BtnGalleryGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGalleryGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGalleryGen.UseVisualStyleBackColor = true;
            this.BtnGalleryGen.Click += new System.EventHandler(this.BtnGalleryGen_Click);
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
            // BtnOther1
            // 
            this.BtnOther1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther1.FlatAppearance.BorderSize = 0;
            this.BtnOther1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOther1.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnOther1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther1.Location = new System.Drawing.Point(0, 150);
            this.BtnOther1.Name = "BtnOther1";
            this.BtnOther1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOther1.Size = new System.Drawing.Size(250, 70);
            this.BtnOther1.TabIndex = 2;
            this.BtnOther1.Text = "  other";
            this.BtnOther1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther1.UseVisualStyleBackColor = true;
            // 
            // BtnOther2
            // 
            this.BtnOther2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther2.FlatAppearance.BorderSize = 0;
            this.BtnOther2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOther2.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnOther2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther2.Location = new System.Drawing.Point(0, 220);
            this.BtnOther2.Name = "BtnOther2";
            this.BtnOther2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOther2.Size = new System.Drawing.Size(250, 70);
            this.BtnOther2.TabIndex = 3;
            this.BtnOther2.Text = "  other";
            this.BtnOther2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther2.UseVisualStyleBackColor = true;
            // 
            // BtnOther3
            // 
            this.BtnOther3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther3.FlatAppearance.BorderSize = 0;
            this.BtnOther3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOther3.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnOther3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther3.Location = new System.Drawing.Point(0, 290);
            this.BtnOther3.Name = "BtnOther3";
            this.BtnOther3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOther3.Size = new System.Drawing.Size(250, 70);
            this.BtnOther3.TabIndex = 4;
            this.BtnOther3.Text = "  other";
            this.BtnOther3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther3.UseVisualStyleBackColor = true;
            // 
            // BtnOther4
            // 
            this.BtnOther4.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther4.FlatAppearance.BorderSize = 0;
            this.BtnOther4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOther4.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnOther4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther4.Location = new System.Drawing.Point(0, 360);
            this.BtnOther4.Name = "BtnOther4";
            this.BtnOther4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOther4.Size = new System.Drawing.Size(250, 70);
            this.BtnOther4.TabIndex = 5;
            this.BtnOther4.Text = "  other";
            this.BtnOther4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther4.UseVisualStyleBackColor = true;
            // 
            // BtnOther5
            // 
            this.BtnOther5.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther5.FlatAppearance.BorderSize = 0;
            this.BtnOther5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOther5.Image = global::J70Manager.Properties.Resources.htmlicon;
            this.BtnOther5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther5.Location = new System.Drawing.Point(0, 430);
            this.BtnOther5.Name = "BtnOther5";
            this.BtnOther5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOther5.Size = new System.Drawing.Size(250, 70);
            this.BtnOther5.TabIndex = 6;
            this.BtnOther5.Text = "  other";
            this.BtnOther5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1359, 669);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnGalleryGen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOther5;
        private System.Windows.Forms.Button BtnOther4;
        private System.Windows.Forms.Button BtnOther3;
        private System.Windows.Forms.Button BtnOther2;
        private System.Windows.Forms.Button BtnOther1;
    }
}

