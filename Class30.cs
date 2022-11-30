using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Aarr1
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] a = new int[n];
            for(int i=0;i<n;i++)
            {
                int sum;
              
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                
                Console.WriteLine(a[i]);
            }
            int avg = sum / n;
            Console.WriteLine(avg);
        }   
    }
}
