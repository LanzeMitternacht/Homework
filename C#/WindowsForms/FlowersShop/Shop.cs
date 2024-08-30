using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;


namespace FlowersShop
{
    public partial class Shop : Form
    {
        string sConnection = "Server = Lanze; Database = FlowerShop; Trusted_Connection = True";//"Data Source = LANZE; Initial Catalog = FlowerShop; User = Lanze; Password = emma123";

        DataSet dataSet;
        SqlDataAdapter sqlAdapter;
        public Shop()
        {
            InitializeComponent();
            LoadDataProduct();
        }

        private void LoadDataProduct()
        {
            DataGridVShop.DataSource = null;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM Products";
                sqlAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataSet = new DataSet();
                sqlAdapter.Fill(dataSet);
                DataGridVShop.DataSource = dataSet.Tables[0];
                DataGridVShop.ReadOnly = true;
                DataGridVShop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridVShop.AllowUserToAddRows = false;
                DataGridVShop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                int iCount = DataGridVShop.Columns.Count;
                CBSearch.Items.Clear();
                for (int i = 0; i < iCount; i++)
                    CBSearch.Items.Add(DataGridVShop.Columns[i].Name);
            }
        }
        private void LoadDataArchive()
        {
            DataGridArch.DataSource = null;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM Archive";
                sqlAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataSet = new DataSet();
                sqlAdapter.Fill(dataSet);
                DataGridArch.DataSource = dataSet.Tables[0];
                DataGridArch.ReadOnly = true;
                DataGridArch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridArch.AllowUserToAddRows = false;
                DataGridArch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                int iCount = DataGridArch.Columns.Count;
                CBSearch.Items.Clear();
                for (int i = 0; i < iCount; i++)
                    CBSearch.Items.Add(DataGridArch.Columns[i].Name);
            }
        }
        private void LoadDataStaff()
        {
            DataGridVStaff.DataSource = null;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM Staff";
                sqlAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataSet = new DataSet();
                sqlAdapter.Fill(dataSet);
                DataGridVStaff.DataSource = dataSet.Tables[0];
                DataGridVStaff.ReadOnly = true;
                DataGridVStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridVStaff.AllowUserToAddRows = false;
                DataGridVStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                int iCount = DataGridVStaff.Columns.Count;
                CBSearch.Items.Clear();
                for (int i = 0; i < iCount; i++)
                    CBSearch.Items.Add(DataGridVStaff.Columns[i].Name);
            }
        }
        private void LoadDataVisitors()
        {
            DataGirdVVisitor.DataSource = null;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM Visitors";
                sqlAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataSet = new DataSet();
                sqlAdapter.Fill(dataSet);
                DataGirdVVisitor.DataSource = dataSet.Tables[0];
                DataGirdVVisitor.ReadOnly = true;
                DataGirdVVisitor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGirdVVisitor.AllowUserToAddRows = false;
                DataGirdVVisitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                int iCount = DataGirdVVisitor.Columns.Count;
                CBSearch.Items.Clear();
                for (int i = 0; i < iCount; i++)
                    CBSearch.Items.Add(DataGirdVVisitor.Columns[i].Name);
            }
        }

        private void BAddProd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            if (addProduct.ShowDialog() == DialogResult.OK)
                LoadDataProduct();
        }

        private void BAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff newGuy = new AddStaff();
            if (newGuy.ShowDialog() == DialogResult.OK)
                LoadDataStaff();

        }

        private void BAddVisitor_Click(object sender, EventArgs e)
        {
            AddVisitor addVisitor = new AddVisitor();
            if (addVisitor.ShowDialog() == DialogResult.OK)
                LoadDataVisitors();
        }

        private void BEditProd_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Products WHERE Id = {DataGridVShop.SelectedCells[0].Value}";
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                AddProduct addProduct = new AddProduct(true, reader);
                if (addProduct.ShowDialog() == DialogResult.OK)
                    LoadDataProduct();
            }
        }

        private void BEditStaff_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Staff WHERE Id = {DataGridVStaff.SelectedCells[0].Value}";
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                AddStaff addStaff = new AddStaff(true, reader);
                if (addStaff.ShowDialog() == DialogResult.OK)
                    LoadDataStaff();
            }
        }

        private void BEditVisitor_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Visitors WHERE Id = {DataGirdVVisitor.SelectedCells[0].Value}";
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                AddVisitor addVisitor = new AddVisitor(true, reader);
                if (addVisitor.ShowDialog() == DialogResult.OK)
                    LoadDataVisitors();
            }
        }

        private void TabCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabCMain.SelectedIndex == 0)
                LoadDataProduct();
            else if (TabCMain.SelectedIndex == 1)
                LoadDataArchive();
            else if (TabCMain.SelectedIndex == 2)
                LoadDataStaff();
            else if (TabCMain.SelectedIndex == 3)
                LoadDataVisitors();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            string sSql;
            int iIndex;
            int iId;
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand;
                if (TabCMain.SelectedIndex == 0)
                {
                    iIndex = DataGridVShop.SelectedRows[0].Index;
                    iId = Convert.ToInt32(DataGridVShop[0, iIndex].Value.ToString());

                    sSql = $"DELETE {TabCMain.SelectedTab.Name} WHERE Id = {iId}";
                    sqlCommand = new SqlCommand(sSql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    DataGridVShop.DataSource = null;
                    LoadDataProduct();
                }
                else if (TabCMain.SelectedIndex == 1)
                {
                    iIndex = DataGridArch.SelectedRows[0].Index;
                    iId = Convert.ToInt32(DataGridArch[0, iIndex].Value.ToString());

                    sSql = $"DELETE {TabCMain.SelectedTab.Name} WHERE Id = {iId}";
                    sqlCommand = new SqlCommand(sSql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    DataGridArch.DataSource = null;
                    LoadDataArchive();
                }
                else if (TabCMain.SelectedIndex == 2)
                {
                    iIndex = DataGridVStaff.SelectedRows[0].Index;
                    iId = Convert.ToInt32(DataGridVStaff[0, iIndex].Value.ToString());

                    sSql = $"DELETE {TabCMain.SelectedTab.Name} WHERE Id = {iId}";
                    sqlCommand = new SqlCommand(sSql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    DataGridVStaff.DataSource = null;
                    LoadDataStaff();
                }
                else if (TabCMain.SelectedIndex == 3)
                {
                    iIndex = DataGirdVVisitor.SelectedRows[0].Index;
                    iId = Convert.ToInt32(DataGirdVVisitor[0, iIndex].Value.ToString());

                    sSql = $"DELETE {TabCMain.SelectedTab.Name} WHERE Id = {iId}";
                    sqlCommand = new SqlCommand(sSql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    DataGirdVVisitor.DataSource = null;
                    LoadDataVisitors();
                }
            }
        }

        private void BSell_Click(object sender, EventArgs e)
        {
            int iIndex = DataGridVShop.SelectedRows[0].Index;
            int iId = Convert.ToInt32(DataGridVShop[0, iIndex].Value.ToString());
            SellProduct sellProduct = new SellProduct(iId);
            if (sellProduct.ShowDialog() == DialogResult.OK)
                LoadDataProduct();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTest_Click(object sender, EventArgs e)
        {
            string sSql = $"SELECT * FROM {TabCMain.SelectedTab.Name} WHERE {CBSearch.Text} LIKE '%{TBSearch.Text}%'";
            using (SqlConnection sqlConnection = new SqlConnection(sConnection))
            {
                sqlConnection.Open();
                if (TabCMain.SelectedIndex == 0)
                {
                    DataGridVShop.DataSource = null;
                    sqlAdapter = new SqlDataAdapter(sSql, sqlConnection);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    DataGridVShop.DataSource = dataSet.Tables[0];
                    DataGridVShop.ReadOnly = true;
                    DataGridVShop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridVShop.AllowUserToAddRows = false;
                    DataGridVShop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataGridVShop.Update();
                }else if(TabCMain.SelectedIndex == 1)
                {
                    DataGridArch.DataSource = null;
                    sqlAdapter = new SqlDataAdapter(sSql, sqlConnection);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    DataGridArch.DataSource = dataSet.Tables[0];
                    DataGridArch.ReadOnly = true;
                    DataGridArch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridArch.AllowUserToAddRows = false;
                    DataGridArch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataGridArch.Update();
                }
                else if (TabCMain.SelectedIndex == 2)
                {
                    DataGridVStaff.DataSource = null;
                    sqlAdapter = new SqlDataAdapter(sSql, sqlConnection);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    DataGridVStaff.DataSource = dataSet.Tables[0];
                    DataGridVStaff.ReadOnly = true;
                    DataGridVStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGridVStaff.AllowUserToAddRows = false;
                    DataGridVStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataGridVStaff.Update();
                }
                else if(TabCMain.SelectedIndex == 3)
                {
                    DataGirdVVisitor.DataSource = null;
                    sqlAdapter = new SqlDataAdapter(sSql, sqlConnection);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    DataGirdVVisitor.DataSource = dataSet.Tables[0];
                    DataGirdVVisitor.ReadOnly = true;
                    DataGirdVVisitor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DataGirdVVisitor.AllowUserToAddRows = false;
                    DataGirdVVisitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataGirdVVisitor.Update();
                }


            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream($"D:\\VS Studio\\FlowersShop\\Table\\{TabCMain.SelectedTab.Name}.pdf", FileMode.Create));
            document.Open();

            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            
            for(int i = 0; i < dataSet.Tables.Count; i++)
            {
                PdfPTable table = new PdfPTable(dataSet.Tables[i].Columns.Count);

                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase($"БД {TabCMain.SelectedTab.Name} таблица № {i+1}", font));
                cell.Colspan = dataSet.Tables[i].Columns.Count;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                table.AddCell(cell);

                for(int j = 0; j < dataSet.Tables[i].Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(new Phrase(dataSet.Tables[i].Columns[j].ColumnName, font)));
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }
                for(int  j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < dataSet.Tables[i].Columns.Count; k++)
                        table.AddCell(new Phrase(dataSet.Tables[i].Rows[j][k].ToString(), font));
                }
                document.Add(table);
            }
            document.Close();
        }
    }
}
