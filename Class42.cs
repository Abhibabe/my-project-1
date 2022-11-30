using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 strings ");
            string s1 = Console.ReadLine().Trim().ToLower();
            string s2 = Console.ReadLine().Trim().ToLower();
            if(s1.Length==s2.Length)
            {   
                foreach(char ch in s1)
                {
                    // s==2; delete
                    int indx = s2.IndexOf(ch);
                    if (indx != -1)
                        s2 = s2.Substring(0, indx) + s2.Substring(0, indx + 1);
                            
                }
                if(s2.Length==0)
                {
                    Console.WriteLine( "paloindeome");
                }
                else
                {
                    Console.WriteLine("not palindrome");
                }
            }
            
        }
    }
}
