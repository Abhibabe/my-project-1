using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Array2d
    {
        static void Main(string[] args)
        {
            int[] arr1 =   { 1, 3, 6, 7, 4 };
            Console.WriteLine($"Length={arr1.Length}");
            int[,] arr2 = new int [3, 5];
            Console.WriteLine($"Length of array2={arr2.Length}");
            Console.WriteLine("rows"+arr2.GetLength(0));
            Console.WriteLine("Colums" + arr2.GetLength(1));

          
        }

    }
}
