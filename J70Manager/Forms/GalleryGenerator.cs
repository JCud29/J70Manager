﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace J70Manager.Forms
{
    public partial class GalleryGenerator : Form
    {
        private readonly HtmlGenerator _HtmlGenerator = new HtmlGenerator();
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
        public GalleryGenerator()
        {
            InitializeComponent();
        }

        private void GalleryGenerator_Load(object sender, EventArgs e)
        {
            _textBoxes.AddRange(new List<TextBox>()
            {
                TBTitle,
                TBDescription,
                TBFileName,
                TBLocation
            });

            TBTitle.Text = " Place Holder text...";
            TBDescription.Text = " Place Holder text...";
            TBFileName.Text = " Place Holder text...";
            TBLocation.Text = " Place Holder text...";
        }

        private void TBTitle_Enter(object sender, EventArgs e)
        {
            if (TBTitle.Text == " Place Holder text...")
            {
                TBTitle.Text = "";
            }
        }

        private void TBTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBTitle.Text))
            {
                TBTitle.Text = " Place Holder text...";
            }
        }

        private void TBDescription_Enter(object sender, EventArgs e)
        {
            if (TBDescription.Text == " Place Holder text...")
            {
                TBDescription.Text = "";
            }
        }

        private void TBDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDescription.Text))
            {
                TBDescription.Text = " Place Holder text...";
            }
        }

        private void TBFileName_Enter(object sender, EventArgs e)
        {
            if (TBFileName.Text == " Place Holder text...")
            {
                TBFileName.Text = "";
            }
        }

        private void TBFileName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBFileName.Text))
            {
                TBFileName.Text = " Place Holder text...";
            }
        }

        private void TBLocation_Enter(object sender, EventArgs e)
        {
            if (TBLocation.Text == " Place Holder text...")
            {
                TBLocation.Text = "";
            }
        }

        private void TBLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLocation.Text)) 
            {
                TBLocation.Text = " Place Holder text...";
            }
                
        }

        private bool FieldsEmpty()
        {
            bool containsInvalidFields = false;
            if (string.IsNullOrWhiteSpace(TBTitle.Text.Trim()) || TBTitle.Text == " Place Holder text...")
            {
                containsInvalidFields = true;
                TBTitle.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(TBDescription.Text.Trim()) || TBDescription.Text == " Place Holder text...")
            {
                containsInvalidFields = true;
                TBDescription.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(TBFileName.Text.Trim()) || TBFileName.Text == " Place Holder text...")
            {
                containsInvalidFields = true;
                TBFileName.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(TBLocation.Text.Trim()) || TBLocation.Text == " Place Holder text...")
            {
                containsInvalidFields = true;
                TBLocation.ForeColor = Color.Red;
            }
            if (containsInvalidFields)
                MessageBox.Show("These fields are required", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return containsInvalidFields;

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            bool empty = FieldsEmpty();
            bool valid = true;
            if (NumEnd.Value < NumStart.Value)
            {
                valid = false;
                MessageBox.Show("End Range can't be larger than Start Range", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valid && !empty)
            {
                int success = _HtmlGenerator.GenerateFile(TBTitle.Text, TBDescription.Text, Convert.ToInt32(NumStart.Value), Convert.ToInt32(NumEnd.Value), TBFileName.Text, TBLocation.Text);
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
