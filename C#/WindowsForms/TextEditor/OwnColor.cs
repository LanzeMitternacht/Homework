using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class OwnColor : Form
    {
        int colorRed = 0;
        int colorGreen = 0;
        int colorBlue = 0;
        public OwnColor(int red, int green, int blue)
        {
            InitializeComponent();
            colorRed = red; colorGreen = green; colorBlue = blue;
            TrackR.Value = red; TrackG.Value = green; TrackB.Value = blue;
            RTBCheckColor.BackColor = Color.FromArgb(red, green, blue);
            TBRed.Text = red.ToString(); TBGreen.Text = green.ToString(); TBBlue.Text = blue.ToString();
        }

        private void TrackR_Scroll(object sender, EventArgs e)
        {
            colorRed = TrackR.Value;
            RTBCheckColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            TBRed.Text = TrackR.Value.ToString();
        }
        private void TrackG_Scroll(object sender, EventArgs e)
        {
            colorGreen = TrackG.Value;
            RTBCheckColor.BackColor = Color.FromArgb(colorRed,colorGreen, colorBlue);
            TBGreen.Text = TrackR.Value.ToString();
        }
        private void TrackB_Scroll(object sender, EventArgs e)
        {
            colorBlue = TrackB.Value;
            RTBCheckColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            TBBlue.Text = TrackR.Value.ToString();
        }

        private void TBRed_TextChanged(object sender, EventArgs e)
        {
            if (TBRed.Text == "")
                TBRed.Text = "0";
            else if (Convert.ToInt32(TBRed.Text) > 255)
                TBRed.Text = "255";

            colorRed = Convert.ToInt32(TBRed.Text);
            RTBCheckColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            TrackR.Value = Convert.ToInt32(TBRed.Text);
        }
        private void TBGreen_TextChanged(object sender, EventArgs e)
        {
            if (TBGreen.Text == "")
                TBGreen.Text = "0";
            else if (Convert.ToInt32(TBGreen.Text) > 255)
                TBGreen.Text = "255";

            colorGreen = Convert.ToInt32(TBGreen.Text);
            RTBCheckColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            TrackG.Value = Convert.ToInt32(TBGreen.Text);
        }

        private void TBBlue_TextChanged(object sender, EventArgs e)
        {
            if (TBBlue.Text == "")
                TBBlue.Text = "0";
            else if (Convert.ToInt32(TBBlue.Text) > 255)
                TBBlue.Text = "255";

            colorBlue = Convert.ToInt32(TBBlue.Text);
            RTBCheckColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            TrackB.Value = Convert.ToInt32(TBBlue.Text);
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public int GetRed()
        {
            return colorRed;
        }
        public int GetGreen()
        {
            return colorGreen;
        }
        public int GetBlue()
        {
            return colorBlue;
        }
    }
}
