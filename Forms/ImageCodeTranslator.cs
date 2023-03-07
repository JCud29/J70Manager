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
            {
                _previousCodes.RemoveAt(18);
            }
            
            foreach (string code in _previousCodes)
            {
                LBPrevious.Items.Add(code);
            }
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
            string[] result = new string[4]; // I would make this a model like
            /*
             class Championship {
                string championship
                string track
                etc...
             }


             its much more readable than an array
            */

            bool success = false;

            success = convertChampionship(ref result, championshipCode);
            if (success)
            {
                success = convertTrack(ref result, trackCode);
                if (success)
                {
                    success = convertMonth(ref result, monthCode);
                    if (success)
                    {
                        success = convertYear(ref result, yearCode);
                        if (success)
                        {
                            outputResult(result);
                        }
                    }
                }
            }
            if(!success)
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
        private bool convertChampionship(ref string[] result, string championship)
        {
            switch (championship)
            {
                case "1":
                    result[0] = "BTCC";
                    return true;
                case "2":
                    result[0] = "British GT";
                    return true;
                case "3":
                    result[0] = "GT Cup";
                    return true;
                case "4":
                    result[0] = "British Endurance";
                    return true;
                case "5":
                    result[0] = "World GT";
                    return true;
                case "6":
                    result[0] = "F1";
                    return true;
                case "7":
                    result[0] = "WEC";
                    return true;
                case "0":
                    result[0] = "Other";
                    return true;
                default:
                    return false;
            }
        }

        private int convertTrack(ref string[] result, string track)
        {
            switch (track)
            {
                case "1":
                    result[1] = "Brands Hatch";
                    return true;
                case "2":
                    result[1] = "Donington Park";
                    return true;
                case "3":
                    result[1] = "Oulton Park";
                    return true;
                case "4":
                    result[1] = "Snetterton";
                    return true;
                case "5":
                    result[1] = "Silverstone";
                    return true;
                case "6":
                    result[1] = "Cadwell";
                    return true;
                case "7":
                    result[1] = "Thruxton";
                    return true;
                case "8":
                    result[1] = "Croft";
                    return true;
                case "9":
                    result[1] = "Knockhill";
                    return true;
                case "0":
                    result[1] = "Other / Outside Uk";
                    return true;
                default:
                    return false;
            }
        }

        private int convertMonth(ref string[] result, string month)
        {

            switch (month)
            {
                case "A":
                    result[2] = "January";
                    return true;
                case "B":
                    result[2] = "February";
                    return true;
                case "C":
                    result[2] = "March";
                    return true;
                case "D":
                    result[2] = "April";
                    return true;
                case "E":
                    result[2] = "May";
                    return true;
                case "F":
                    result[2] = "June";
                    return true;
                case "G":
                    result[2] = "July";
                    return true;
                case "H":
                    result[2] = "August";
                    return true;
                case "I":
                    result[2] = "September";
                    return true;
                case "J":
                    result[2] = "October";
                    return true;
                case "K":
                    result[2] = "November ";
                    return true;
                case "L":
                    result[2] = "December";
                    return true;
                default:
                    return false;
            }
        }

        private int convertYear(ref string[] result, string year)
        {

            switch (year)
            {
                case "22":
                    result[3] = "2022";
                    return true;
                case "23":
                    result[3] = "2023";
                    return true;
                case "24":
                    result[3] = "2024";
                    return true;
                case "25":
                    result[3] = "2025";
                    return true;
                case "26":
                    result[3] = "2026";
                    return true;
                case "27":
                    result[3] = "2027";
                    return true;
                case "28":
                    result[3] = "2028";
                    return true;
                case "29":
                    result[3] = "2029";
                    return true;
                case "30":
                    result[3] = "2030";
                    return true;
                case "31":
                    result[3] = "2031";
                    return true;
                case "32":
                    result[3] = "2032";
                    return true;
                case "33":
                    result[3] = "2033";
                    return true;
                case "34":
                    result[3] = "2034";
                    return true;
                case "35":
                    result[3] = "2035";
                    return true;
                default:
                    return false;
            }
        }
    }
}
