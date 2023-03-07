namespace J70Manager.Forms
{
    partial class ImageCode
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
            this.DropChampionship = new System.Windows.Forms.ComboBox();
            this.LblChampionship = new System.Windows.Forms.Label();
            this.LblTrack = new System.Windows.Forms.Label();
            this.DropTrack = new System.Windows.Forms.ComboBox();
            this.LblMonth = new System.Windows.Forms.Label();
            this.DropMonth = new System.Windows.Forms.ComboBox();
            this.LblYear = new System.Windows.Forms.Label();
            this.DropYear = new System.Windows.Forms.ComboBox();
            this.LblImage = new System.Windows.Forms.Label();
            this.TBImage = new System.Windows.Forms.TextBox();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblPrevious = new System.Windows.Forms.Label();
            this.LBPrevious = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DropChampionship
            // 
            this.DropChampionship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DropChampionship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropChampionship.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropChampionship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DropChampionship.FormattingEnabled = true;
            this.DropChampionship.Items.AddRange(new object[] {
            "BTCC",
            "British GT",
            "GT Cup",
            "British Endurance",
            "World GT",
            "F1",
            "WEC",
            "Other"});
            this.DropChampionship.Location = new System.Drawing.Point(76, 75);
            this.DropChampionship.Name = "DropChampionship";
            this.DropChampionship.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DropChampionship.Size = new System.Drawing.Size(299, 29);
            this.DropChampionship.TabIndex = 0;
            // 
            // LblChampionship
            // 
            this.LblChampionship.AutoSize = true;
            this.LblChampionship.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChampionship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblChampionship.Location = new System.Drawing.Point(72, 50);
            this.LblChampionship.Name = "LblChampionship";
            this.LblChampionship.Size = new System.Drawing.Size(138, 22);
            this.LblChampionship.TabIndex = 1;
            this.LblChampionship.Text = "Championship";
            // 
            // LblTrack
            // 
            this.LblTrack.AutoSize = true;
            this.LblTrack.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblTrack.Location = new System.Drawing.Point(72, 149);
            this.LblTrack.Name = "LblTrack";
            this.LblTrack.Size = new System.Drawing.Size(58, 22);
            this.LblTrack.TabIndex = 3;
            this.LblTrack.Text = "Track";
            // 
            // DropTrack
            // 
            this.DropTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DropTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropTrack.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DropTrack.FormattingEnabled = true;
            this.DropTrack.Items.AddRange(new object[] {
            "Brands Hatch",
            "Donington Park",
            "Oulton Park",
            "Snetterton",
            "Silverstone",
            "Cadwell",
            "Thruxton",
            "Croft",
            "Knockhill",
            "Other / Outside UK"});
            this.DropTrack.Location = new System.Drawing.Point(76, 174);
            this.DropTrack.Name = "DropTrack";
            this.DropTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DropTrack.Size = new System.Drawing.Size(299, 29);
            this.DropTrack.TabIndex = 2;
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblMonth.Location = new System.Drawing.Point(72, 251);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(65, 22);
            this.LblMonth.TabIndex = 5;
            this.LblMonth.Text = "Month";
            // 
            // DropMonth
            // 
            this.DropMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DropMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropMonth.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DropMonth.FormattingEnabled = true;
            this.DropMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.DropMonth.Location = new System.Drawing.Point(76, 276);
            this.DropMonth.Name = "DropMonth";
            this.DropMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DropMonth.Size = new System.Drawing.Size(299, 29);
            this.DropMonth.TabIndex = 4;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblYear.Location = new System.Drawing.Point(72, 347);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(51, 22);
            this.LblYear.TabIndex = 7;
            this.LblYear.Text = "Year";
            // 
            // DropYear
            // 
            this.DropYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DropYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropYear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DropYear.FormattingEnabled = true;
            this.DropYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.DropYear.Location = new System.Drawing.Point(76, 372);
            this.DropYear.Name = "DropYear";
            this.DropYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DropYear.Size = new System.Drawing.Size(299, 29);
            this.DropYear.TabIndex = 6;
            // 
            // LblImage
            // 
            this.LblImage.AutoSize = true;
            this.LblImage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblImage.Location = new System.Drawing.Point(72, 446);
            this.LblImage.Name = "LblImage";
            this.LblImage.Size = new System.Drawing.Size(144, 22);
            this.LblImage.TabIndex = 9;
            this.LblImage.Text = "Image Number";
            // 
            // TBImage
            // 
            this.TBImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBImage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBImage.Location = new System.Drawing.Point(76, 471);
            this.TBImage.Name = "TBImage";
            this.TBImage.Size = new System.Drawing.Size(299, 30);
            this.TBImage.TabIndex = 10;
            // 
            // TBCode
            // 
            this.TBCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBCode.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBCode.Location = new System.Drawing.Point(493, 251);
            this.TBCode.Name = "TBCode";
            this.TBCode.ReadOnly = true;
            this.TBCode.Size = new System.Drawing.Size(299, 30);
            this.TBCode.TabIndex = 12;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblCode.Location = new System.Drawing.Point(489, 226);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(123, 22);
            this.LblCode.TabIndex = 11;
            this.LblCode.Text = "Image Code";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.BtnGenerate.FlatAppearance.BorderSize = 0;
            this.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnGenerate.Location = new System.Drawing.Point(493, 316);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(299, 68);
            this.BtnGenerate.TabIndex = 13;
            this.BtnGenerate.Text = "Generate Image Code";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblPrevious
            // 
            this.LblPrevious.AutoSize = true;
            this.LblPrevious.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblPrevious.Location = new System.Drawing.Point(857, 50);
            this.LblPrevious.Name = "LblPrevious";
            this.LblPrevious.Size = new System.Drawing.Size(248, 22);
            this.LblPrevious.TabIndex = 14;
            this.LblPrevious.Text = "Previous Codes Generated";
            // 
            // LBPrevious
            // 
            this.LBPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LBPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LBPrevious.FormattingEnabled = true;
            this.LBPrevious.ItemHeight = 23;
            this.LBPrevious.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.LBPrevious.Location = new System.Drawing.Point(861, 85);
            this.LBPrevious.Name = "LBPrevious";
            this.LBPrevious.Size = new System.Drawing.Size(439, 418);
            this.LBPrevious.TabIndex = 15;
            // 
            // ImageCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1327, 542);
            this.Controls.Add(this.LBPrevious);
            this.Controls.Add(this.LblPrevious);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.TBImage);
            this.Controls.Add(this.LblImage);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.DropYear);
            this.Controls.Add(this.LblMonth);
            this.Controls.Add(this.DropMonth);
            this.Controls.Add(this.LblTrack);
            this.Controls.Add(this.DropTrack);
            this.Controls.Add(this.LblChampionship);
            this.Controls.Add(this.DropChampionship);
            this.Name = "ImageCode";
            this.Text = "Image Code Generator";
            this.Load += new System.EventHandler(this.ImageCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropChampionship;
        private System.Windows.Forms.Label LblChampionship;
        private System.Windows.Forms.Label LblTrack;
        private System.Windows.Forms.ComboBox DropTrack;
        private System.Windows.Forms.Label LblMonth;
        private System.Windows.Forms.ComboBox DropMonth;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.ComboBox DropYear;
        private System.Windows.Forms.Label LblImage;
        private System.Windows.Forms.TextBox TBImage;
        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LblPrevious;
        private System.Windows.Forms.ListBox LBPrevious;
    }
}