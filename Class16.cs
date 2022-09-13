using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Book
    {
        string name;
        string author;
        double price;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
         public string Author
        {
            set { author = value;}
            get { return author; }
        }
        public double Price
        {
            set { price = value; }
            get { return price ; }
        }

        public Book(string name, string author, double price)
        {
            this.name= name;
            this.author = author;
            this.price = price;
        }
        public Book()
        {

        }
        static void Main(string []args)
        {
            Book b = new Book();
            b.Name = "janleva";
            b.Author = "Ramvilas";
            b.price = 78;
         
        }
    }  
}
