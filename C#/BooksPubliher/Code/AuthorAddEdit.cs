using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksPublish
{
    public partial class AuthorAddEdit : Form
    {
        private int _authorId;

        public AuthorAddEdit()
        {
            InitializeComponent();
            _authorId = -1;
        }
        public AuthorAddEdit(int authorId)
        {
            this._authorId = authorId;
            InitializeComponent();
            LoadAuthorData();
        }

        private void LoadAuthorData()
        {
            using(var context = new BooksPublishDbContext())
            {
                Author author = context.Authors.Find(_authorId);
                if (author != null)
                {
                    TBFName.Text = author.FirstName;
                    TBLName.Text = author.LastName;
                }
            }
        }

        private void SaveAuthor()
        {
            using(var context = new BooksPublishDbContext())
            {
                if(_authorId == -1)
                {
                    Author newAuthor = new Author()
                    {
                        FirstName = TBFName.Text,
                        LastName = TBLName.Text,
                    };

                    context.Authors.Add(newAuthor);
                }
                else
                {
                    Author editAuthor = context.Authors.Find(_authorId);
                    if (editAuthor != null)
                    {
                        editAuthor.FirstName = TBFName.Text;
                        editAuthor.LastName = TBLName.Text;
                    }
                }
                context.SaveChanges();
            }
        }

        private bool ValidateValue()
        {
            return !string.IsNullOrWhiteSpace(TBLName.Text) && !string.IsNullOrWhiteSpace(TBLName.Text);
        }


        private void BEnter_Click(object sender, EventArgs e)
        {
            if (ValidateValue())
            {
                SaveAuthor();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка данных.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
