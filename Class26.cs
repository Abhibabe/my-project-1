using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Parent
    {
        int a, b;
        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }
        }
        public Parent (int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Study()
        {
            Console.WriteLine("im good in study");
        }
        public void Read()
        {
            Console.WriteLine("lets read");
        }
    }
    class Child:Parent
    {
        public Child(int x,int y):base(x,y)
        {
            
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Child c = new Child(11, 12);
            c.Study();
        }
    }
}

