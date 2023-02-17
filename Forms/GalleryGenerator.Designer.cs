namespace J70Manager.Forms
{
    partial class GalleryGenerator
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
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TBFileName = new System.Windows.Forms.TextBox();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TBLocation = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.NumEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // TBTitle
            // 
            this.TBTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBTitle.Location = new System.Drawing.Point(76, 75);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.ShortcutsEnabled = false;
            this.TBTitle.Size = new System.Drawing.Size(400, 30);
            this.TBTitle.TabIndex = 0;
            this.TBTitle.Text = "Gallery Title";
            this.TBTitle.Enter += new System.EventHandler(this.TBTitle_Enter);
            this.TBTitle.Leave += new System.EventHandler(this.TBTitle_Leave);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblTitle.Location = new System.Drawing.Point(72, 50);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(116, 22);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Gallery Title";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblDescription.Location = new System.Drawing.Point(571, 50);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(169, 22);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description / Date";
            // 
            // TBDescription
            // 
            this.TBDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBDescription.Location = new System.Drawing.Point(575, 75);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.ShortcutsEnabled = false;
            this.TBDescription.Size = new System.Drawing.Size(400, 30);
            this.TBDescription.TabIndex = 2;
            this.TBDescription.Text = "Description / Date";
            this.TBDescription.Enter += new System.EventHandler(this.TBDescription_Enter);
            this.TBDescription.Leave += new System.EventHandler(this.TBDescription_Leave);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.BtnGenerate.FlatAppearance.BorderSize = 0;
            this.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnGenerate.Location = new System.Drawing.Point(1057, 462);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(217, 68);
            this.BtnGenerate.TabIndex = 4;
            this.BtnGenerate.Text = "Generate Gallery";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblFileName.Location = new System.Drawing.Point(72, 140);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(145, 22);
            this.LblFileName.TabIndex = 6;
            this.LblFileName.Text = "Base File Name";
            // 
            // TBFileName
            // 
            this.TBFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBFileName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBFileName.Location = new System.Drawing.Point(76, 165);
            this.TBFileName.Name = "TBFileName";
            this.TBFileName.ShortcutsEnabled = false;
            this.TBFileName.Size = new System.Drawing.Size(400, 30);
            this.TBFileName.TabIndex = 5;
            this.TBFileName.Text = "Base File Name";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblStart.Location = new System.Drawing.Point(571, 140);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(109, 22);
            this.LblStart.TabIndex = 8;
            this.LblStart.Text = "Start Range";
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblEnd.Location = new System.Drawing.Point(793, 140);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(104, 22);
            this.LblEnd.TabIndex = 10;
            this.LblEnd.Text = "End Range";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblLocation.Location = new System.Drawing.Point(72, 233);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(141, 22);
            this.LblLocation.TabIndex = 12;
            this.LblLocation.Text = "Photo Location";
            // 
            // TBLocation
            // 
            this.TBLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBLocation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBLocation.Location = new System.Drawing.Point(76, 258);
            this.TBLocation.Name = "TBLocation";
            this.TBLocation.ShortcutsEnabled = false;
            this.TBLocation.Size = new System.Drawing.Size(400, 30);
            this.TBLocation.TabIndex = 11;
            this.TBLocation.Text = "Photo Location";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LblOutput.Location = new System.Drawing.Point(63, 462);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(150, 22);
            this.LblOutput.TabIndex = 14;
            this.LblOutput.Text = "Output Location";
            // 
            // TBOutput
            // 
            this.TBOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TBOutput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TBOutput.Location = new System.Drawing.Point(67, 487);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ShortcutsEnabled = false;
            this.TBOutput.Size = new System.Drawing.Size(909, 30);
            this.TBOutput.TabIndex = 13;
            this.TBOutput.Text = "Output Location";
            // 
            // NumStart
            // 
            this.NumStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NumStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumStart.Location = new System.Drawing.Point(575, 165);
            this.NumStart.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(178, 32);
            this.NumStart.TabIndex = 15;
            this.NumStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumEnd
            // 
            this.NumEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NumEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.NumEnd.Location = new System.Drawing.Point(797, 165);
            this.NumEnd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Size = new System.Drawing.Size(178, 32);
            this.NumEnd.TabIndex = 16;
            this.NumEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GalleryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1327, 542);
            this.Controls.Add(this.NumEnd);
            this.Controls.Add(this.NumStart);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.TBLocation);
            this.Controls.Add(this.LblEnd);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.TBFileName);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TBTitle);
            this.Name = "GalleryGenerator";
            this.Text = "Gallery Generator";
            this.Load += new System.EventHandler(this.GalleryGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.TextBox TBFileName;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TBLocation;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.NumericUpDown NumEnd;
    }
}