using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clicker : Form
    {
        int count = 0;
        public Clicker()
        {
            InitializeComponent();
        }

        private void BCLick_Click(object sender, EventArgs e)
        {
            if(count != 10) {
                count++;
                LNumber.Text = count.ToString();
            }
            else
            {
                BCLick.BackColor = Color.Black;
            }
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            count = 0;
            BCLick.BackColor = SystemColors.Control;
            LNumber.Text = count.ToString();
        }
    }
}
