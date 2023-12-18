using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextEditor
{
    public partial class TextEditorMain : Form
    {
        bool flag = false;
        public TextEditorMain()
        {
            InitializeComponent();
            FileInfo fileInfo = new FileInfo(Name);
            Text = fileInfo.FullName;
        }
        private void OwnMenuColor_Click(object sender, EventArgs e)
        {
            OwnColor ownColor = new OwnColor(RTBMain.BackColor.R, RTBMain.BackColor.G, RTBMain.BackColor.B);
            if (ownColor.ShowDialog() == DialogResult.OK)
            {
                RTBMain.BackColor = Color.FromArgb(ownColor.GetRed(), ownColor.GetGreen(), ownColor.GetBlue());
                flag = true;
            }
        }

        private void OwnTextColor_Click(object sender, EventArgs e)
        {
            OwnColor ownColor = new OwnColor(RTBMain.ForeColor.R, RTBMain.ForeColor.G, RTBMain.ForeColor.B);
            if (ownColor.ShowDialog() == DialogResult.OK)
            {
                RTBMain.ForeColor = Color.FromArgb(ownColor.GetRed(), ownColor.GetGreen(), ownColor.GetBlue());
                flag = true;
            }
        }

        private void ColorText_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RTBMain.ForeColor = colorDialog.Color;
                flag = true;
                
            }
        }

        private void ColorMenu_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RTBMain.BackColor = colorDialog.Color;
                flag = true;
            }
        }

        private void OwnMenuFont_Click(object sender, EventArgs e)
        {
            OwnFont ownFont = new OwnFont(Convert.ToInt32(RTBMain.Font.Size), RTBMain.Font.Name);
            if (ownFont.ShowDialog() == DialogResult.OK)
            {
                RTBMain.SelectionFont = new Font(ownFont.GetFontName(), ownFont.GetFontSize());
                flag = true;
            }
        }

        private void FontMenu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                RTBMain.Font = fontDialog.Font;
                flag = true;
            }
        }

        private void MFileOpen_Click(object sender, EventArgs e)
        {
            FDOpen.FileName = "";
            FDOpen.InitialDirectory = "C:\\";
            if (flag)
            {
               DialogResult dialogResult = MessageBox.Show("Сохранить изменения?","Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MFileSave_Click(sender, e);
                    if (!flag && FDOpen.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = new StreamReader(FDOpen.FileName);
                        RTBMain.Clear();
                        RTBMain.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    if (FDOpen.ShowDialog() == DialogResult.OK)
                    {
                        flag = false;
                        StreamReader sr = new StreamReader(FDOpen.FileName);
                        RTBMain.Clear();
                        RTBMain.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            else
            {
                if (FDOpen.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(FDOpen.FileName);
                    RTBMain.Clear();
                    RTBMain.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            
        }

        private void MFileSave_Click(object sender, EventArgs e)
        {
            FDSave.Filter = "Текстовые документы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            FDSave.FileName = "*.txt";
            FDSave.FilterIndex = 1;
            FDSave.RestoreDirectory = true;

            if (FDSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(FDSave.FileName);
                sw.Write(RTBMain.Text);
                sw.Close();
                flag = false;
            }
            
        }
        private void RTBMain_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        private void MFileNew_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MFileSave_Click(sender, e);
                    if (!flag)
                    {
                        RTBMain.Clear();
                        RTBMain.Font = new Font("Arial", 12);
                        RTBMain.BackColor = Color.White;
                        RTBMain.ForeColor = Color.Black;
                        flag = false;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    flag = false;
                    RTBMain.Clear();
                    RTBMain.Font = new Font("Arial", 12);
                    RTBMain.BackColor = Color.White;
                    RTBMain.ForeColor = Color.Black;
                }
            }
            else
            {
                RTBMain.Clear();
                RTBMain.Font = new Font("Arial", 12);
                RTBMain.BackColor = Color.White;
                RTBMain.ForeColor = Color.Black;
            }

        }

        private void InfoProg_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("ProgramInfo.html");
            Process.Start(fileInfo.FullName);
        }
    }
}
