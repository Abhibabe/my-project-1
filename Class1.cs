using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Class1
    {

        

        static void Main(string[] args)
        {
            int n;//942
            int max = 0;
            Console.WriteLine("Enter the Num");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int r = n % 10;//2
                if (max < r)
                {
                    max = r;
                }

                n = n / 10;// n=94


            }



            Console.WriteLine(max);
        }
    }
}
