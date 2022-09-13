using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Reactangle
    {
        int length, breath, area, perimeter;
        public void Input()
        {
            Console.WriteLine("Enter the lengeth");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breath");
            breath = int.Parse(Console.ReadLine());

        }
        public void Calculate()
        {
            perimeter = 2 * (length + breath);
            area = length * breath;
        }
        public void Display()
        {
            Console.WriteLine("perimeter" + perimeter);
            Console.WriteLine("area" + area);
        }
        public static void Main(String[]args)
        {
            Reactangle R = new Reactangle();
            R.Display();
            R.Input();
            R.Calculate();
        }

        
       
    }
}
