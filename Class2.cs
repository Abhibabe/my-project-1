using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
        class Student
        {
            string name;
            float percentage;
            int year;
            

            public void Setname(string nm)
            {
                name = nm;

            }
            public string Getname()
            {
                return name;
            }
            public void Setpercentage(float per)
            {
                percentage = per;
            }
            public float Getpercentage()
            {
                return percentage;
            }
            public void Setyear(int yr)
            {
                year = yr;
            }
            public int Getyear()
            {
                return year;
            }
            static void Main(string[]args)
            {
                Student s = new Student();
               s.Setname("Kirti");
                s.Setpercentage(69);
                s.Setyear(2016);
                Console.WriteLine(s.Getname());
                Console.WriteLine(s.Getpercentage());
                Console.WriteLine(s.Getyear());



            }

        
    }
}
