using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        ContextMenuStrip menuStrip;
        public Form1()
        {
            InitializeComponent();
            BMenuGroup.Text = "Группа";
        }
        private void BMenuGroup_Click(object sender, EventArgs e)
        {
            menuStrip.Show(BMenuGroup, new Point(0, BMenuGroup.Height));
        }

        private void CMGroup_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Группа")
            {
                BMenuGroup.Text = $"{e.ClickedItem.Text}";
            }
            else if (e.ClickedItem.Text == "Студент")
            {
                BMenuGroup.Text = $"{e.ClickedItem.Text}";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip = new ContextMenuStrip();
            menuStrip.Items.Add("Группа");
            menuStrip.Items.Add("Студент");
            menuStrip.ItemClicked += new ToolStripItemClickedEventHandler(CMGroup_ItemClicked);
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (TBNew.Text == "")
            {
                LError.Text = "Поле добавление пустое";
            }
            else
            {
                if (BMenuGroup.Text == "Группа")
                {
                    TVMain.Nodes.Add(new TreeNode(TBNew.Text));
                    TBNew.Clear();
                }
                else if (TVMain.SelectedNode != null && BMenuGroup.Text == "Студент")
                {
                    TVMain.SelectedNode.Nodes.Add(TBNew.Text);
                    TBNew.Clear();
                }
                else
                {
                    LError.Text = "Не выбрана группа для добавление студента";
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if(TVMain.Nodes.Count != 0 && TVMain.SelectedNode != null)
            {
                TVMain.SelectedNode.Remove();
            }
            else
            {
                LError.Text = "Не выбран элемент для удаления";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

