using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Emp
    {
        string name;
        int eid;
        int mgid;
        string mname;
        public Emp(string name, int eid, int mgid, string mname)
        {
            this.name = name;
            this.eid = eid;
            this.mgid = mgid;
            this.mname = mname;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Mgid
        {
            set { mgid = value; }
            get { return mgid; }
        }
        public string Mname
        {
            set { mname = value; }
            get { return mname; }
        }
        public void Showdata()
        {
            Console.WriteLine("Employee  Name :"+name+"Employee id:"+eid+"Manager id:"+mgid+"Manager name :"+mname);
        }
        class Testmap
        {
            static void Main(string[] args)
            {
                Emp[] e = new Emp[5];
                e[0] = new Emp("Abhishek", 201, 234, "sukvinder");
                e[1] = new Emp("Raghav", 202, 235, "Rajesh");
                e[2] = new Emp("yeash", 345, 776, "Himanshu");
                e[3] = new Emp("righuvir", 398, 998, "Rajaat");
                e[4] = new Emp("Sativer", 878, 998, "Okla");

                e[0].Showdata();
                e[1].Showdata();
                e[2].Showdata();
                e[3].Showdata();
                e[4].Showdata();

            }
          
        }


    }
}
