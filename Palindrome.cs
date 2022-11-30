using System;

namespace my_project_1
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            string s = Console.ReadLine();
            string reverse = " ";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s[i];
            }
            if (reverse == s)
            {
                Console.WriteLine("palindrome");

            }
            else
            {

                Console.WriteLine("not palindrome");
            }
        }
    }
    
