using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{ 
    class Arra3
{
    static void Main(string[] args)
    {


        int[] a = { 1, 4, 5, 6, 7, 8, 4 };
        int n = int.Parse(Console.ReadLine());
            int pos = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == n)
            {    pos = i;
                break;
            }
            Console.WriteLine("element foun at index " + pos);
        }

    }
}
}
