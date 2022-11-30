using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class strings
    {
        static void Main(string[] args)
        {
            string s = "Abhishek maheshwari";
            int idxx = s.IndexOf('A');
            int idx = s.LastIndexOf('a');
            int id = s.IndexOf('a', 2);
            string t = s.Substring(2);
        string r = s.Substring(1, 4);
            r = r.Replace("a", "*");
            Console.WriteLine(idxx);
            Console.WriteLine(idx);
            Console.WriteLine(id);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(r);

         
        }
    }
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
                {
                    Console.WriteLine("not palindrome");
                }
            }
        
        

