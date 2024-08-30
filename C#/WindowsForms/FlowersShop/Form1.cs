using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersShop
{
    public partial class Authentication : Form
    {
        string sConnection = "Server = Lanze; Database = FlowerShop; Trusted_Connection = True";
        public Authentication()
        {
            InitializeComponent();
        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM Staff WHERE FName = '{TBLogin.Text}'";
            if(TBLogin.Text == "" || TBPassword.Text == "")
                MessageBox.Show("Недопустимый логин/пароль", "Ошибка");
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(sConnection))
                {
                    object oPassword = null;
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while (sqlDataReader.Read())
                            oPassword = sqlDataReader.GetValue(3);

                        if (!VerifyHashedPassword(oPassword.ToString(), TBPassword.Text))
                        {
                            Shop shop = new Shop();
                            shop.ShowDialog();
                        }
                        else
                            MessageBox.Show("Пароли не совпадают", "Ошибка");

                    }
                }
            }
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return Equals(buffer3, buffer4);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BQrCode_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
        }
    }
}
