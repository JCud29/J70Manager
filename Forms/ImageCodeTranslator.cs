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
            resultData result = new resultData();
            string[] result1 = new string[4]; // I would make this a model like
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
                            if (TBCode.Text.Length > 5)
                            {
                                result.imageNumber = TBCode.Text.Substring(5);
                            }
                            else
                            {
                                result.imageNumber = "";
                            }
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

        private void outputResult(resultData result)
        {
            TBChampionship.Text = result.championship;
            TBTrack.Text = result.track;
            TBMonth.Text = result.month;
            TBYear.Text = result.year;
            TBImage.Text = result.imageNumber;

        }

        //maybe add a map for following methods
        private bool convertChampionship(ref resultData result, string championship)
        {
            switch (championship)
            {
                case "1":
                    result.championship = "BTCC";
                    return true;
                case "2":
                    result.championship = "British GT";
                    return true;
                case "3":
                    result.championship = "GT Cup";
                    return true;
                case "4":
                    result.championship = "British Endurance";
                    return true;
                case "5":
                    result.championship = "World GT";
                    return true;
                case "6":
                    result.championship = "F1";
                    return true;
                case "7":
                    result.championship = "WEC";
                    return true;
                case "0":
                    result.championship = "Other";
                    return true;
                default:
                    return false;
            }
        }

        private bool convertTrack(ref resultData result, string track)
        {
            switch (track)
            {
                case "1":
                    result.track = "Brands Hatch";
                    return true;
                case "2":
                    result.track = "Donington Park";
                    return true;
                case "3":
                    result.track = "Oulton Park";
                    return true;
                case "4":
                    result.track = "Snetterton";
                    return true;
                case "5":
                    result.track = "Silverstone";
                    return true;
                case "6":
                    result.track = "Cadwell";
                    return true;
                case "7":
                    result.track = "Thruxton";
                    return true;
                case "8":
                    result.track = "Croft";
                    return true;
                case "9":
                    result.track = "Knockhill";
                    return true;
                case "0":
                    result.track = "Other / Outside Uk";
                    return true;
                default:
                    return false;
            }
        }

        private bool convertMonth(ref resultData result, string month)
        {

            switch (month)
            {
                case "A":
                    result.month = "January";
                    return true;
                case "B":
                    result.month = "February";
                    return true;
                case "C":
                    result.month = "March";
                    return true;
                case "D":
                    result.month = "April";
                    return true;
                case "E":
                    result.month = "May";
                    return true;
                case "F":
                    result.month = "June";
                    return true;
                case "G":
                    result.month = "July";
                    return true;
                case "H":
                    result.month = "August";
                    return true;
                case "I":
                    result.month = "September";
                    return true;
                case "J":
                    result.month = "October";
                    return true;
                case "K":
                    result.month = "November ";
                    return true;
                case "L":
                    result.month = "December";
                    return true;
                default:
                    return false;
            }
        }

        private bool convertYear(ref resultData result, string year)
        {

            switch (year)
            {
                case "22":
                    result.year = "2022";
                    return true;
                case "23":
                    result.year = "2023";
                    return true;
                case "24":
                    result.year = "2024";
                    return true;
                case "25":
                    result.year = "2025";
                    return true;
                case "26":
                    result.year = "2026";
                    return true;
                case "27":
                    result.year = "2027";
                    return true;
                case "28":
                    result.year = "2028";
                    return true;
                case "29":
                    result.year = "2029";
                    return true;
                case "30":
                    result.year = "2030";
                    return true;
                case "31":
                    result.year = "2031";
                    return true;
                case "32":
                    result.year = "2032";
                    return true;
                case "33":
                    result.year = "2033";
                    return true;
                case "34":
                    result.year = "2034";
                    return true;
                case "35":
                    result.year = "2035";
                    return true;
                default:
                    return false;
            }
        }
    }

    class resultData
    {
        public string championship;
        public string track;
        public string month;
        public string year;
        public string imageNumber;
    }
}
