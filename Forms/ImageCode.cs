﻿using System;
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
    public partial class ImageCode : Form
    {
        private FileAccess fileClient;
        private string UrlCodes = "..\\..\\PreviousCodes.txt";
        public ImageCode()
        {
            InitializeComponent();
            fileClient = new FileAccess();
        }

        private void ImageCode_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            bool valid = ValidationCheck();
            if (valid)
            {
                string championship = DropChampionship.SelectedValue.ToString();
                string track = DropTrack.SelectedValue.ToString();
                string month = DropMonth.SelectedValue.ToString();
                string year = DropYear.SelectedValue.ToString();
                string imageNumber = TBImage.Text;

                System.Text.StringBuilder codeBuilder = new System.Text.StringBuilder(championship);
                codeBuilder.Append(track).Append(month).Append(year).Append(imageNumber);
                string imageCode = codeBuilder.ToString();
                
                TBCode.Text = imageCode;
            }

        }

        private bool ValidationCheck()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(TBImage.Text.Trim()))
                valid = true;
            else
            {
                valid = IsValid(TBImage.Text.Trim());
                if (!valid)
                {
                    TBImage.ForeColor = Color.Red;
                    MessageBox.Show("Invalid image number", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    TBImage.ForeColor = Color.FromArgb(242,242,242);
            }

            return valid;
        }

        private void initForm()
        {
            List<DropDownItem> championships = new List<DropDownItem>();
            championships.Add(new DropDownItem() { text = "BTCC", value = "1" });
            championships.Add(new DropDownItem() { text = "British GT", value = "2" });
            championships.Add(new DropDownItem() { text = "GT Cup", value = "3" });
            championships.Add(new DropDownItem() { text = "British Endurance", value = "4" });
            championships.Add(new DropDownItem() { text = "World GT", value = "5" });
            championships.Add(new DropDownItem() { text = "F1", value = "6" });
            championships.Add(new DropDownItem() { text = "WEC", value = "7" });
            championships.Add(new DropDownItem() { text = "Other", value = "0" });

            DropChampionship.DataSource = championships;
            DropChampionship.DisplayMember = "text";
            DropChampionship.ValueMember = "value";

            List<DropDownItem> tracks = new List<DropDownItem>();
            tracks.Add(new DropDownItem() { text = "Brands Hatch", value = "1" });
            tracks.Add(new DropDownItem() { text = "Donington Park", value = "2" });
            tracks.Add(new DropDownItem() { text = "Oulton Park", value = "3" });
            tracks.Add(new DropDownItem() { text = "Snetterton", value = "4" });
            tracks.Add(new DropDownItem() { text = "Sliverstone", value = "5" });
            tracks.Add(new DropDownItem() { text = "Cadwell", value = "6" });
            tracks.Add(new DropDownItem() { text = "Thruxton", value = "7" });
            tracks.Add(new DropDownItem() { text = "Croft", value = "8" });
            tracks.Add(new DropDownItem() { text = "Knockhill", value = "9" });
            tracks.Add(new DropDownItem() { text = "Other / Outside Uk", value = "0" });

            DropTrack.DataSource = tracks;
            DropTrack.DisplayMember = "text";
            DropTrack.ValueMember = "value";

            List<DropDownItem> months = new List<DropDownItem>();
            months.Add(new DropDownItem() { text = "January", value = "A" });
            months.Add(new DropDownItem() { text = "February", value = "B" });
            months.Add(new DropDownItem() { text = "March", value = "C" });
            months.Add(new DropDownItem() { text = "April", value = "D" });
            months.Add(new DropDownItem() { text = "May", value = "E" });
            months.Add(new DropDownItem() { text = "June", value = "F" });
            months.Add(new DropDownItem() { text = "July", value = "G" });
            months.Add(new DropDownItem() { text = "August", value = "H" });
            months.Add(new DropDownItem() { text = "September", value = "I" });
            months.Add(new DropDownItem() { text = "October", value = "J" });
            months.Add(new DropDownItem() { text = "November", value = "K" });
            months.Add(new DropDownItem() { text = "December", value = "L" });

            DropMonth.DataSource = months;
            DropMonth.DisplayMember = "text";
            DropMonth.ValueMember = "value";

            List<DropDownItem> years = new List<DropDownItem>();
            years.Add(new DropDownItem() { text = "2022", value = "22" });
            years.Add(new DropDownItem() { text = "2023", value = "23" });
            years.Add(new DropDownItem() { text = "2024", value = "24" });
            years.Add(new DropDownItem() { text = "2025", value = "25" });
            years.Add(new DropDownItem() { text = "2026", value = "26" });
            years.Add(new DropDownItem() { text = "2027", value = "27" });
            years.Add(new DropDownItem() { text = "2028", value = "28" });
            years.Add(new DropDownItem() { text = "2029", value = "29" });
            years.Add(new DropDownItem() { text = "2030", value = "30" });
            years.Add(new DropDownItem() { text = "2031", value = "31" });
            years.Add(new DropDownItem() { text = "2032", value = "32" });
            years.Add(new DropDownItem() { text = "2033", value = "33" });
            years.Add(new DropDownItem() { text = "2034", value = "34" });
            years.Add(new DropDownItem() { text = "2035", value = "35" });

            DropYear.DataSource = years;
            DropYear.DisplayMember = "text";
            DropYear.ValueMember = "value";

            LoadPreviousCodes();
        }

        private void LoadPreviousCodes()
        {
            List<string> codes = fileClient.ReadTextFile(UrlCodes);
            LBPrevious.DataSource = codes;
        }

        private bool IsValid(string image)
        {
            foreach (char c in image)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;

        }
        
    }

    class DropDownItem
    {
        public string text { get; set; }
        public string value { get; set; }
    }
}
