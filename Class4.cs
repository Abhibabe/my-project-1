using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Employee
    {
        int empid;
        string empname;
        Dept d;
        public Employee(int empid, string  empname, Dept d)
        {
            this.empid =  empid;
            this.empname = empname;
            this.d = d;
        }
    
        public int EmpId
        {
            set {empid = value; }
            get { return empid; }
        }
        public string EmpName
        {
            set { empname = value; }
            get { return empname; }
        }
        public Dept D
        {
            set { d = value; }
            get { return d; }
        }

    }



    class Dept
    {
        int deptid;
        string dname;
        public Dept(int deptid, string dname)
        {
            this.deptid = deptid;
            this.dname = dname;
        }
        public int DeptId
        {
            set { deptid = value; }
            get { return deptid; }
        }
        public string Dname
        {
            set { dname = value; }
            get { return dname; }
        }
            static void Main(string[]args)
        {
            Employee e = new Employee(101, "rajneesh", new Dept(801, "Boardjaladhikary"));
        }
    }

}
