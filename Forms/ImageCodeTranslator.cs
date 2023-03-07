using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J70Manager.Forms
{
    public partial class ImageCodeTranslator : Form
    {
        private readonly FileAccess _fileClient = new FileAccess();
        private readonly string _codesUrl = "..\\..\\PreviousCodes.txt";
        private List<string> _previousCodes = new List<string>();
        public ImageCodeTranslator()
        {
            InitializeComponent();
        }

        private void ImageCodeTranslator_Load(object sender, EventArgs e)
        {
            LoadPreviousCodes();
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
    }
}
