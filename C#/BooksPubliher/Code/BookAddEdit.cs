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
    public partial class BookAddEdit : Form
    {
        private int _bookId;
        public BookAddEdit()
        {
            InitializeComponent();
            _bookId = -1;
        }
        public BookAddEdit(int bookId)
        {
            _bookId = bookId;
            InitializeComponent();
            LoadBookData();
        }

        private void LoadBookData()
        {
            using(var context = new BooksPublishDbContext())
            {
                Book book = context.Books.Find(_bookId);
                if (book != null)
                {
                    TBName.Text = book.Title;
                    TBIdAutor.Text = book.IdAuthor.ToString();
                    TBCountPages.Text = book.Pages.ToString();
                    TBPriceBook.Text = book.Price.ToString();
                    TBPunisher.Text = book.IdPublisher.ToString();
                }
            }
        }

        private void SaveBook()
        {
            using (var context = new BooksPublishDbContext())
            {
                if (_bookId == -1)
                {
                    Book newBook = new Book()
                    {
                        Title = TBName.Text,
                        IdAuthor = Convert.ToInt32(TBIdAutor.Text),
                        Pages = Convert.ToInt32(TBCountPages.Text),
                        Price = Convert.ToInt32(TBPriceBook.Text),
                        IdPublisher = Convert.ToInt32(TBPunisher.Text)
                    };

                   context.Books.Add(newBook);
                }
                else
                {
                    Book editBook = context.Books.Find(_bookId);
                    if (editBook != null)
                    {
                        editBook.Title = TBName.Text;
                        editBook.IdAuthor = Convert.ToInt32(TBIdAutor.Text);
                        editBook.Pages = Convert.ToInt32(TBCountPages.Text);
                        editBook.Price = Convert.ToInt32(TBPriceBook.Text);
                        editBook.IdPublisher = Convert.ToInt32(TBPunisher.Text);
                    }
                }
                context.SaveChanges();
            }
        }



        private bool ValidateValue()
        {
            return !string.IsNullOrEmpty(TBName.Text) && int.TryParse(TBIdAutor.Text, out _)
                && int.TryParse(TBCountPages.Text, out _)
                && int.TryParse(TBPriceBook.Text, out _)
                && int.TryParse(TBPunisher.Text, out _);
        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            if (ValidateValue())
            {
                SaveBook();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
