using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Overload
    {
        public void numcal(int num, char ch)
        {
            int sum = 0;
            if (ch == 's')
            {
                sum = num * num;
            }
            else
            {
                sum = num * num * num;
            }
            Console.WriteLine("suare or cube:" + sum);

        }
        public void numcal(int a, int b, char ch)
        {
            int c = 0;
            if (ch == 'p')
            {
                c = a * b;
            }
            else
            {
                c = a + b;
            }
            Console.WriteLine("answer:" + c);
        }
        public static void Main(string[] args)
        {
            Overload o = new Overload();
            o.numcal(12, 's');
            o.numcal(12, 34, 's');


        }
    }
    }
