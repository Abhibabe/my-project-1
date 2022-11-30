using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Array3
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 7, 8 };
            int[] b = new int[10];
            for(int i=0;i<a.Length;i++)
            {
                b[i] = a[i];
            }
             for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }


        }
    }
}
