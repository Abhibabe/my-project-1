using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class p
    { int i;

        public p()
        {
            Console.WriteLine("don");
        }
        public p(int i)
        {
            Console.WriteLine("in parent para constructoe");
            this.i = i;
        }
    }
    class q : p
    {
        int k;
        public q()
        {
            Console.WriteLine("ok");
        }
        public q(int i, int k) : base(i)
        {
            Console.WriteLine("in child para constructoe");
            this.k = k;
        }
    }
        class Test
        {
        static void Main(string[] args)
        {
            q ob = new q(12, 89);
        }

        }


    
}
