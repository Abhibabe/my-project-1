using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Car
    {
        string name;
        int price;
        string brand;
        string etype;

        public Car()
        {

        }
        public Car(string cnm, int p)
        {
            Name = cnm;
            Price = p;
        }

        public Car(string e,string b)
        {
            Etype = e;
            Brand = b;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Etype { get => etype; set => etype = value; }

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Name = "bmw";
            
           
            Car c2 = new Car("hondacitt", 150000);
            c2.Etype = "petrol";
            Car c3 = new Car("b6","audi");

           
        }



    }
        
}
