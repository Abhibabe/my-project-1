using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Array
    {
        // Array is a variable which store multiple variable of same tye in a single entity//
       static void Main(string[]args)
        {
            int[] a = { 10, 20, 30, 40 };
            foreach(int i in a)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
