using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class numbersystyem
    { 
        public static  int addition(int num1,int num2)
        {
            return num1 + num2;
        }
    public static double addition(double num,double num3)
    {
        return num + num3;
    }
    static void Main(string[]args)
    {
        Console.WriteLine(addition(2,3));
        Console.WriteLine(addition(12.3, 34.5));
    }
    }
}
class Abc
{
    public virtual void Number ()
    {
        Console.WriteLine("hellow");
    }
}
class bbc : Abc 
{
    public override void Number ()
    {
        Console.WriteLine("hi");
    }

}
class Mainmethod
{
    static void Main(string[] args)

    {
        bbc b = new bbc();
        b.Number();
        Abc a = new Abc();
        a.Number();
    }
}


