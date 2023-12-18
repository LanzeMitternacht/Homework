using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class OwnFont : Form
    {
        int FontSize;
        string FontName;
        public OwnFont(int font, string fontName)
        {
            InitializeComponent();
            TBNumber.Text = font.ToString();
            LBFont.Items.Add(fontName);
            LBFont.SelectedIndex = 0;
            AddFontName();
        }
        private void AddFontName()
        {
            LBFont.Items.Add("Arial");
            LBFont.Items.Add("Calibri");
            LBFont.Items.Add("Goudy Old Style");
            LBFont.Items.Add("Times New Roman");
            LBFont.Items.Add("Monotype Corsiva");
        }

        public int GetFontSize()
        {
            return FontSize;
        }
        public string GetFontName()
        {
            return FontName;
        }
        private void BOk_Click(object sender, EventArgs e)
        {

            FontSize = Convert.ToInt32(TBNumber.Text);
            FontName = LBFont.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void TBNumber_TextChanged(object sender, EventArgs e)
        {
            if (TBNumber.Text == "")
                TBNumber.Text = "3";
            else if (TBNumber.Text.Any(x => char.IsLetter(x) || char.IsSeparator(x) || char.IsPunctuation(x) || char.IsSymbol(x)))
                TBNumber.Text = "3";
            else if (Convert.ToInt32(TBNumber.Text) >= 256)
                TBNumber.Text = "255";
        }
    }
}
