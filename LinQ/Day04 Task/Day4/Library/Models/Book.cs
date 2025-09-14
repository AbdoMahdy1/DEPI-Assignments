using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int? AuthorId {  get; set; }

        public Author Author { get; set; }

        public List<Loan> BookBorrowers { get; set; }
    }
}
