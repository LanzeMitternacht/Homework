using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersShop
{
    public partial class SellProduct : Form
    {
        string sConnection = "Server = Lanze; Database = FlowerShop; Trusted_Connection = True";
        int iId;

        public SellProduct(int id)
        {
            InitializeComponent();
            iId = id;
        }

        private void BSell_Click(object sender, EventArgs e)
        {
            string sSql = $"SELECT * FROM Products WHERE Id = {iId}";
            string sName = null;
            string sType = null;
            int iPrice = 0;

            int iCountVisit = 0;
            bool bDiscount = false;


            int iCount = 0;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sSql, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sName = reader.GetValue(1).ToString();
                        sType = reader.GetValue(2).ToString();
                        iPrice = Convert.ToInt32(reader.GetValue(3));
                        iCount = (int)reader.GetValue(4);
                    }
                    if(iCount < Convert.ToInt32(TBCount.Text))
                    {
                        MessageBox.Show("Количество купленного превышается товара в наличии", "Ошибка");
                        return;
                    }

                    iCount = iCount - Convert.ToInt32(TBCount.Text);
                }
                sSql = $"UPDATE Products SET Count = '{iCount}' WHERE Id = {iId}";
                sqlCommand.CommandText = sSql;
                sqlCommand.ExecuteNonQuery();
                sSql = $"INSERT INTO Archive VALUES('{sName}', '{sType}', '{iPrice}', '{Convert.ToInt32(TBCount.Text)}', '{Convert.ToInt32(TBVisitor.Text)}', '{Convert.ToInt32(TBStaff.Text)}')";
                sqlCommand.CommandText = sSql;
                sqlCommand.ExecuteNonQuery();

                iId = Convert.ToInt32(TBVisitor.Text);
                sSql = $"SELECT * FROM Visitors WHERE Id = {iId}";
                sqlCommand.CommandText = sSql;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        iId = (int)reader.GetValue(0);
                        iCountVisit = (int)reader.GetValue(3);
                        bDiscount = Convert.ToBoolean(reader.GetValue(4));
                    }
                    iCountVisit++;
                    if (iCountVisit > 5)
                        bDiscount = true;

                }
                sSql = $"UPDATE Visitors SET CountVisit = '{iCountVisit}', Discount = '{bDiscount}' WHERE Id = {iId}";
                sqlCommand.CommandText = sSql;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBVisitor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
