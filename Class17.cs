using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Evenodd
    {
        public  static bool IsEven(int num)

        {
            if (num % 2 == 0)
                return true;

            else

                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int N1 = int.Parse(Console.ReadLine());

            if (IsEven(N1))

            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }

        private static bool IsEven(object num)
        {
            throw new NotImplementedException();
        }
    }
}
