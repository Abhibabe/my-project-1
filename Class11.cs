using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Cpalindrome
    {
        public static bool isPalindrome(int num)
        {
            int copy = num;
            int r;
            int rev = 0;
            while (copy > 0)
            {
                r = copy % 10;
                copy = copy / 10;
                rev = rev * 10 + r;
            }
            return rev == num;
        }
            static void Main(string[]args)
            {
            Console.WriteLine("Enter number ");
            int N1 = int.Parse(Console.ReadLine());
            if(isPalindrome(N1))
            {
                Console.WriteLine("Palindrome"  );

            }
            else
            {
                Console.WriteLine("not Plindrome");
            }
            

            }

        }

    

}
