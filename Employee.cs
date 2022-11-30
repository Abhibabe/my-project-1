using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Employeee
    {
        long id;
        string name;
        long salary;
        public Employeee(long id,string name,long salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public long Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
            public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }
        }
            public long Salary
        {
            set
            {
                salary = value;

            }
            get
            {
                return salary;
            }
        } 
            static void Main(string[] args)
        {
            Employeee E = new Employeee(101,"rajesh",25000);

           



        }
    

    }
    }
