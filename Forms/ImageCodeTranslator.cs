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
    public partial class ImageCodeTranslator : Form
    {
        private readonly FileAccess _fileClient = new FileAccess();
        private readonly string _codesUrl = "..\\..\\PreviousCodes.txt";
        private List<string> _previousCodes = new List<string>();
        private const string _placeHolder = " Enter Image Code Here...";
        public ImageCodeTranslator()
        {
            InitializeComponent();
        }

        private void ImageCodeTranslator_Load(object sender, EventArgs e)
        {
            LoadPreviousCodes();
            TBCode.Text = _placeHolder;
        }

        private void LoadPreviousCodes()
        {
            LBPrevious.Items.Clear();
            _previousCodes = _fileClient.ReadTextFile(_codesUrl);
            //remove codes if the size of the list is above the limit of 18
            while (_previousCodes.Count > 18)
                _previousCodes.RemoveAt(18);
            foreach (string code in _previousCodes)
                LBPrevious.Items.Add(code);
        }

        private void TBCode_Enter(object sender, EventArgs e)
        {
            if (TBCode.Text == _placeHolder)
            {
                TBCode.Text = "";
            }
        }

        private void TBCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBCode.Text))
            {
                TBCode.Text = _placeHolder;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TBCode.Text) || TBCode.Text != _placeHolder)
            {
                if(TBCode.Text.Length >= 5 && TBCode.Text.Length < 9)
                {
                    convertCode();
                }
                else
                {
                    invalidCode();
                }
            }
            else
            {
                invalidCode();
            }
        }

        private void invalidCode()
        {
            TBCode.ForeColor = Color.Red;
            MessageBox.Show("That code was invalid, please try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void convertCode()
        {
            //maybe change to char array
            string code = TBCode.Text;
            string championshipCode = code.Substring(0, 1);
            string trackCode = code.Substring(1, 1);
            string monthCode = code.Substring(2, 1).ToUpper();
            string yearCode = code.Substring(3, 2);
            string[] result = new string[4];

            int success = 0;

            success = convertChampionship(ref result, championshipCode);
            if (success == 0)
            {
                success = convertTrack(ref result, trackCode);
                if (success == 0)
                {
                    success = convertMonth(ref result, monthCode);
                    if (success == 0)
                    {
                        success = convertYear(ref result, yearCode);
                        if (success == 0)
                        {
                            outputResult(result);
                        }
                        else
                        {
                            invalidCode();
                        }

                    }
                    else
                    {
                        invalidCode();
                    }
                }
                else
                {
                    invalidCode();
                }
            }
            else
            {
                invalidCode();
            }
        }

        private void outputResult(string[] result)
        {
            TBChampionship.Text = result[0];
            TBTrack.Text = result[1];
            TBMonth.Text = result[2];
            TBYear.Text = result[3];

            if (TBCode.Text.Length > 5)
            {
                TBImage.Text = TBCode.Text.Substring(5);
            }
        }

        //maybe add a map for following methods
        private int convertChampionship(ref string[] result, string championship)
        {
            
            switch (championship)
            {
                case "1":
                    result[0] = "BTCC";
                    return 0;
                case "2":
                    result[0] = "British GT";
                    return 0;
                case "3":
                    result[0] = "GT Cup";
                    return 0;
                case "4":
                    result[0] = "British Endurance";
                    return 0;
                case "5":
                    result[0] = "World GT";
                    return 0;
                case "6":
                    result[0] = "F1";
                    return 0;
                case "7":
                    result[0] = "WEC";
                    return 0;
                case "0":
                    result[0] = "Other";
                    return 0;
                default:
                    return -1;
            }
        }

        private int convertTrack(ref string[] result, string track)
        {

            switch (track)
            {
                case "1":
                    result[1] = "Brands Hatch";
                    return 0;
                case "2":
                    result[1] = "Donington Park";
                    return 0;
                case "3":
                    result[1] = "Oulton Park";
                    return 0;
                case "4":
                    result[1] = "Snetterton";
                    return 0;
                case "5":
                    result[1] = "Silverstone";
                    return 0;
                case "6":
                    result[1] = "Cadwell";
                    return 0;
                case "7":
                    result[1] = "Thruxton";
                    return 0;
                case "8":
                    result[1] = "Croft";
                    return 0;
                case "9":
                    result[1] = "Knockhill";
                    return 0;
                case "0":
                    result[1] = "Other / Outside Uk";
                    return 0;
                default:
                    return -1;
            }
        }

        private int convertMonth(ref string[] result, string month)
        {

            switch (month)
            {
                case "A":
                    result[2] = "January";
                    return 0;
                case "B":
                    result[2] = "February";
                    return 0;
                case "C":
                    result[2] = "March";
                    return 0;
                case "D":
                    result[2] = "April";
                    return 0;
                case "E":
                    result[2] = "May";
                    return 0;
                case "F":
                    result[2] = "June";
                    return 0;
                case "G":
                    result[2] = "July";
                    return 0;
                case "H":
                    result[2] = "August";
                    return 0;
                case "I":
                    result[2] = "September";
                    return 0;
                case "J":
                    result[2] = "October";
                    return 0;
                case "K":
                    result[2] = "November ";
                    return 0;
                case "L":
                    result[2] = "December";
                    return 0;
                default:
                    return -1;
            }
        }

        private int convertYear(ref string[] result, string year)
        {

            switch (year)
            {
                case "22":
                    result[3] = "2022";
                    return 0;
                case "23":
                    result[3] = "2023";
                    return 0;
                case "24":
                    result[3] = "2024";
                    return 0;
                case "25":
                    result[3] = "2025";
                    return 0;
                case "26":
                    result[3] = "2026";
                    return 0;
                case "27":
                    result[3] = "2027";
                    return 0;
                case "28":
                    result[3] = "2028";
                    return 0;
                case "29":
                    result[3] = "2029";
                    return 0;
                case "30":
                    result[3] = "2030";
                    return 0;
                case "31":
                    result[3] = "2031";
                    return 0;
                case "32":
                    result[3] = "2032";
                    return 0;
                case "33":
                    result[3] = "2033";
                    return 0;
                case "34":
                    result[3] = "2034";
                    return 0;
                case "35":
                    result[3] = "2035";
                    return 0;
                default:
                    return -1;
            }
        }
    }
}
