using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{

    class Abc
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 4, 6, 7, 8, 3, 9 };
            Console.WriteLine(arr1[0]);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

        }
    }

}
// TECHNIQUE FOR SORTING THE ELEMENTS//
class sorting
{
    static void Main(string[] args)
    {

        int[] arr = new int[] { 2, 4, 5, 6, 7, 8 };
        int temp;
        for(int i=0;i<arr.Length; i++)
        {
            for(int j=0;j<arr.Length-1;i++)
            {
                if(arr[j]>arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1]= temp;
            }
        }
        foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

    }
    
}
    // searching in array
    class arrey
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 45, 67, 9, 65, 34 };
            Console.WriteLine("Enter the Number ");
            int num = int.Parse(Console.ReadLine());
            bool isthistrue = false;
            for(int i=0;i<arr.Length;i++)
            {
                if(num==arr[i])
                {
                    isthistrue = true;
                    break;
                }
            }
            if(isthistrue)
            {
                Console.WriteLine("element found ");
            }
            else
            {
                Console.WriteLine(  "not ofund ");
            }
        }

    }
    class abc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int num = 2;
         
            for(int i=0;i<arr.Length; i++)
            {
                if(num==arr[i])
                {
                    Console.WriteLine("find at"+i+"position");


                }
                else
                {
                    Console.WriteLine("notfind");
                }
            }
           
           

            
           
            }
        }
    }
    /// SOrting and searching fir two dimensional array
    /// 
    class Aaas
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 11, 22, 33, 44 }, { 33, 55, 66, 88 } };
            for (int i =0;i<3;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    {
                        Console.WriteLine(arr[i, j]+"\t");
                    }
                }
            }
            Console.WriteLine();
        }

    }
     sealed class  myclass1
    {
        public void sample()
        {
            Console.WriteLine("samplemethod ");
        }
        class myclass2 :
        { 

        }

    }