using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BooksPublish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        public int IdPublisher { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
