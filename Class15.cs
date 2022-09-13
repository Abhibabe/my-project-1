using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class BookDemo
    {
       

       
        static void Main(string[]args)
        {
            Book B = new Book("Devloping java software", "Russesl Windeard", 79.66);
            Console.WriteLine("title:"+B.Name + "n\author:"+B.Author +"\nprice:"+B.Price);

        }

    }
}
