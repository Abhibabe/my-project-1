using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Arra

    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 67, 8, 9 };
            int[] b = { 9, 2, 4, 3, 5, 8 };
            Console.WriteLine("Common Elements Are");
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<b.Length;j++)
                    if(a[i]==b[j])
                    {
                        Console.WriteLine(a[i]+" ");
                    }
            }
        }
    }
}
