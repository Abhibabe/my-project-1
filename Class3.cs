using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class BookName
    {
        string author;
        int price;
        string name;
        public string Author
        {
            set { author = value; }
            get { return author; }

        }
    
        public int Price
        {

            set { price = value; }
            get { return price; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        static void Main(string[] args)
        {
            BookName b = new BookName();

            b.Author = "ramnivas";
            b.Price = 98;
            b.Name = "Jaiho";
            Console.WriteLine(b.price);
            Console.WriteLine(b.price);
            Console.WriteLine(b.Name);

        }

    
    }

        
}
