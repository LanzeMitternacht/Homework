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
    public partial class PublisherAddEdit : Form
    {
        private int _publisherId;
        public PublisherAddEdit()
        {
            InitializeComponent();
            _publisherId = -1;
        }
        public PublisherAddEdit(int publisherId)
        {
            InitializeComponent();
            _publisherId = publisherId;
            LoadPublisher();
        }

        private void LoadPublisher()
        {
            using(var context = new BooksPublishDbContext())
            {
                Publisher publisher = context.Publishers.Find(_publisherId);
                if(publisher != null)
                {
                    TBPublisher.Text = publisher.PublisherName;
                    TBAddress.Text = publisher.Address;
                }
            }
        }

        private void SavePublisher()
        {
            using(var context = new BooksPublishDbContext()) 
            { 
                if(_publisherId == -1)
                {
                    Publisher newPublisher = new Publisher()
                    {
                        PublisherName = TBPublisher.Text,
                        Address = TBAddress.Text,
                    };

                    context.Publishers.Add(newPublisher);
                }
                else
                {
                    Publisher editPublisher = context.Publishers.Find(_publisherId); 
                    if(editPublisher != null)
                    {
                        editPublisher.PublisherName = TBPublisher.Text;
                        editPublisher.Address = TBAddress.Text;
                    }
                 
                }
                context.SaveChanges();
            }
        }

        private bool ValidateValue()
        {
            return !string.IsNullOrWhiteSpace(TBPublisher.Text) && !string.IsNullOrWhiteSpace(TBAddress.Text);
        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            if (ValidateValue())
            {
                SavePublisher();
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
