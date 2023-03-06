using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace J70Manager.Forms
{
	public partial class GalleryGenerator : Form
	{
		private readonly HtmlGenerator _htmlGenerator = new HtmlGenerator();
		private readonly List<TextBox> _textBoxes = new List<TextBox>();
		private const string PLACEHOLDER_TEXT = " Placeholder text...";

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

			TBTitle.Text = PLACEHOLDER_TEXT;
			TBDescription.Text = PLACEHOLDER_TEXT;
			TBFileName.Text = PLACEHOLDER_TEXT;
			TBLocation.Text = PLACEHOLDER_TEXT;
		}

		private void TBTitle_Enter(object sender, EventArgs e)
		{
			if (TBTitle.Text == PLACEHOLDER_TEXT)
			{
				TBTitle.Text = "";
			}
		}

		private void TBTitle_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TBTitle.Text))
			{
				TBTitle.Text = PLACEHOLDER_TEXT;
			}
		}

		private void TBDescription_Enter(object sender, EventArgs e)
		{
			if (TBDescription.Text == PLACEHOLDER_TEXT)
			{
				TBDescription.Text = "";
			}
		}

		private void TBDescription_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TBDescription.Text))
			{
				TBDescription.Text = PLACEHOLDER_TEXT;
			}
		}

		private void TBFileName_Enter(object sender, EventArgs e)
		{
			if (TBFileName.Text == PLACEHOLDER_TEXT)
				TBFileName.Text = "";
		}

		private void TBFileName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TBFileName.Text))
			{
				TBFileName.Text = PLACEHOLDER_TEXT;
			}
		}

		private void TBLocation_Enter(object sender, EventArgs e)
		{
			if (TBLocation.Text == PLACEHOLDER_TEXT)
			{
				TBLocation.Text = "";
			}
		}

		private void TBLocation_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TBLocation.Text))
			{
				TBLocation.Text = PLACEHOLDER_TEXT;
			}
		}

		private bool FieldsEmpty()
		{
			bool containsInvalidFields = false;
			foreach (TextBox textBox in _textBoxes)
			{
				if (string.IsNullOrWhiteSpace(textBox.Text.Trim()) || textBox.Text == PLACEHOLDER_TEXT)
				{
					containsInvalidFields = true;
					textBox.ForeColor = Color.Red;
				}
			}

			if (containsInvalidFields)
			{
				MessageBox.Show("These fields are required", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
				int success = _htmlGenerator.GenerateFile(TBTitle.Text, TBDescription.Text, Convert.ToInt32(NumStart.Value), Convert.ToInt32(NumEnd.Value), TBFileName.Text, TBLocation.Text);
				if (success == 0)
				{
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
