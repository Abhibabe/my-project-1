using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Class9
    {

        public string Divide(int N)
        {
            int n= int.Parse(Console.ReadLine());

                
            
            if (n % 5 != 0)
            {
                return "yes";

            }
            else if (n%3!=0)
            {
                return "no";
            }
            else 
            {
              return "nothing";
            }
        }

        static void Main(string[] args)
        {
            Class9 c1 = new Class9();
            string msg = c1.Divide(5);
                Console.WriteLine(  msg);


        }


    }
}
