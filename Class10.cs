using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Method
    {
        public void methodNumber(int n, int d)
        {
            int s = 0;
            while (n > 0)
            {
                int x = n % 10;
                if (x == d)
                {
                    s += 1;

                }
                n = n / 10;
            }
            Console.WriteLine(s);
        }
         public void methodNumber(int n1)
        {
            int s = 0;
            while (n1 > 0)
            {
                int x = n1 % 10;
                if (x % 2 == 0)
                {
                    s = s + x;
                }
                n1 = n1 / 10;
            


            }
            Console.WriteLine(s);

          }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Method m1 = new Method();
            m1.methodNumber(a, b);


        
               }
        
     }
 }
