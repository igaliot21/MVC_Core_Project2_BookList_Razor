using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_Razor.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Avaibility { get; set; }
        public double Price { get; set; }

        public Book(){}
        public Book(string Title, string Author, string ISBN, int Avaibility, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.Avaibility = Avaibility;
            this.Price = Price;
        }
    }
}
