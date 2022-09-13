using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class BinaryCheck
    {
        public bool IsBinary(int num)
        {
            int c = 0;
            while (num > 0)
            {
                int x = num % 10;
                c++;
                if (x > 1)
                {
                    return false;
                }
                num = num / 10;

             
            
            }
            return true;
        }       
        static void Main(string[]args)
        {

            BinaryCheck b = new BinaryCheck();
            Console.WriteLine("Enter number check bianry or not ");
            int Num1 = int.Parse(Console.ReadLine());
            bool egf = b.IsBinary(Num1);
            if(egf)
            {
                Console.WriteLine("binary  number ");

            }
            else
            {
                Console.WriteLine("not binary");
            }




        }
}
    }
