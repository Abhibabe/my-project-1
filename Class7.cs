using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class STUDENT
    {
        private const string V = "deepa";
        int id;
        string qualificaion;
        string name;
        long number;
        static  string trainername;
        

        public void accept()
        {
            Console.WriteLine(  "Enter the student id,number,qualifiacation");
            int id = int.Parse(Console.ReadLine());
            string qualification = Console.ReadLine();
            string name = Console.ReadLine();
            long number = long.Parse(Console.ReadLine());
        }

    public static void  SetTrainerName(string yuz)
        {
            trainername = yuz;
        }
        public int square(int a)
        {
            int sq = a * a;
            return sq;
        }
        public void display()
        {
            Console.WriteLine($"studentname:{name}studentnumber:{number}student qualification{qualificaion}studentid{id}");
        }
       static void Main(string[]args)
        {
            Console.WriteLine(STUDENT.trainername);
            STUDENT.SetTrainerName(V);
                                                                      //static variable once declaed in class for all objects 
            STUDENT s1 = new STUDENT();
            s1.id = 23;
            s1.qualificaion = "b.tech";
            s1.number = 7568006421;
            s1.name= "abhishek";
            int result = s1.square(9);
            Console.WriteLine(result);
          
            Console.WriteLine($"studentname:{s1.name}studentnumber:{s1.number}student qualification{s1.qualificaion}studentid{s1.id}");
            s1.accept();
            s1.display();
        }


    }



}
