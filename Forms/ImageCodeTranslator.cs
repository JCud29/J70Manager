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
                    TBCode.ForeColor = Color.Red;
                    MessageBox.Show("That code was invalid, please try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                TBCode.ForeColor = Color.Red;
                MessageBox.Show("That code was invalid, please try again", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convertCode()
        {
            //maybe change to char array
            string code = TBCode.Text.ToString();
            string championshipCode = code.Substring(0, 1);
            string trackCode = code.Substring(1, 1);
            string monthCode = code.Substring(2, 1).ToUpper();
            string yearCode = code.Substring(3);
            string[] result = new string[4];

            convertChampionship(ref result, championshipCode);
            int i = 0;
        }

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
                default:
                    return 0;
            }
        }
    }
}
