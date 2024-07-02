using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksPublish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksPublishDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.booksPublishDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksPublishDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.booksPublishDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksPublishDataSet.Author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.booksPublishDataSet.Author);

        }

        public void LoadBooks()
        {
            using (var context = new BooksPublishDbContext())
            {
                var books = context.Books.ToList();
                DGVBooks.DataSource = books;
            }
        }

        public void LoadAuthor()
        {
            using (var context = new BooksPublishDbContext())
            {
                var authors = context.Authors.ToList();
                DGVAuthor.DataSource = authors;
            }
        }

        public void LoadPublisher()
        {
            using(var context = new BooksPublishDbContext())
            {
                var publishers = context.Publishers.ToList();
                DGVPublisher.DataSource = publishers;
            }
        }

        private void BAddBook_Click(object sender, EventArgs e)
        {
            BookAddEdit bookAddEdit = new BookAddEdit();
            if(bookAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void BEditBook_Click(object sender, EventArgs e)
        {
            if (DGVBooks.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(DGVBooks.CurrentRow.Cells[0].Value);
                BookAddEdit bookAddEdit = new BookAddEdit(bookId);
                if (bookAddEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для редактирования.", "Выбор книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(DGVBooks.CurrentRow.Cells[0].Value);

            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить данную книгу?", "Подтвердите удаление", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new BooksPublishDbContext())
                {
                    var book = context.Books.Find(bookId);
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
                LoadBooks();
            }
        }

        private void BAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorAddEdit authorAddEdit = new AuthorAddEdit();
            if(authorAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadAuthor();
            }   
        }

        private void BEditAuthor_Click(object sender, EventArgs e)
        {
            if (DGVAuthor.SelectedRows.Count > 0)
            {
                int authorId = Convert.ToInt32(DGVAuthor.CurrentRow.Cells[0].Value);
                AuthorAddEdit authorAddEdit = new AuthorAddEdit(authorId);
                if (authorAddEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите автора для редактирования.", "Выбор автора", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BDeleteAuthor_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(DGVAuthor.CurrentRow.Cells[0].Value);

            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить данного автора?", "Подтвердите удаление", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                using(var context = new BooksPublishDbContext())
                {
                    var author = context.Authors.Find(authorId);
                    context.Authors.Remove(author);
                    context.SaveChanges();
                }
                LoadAuthor();
            }
        }

        private void BAddPunisher_Click(object sender, EventArgs e)
        {
            PublisherAddEdit punisherAddEdit = new PublisherAddEdit();
            if(punisherAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadPublisher();
            }
        }

        private void BEditPunisher_Click(object sender, EventArgs e)
        {
            if(DGVPublisher.SelectedRows.Count > 0)
            {
                int publisherId = Convert.ToInt32(DGVPublisher.CurrentRow.Cells[0].Value);

                PublisherAddEdit publisherAddEdit = new PublisherAddEdit(publisherId);
                if(publisherAddEdit.DialogResult == DialogResult.OK)
                {
                    LoadPublisher();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите издателя для редактирования.", "Выбор издателя", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BDeletePunisher_Click(object sender, EventArgs e)
        {
            int publisherId = Convert.ToInt32(DGVPublisher.CurrentRow.Cells[0].Value);

            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить даннного издателя?", "Подтвердите удаление", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                using(var context = new BooksPublishDbContext())
                {
                    var publisher = context.Publishers.Find(publisherId);
                    context.Publishers.Remove(publisher);
                    context.SaveChanges();
                }
                LoadPublisher();
            }
        }

        private void TabCnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabCnt.SelectedIndex == 0)
            {
                LoadBooks();
            }else if(TabCnt.SelectedIndex == 1)
            {
                LoadAuthor();
            }else if(TabCnt.SelectedIndex == 2)
            {
                LoadPublisher();
            }
        }
    }
}