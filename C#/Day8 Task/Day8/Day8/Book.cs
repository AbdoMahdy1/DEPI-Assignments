using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Book
    {
        public string? Title {  get; set; }
        public string? Author {  get; set; }

        public Book()
        {
            Title = default;
            Author = default;
        }

        public Book(string title)
        {
            Title = title;
            Author = default;
        }

        public Book(string title, string auther)
        {
            Title = title;
            Author = auther;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
