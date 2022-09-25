using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Book
    {
        string booktitle;
        string authorname;
        double price;
        public Book(string booktitle, string authorname, double price)
        {

        }
        public string Booktitle
        {
            set { booktitle = value; }
            get { return booktitle; }
        }
        public string Authorname
        {
            set { authorname = value; }
            get { return authorname; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
    class BookDemo
    {
        static void Main(string[] args)
        {
            Book b = new Book("Developing Java software","Rusel winderand",79.75);
            b.Booktitle = "Developing C sharp software";
            b.Authorname = "Russel winderand";
            b.Price = 79.75;
            Console.WriteLine(b.Booktitle);
        }
    }
}
