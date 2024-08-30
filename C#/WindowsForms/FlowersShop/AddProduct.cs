using BarcodeStandard;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Converters;

namespace FlowersShop
{
    public partial class AddProduct : Form
    {
        string sConnection = "Server = Lanze; Database = FlowerShop; Trusted_Connection = True";//"Data Source = LANZE; Initial Catalog = FlowerShop; User = Lanze; Password = emma123";
        bool bEdit = false;
        int iId = 0;
        public AddProduct()
        {
            InitializeComponent();
            string[] sType = { "Цветы", "Декорации", "Садовая утварь" };
            foreach (string str in sType)
            {
                CBType.Items.Add(str);
            }
            CBType.SelectedIndex = 0;
        }
        public AddProduct(bool edit, SqlDataReader sqlData)
        {
            InitializeComponent();
            bEdit = edit;
            FormLoading(sqlData);
            string[] sType = { "Цветы", "Декорации", "Садовая утварь" };
            foreach (string str in sType)
            {
                CBType.Items.Add(str);
            }
            CBType.SelectedIndex = 0;
        }

        private void FormLoading(SqlDataReader sqlData)
        {
            using(sqlData)
            {
                while(sqlData.Read())
                {
                    iId = (int)sqlData.GetValue(0);
                    TBName.Text = sqlData.GetValue(1).ToString();
                    CBType.Text = sqlData.GetValue(2).ToString();
                    TBPrice.Text = sqlData.GetValue(3).ToString();
                    TBCount.Text = sqlData.GetValue(4).ToString();
                }
            }
        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            int iCount = Convert.ToInt32(TBCount.Text);
            string sqlExpression;
            if (!bEdit)
            {
                sqlExpression = $"INSERT INTO Products VALUES ('{TBName.Text}', '{CBType.Text}', '{Convert.ToInt32(TBPrice.Text)}', '{iCount}')";
                Barcode barcode = new Barcode();
                barcode.IncludeLabel = true;
                var sKImage = barcode.Encode(BarcodeStandard.Type.UpcA, "038000356216", SKColors.Black, SKColors.White, 290, 120);
                SKBitmap sKBitmap = new SKBitmap(sKImage.Info);
                FileStream fileStream = new FileStream($"D:\\VS Studio\\FlowersShop\\Barcode\\{TBName.Text}", FileMode.Create);
                var image = SKImage.FromBitmap(sKBitmap);
                var encodedImage = image.Encode();
                encodedImage.SaveTo(fileStream);
            }      
            else
                 sqlExpression = $"UPDATE Products SET Name = '{TBName.Text}', Type = '{CBType.Text}', Price = '{Convert.ToInt32(TBPrice.Text)}', Count = '{iCount}' WHERE Id = {iId}";
               
            if (TBName.Text == "" || iCount < 0)
                    return;

            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            
            Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
