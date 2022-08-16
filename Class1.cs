using System;
using System.Collections.Generic;
using System.Text;



namespace my_project_1
{


    class Class1
    {
        static void Main(string[] args)
        {
            {
                int num1, num2, Temp;
                Console.("\n input first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.("\n input second number:");
                num2 = int.Parse(Console.ReadLine());
                Temp = num1;
                num1 = num2;
                num2 = Temp;
                Console.WriteLine('\n after swapping:");
                    Console.WriteLine("\n First number: +num1");
                Console.WriteLine("\n second number :+num2");
                Console.Read();




            }
        }
    }
}
