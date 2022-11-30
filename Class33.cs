using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Arr1
    {
        public static int average(int []array)
        {
           
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                sum = sum + array[i];
                
            }
            
            int average = sum / array.Length;
            Console.WriteLine(average);
            return average;
               
        }
        public static double average(double []array)
        {
            double sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            double average = sum / array.Length;
                
            Console.WriteLine(average);
            return average;


        }
    }
}
