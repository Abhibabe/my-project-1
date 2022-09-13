using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Pen
    {
        Refill r;
        int caplength;
        string brand;


        public Pen(Refill r, int caplength, string brand)
        {
            this.r = r;
            this.caplength = caplength;
            this.brand = brand;
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
        public int CapLength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }

        }
    }
    class Refill
    {
        string inkcolour;
        int length;
        Nib tip;
        public Refill(string inkcolour, int length, Nib tip)
        {
            this.inkcolour = inkcolour;
            this.length = length;
            this.tip = tip;
        }
        public string InkColour
        {
            set { inkcolour = value; }
            get { return inkcolour; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public Nib Tip
        {
            set { tip = value; }
            get { return tip; }
        }
    }
    class Nib
    {
        string materialtype;
        int width;
        public Nib(string materialtype, int width)
        {
            this.materialtype = materialtype;
            this.width = width;
        }
        public string MaterialType
        {
            set { materialtype = value; }
            get { return materialtype; }
        }
        public int Width
        {
            set { width = value; }
            get { return width; }
        }
        static void Main (string[]args)
        {    
            Pen p = new Pen(new Refill("black",6,new Nib("plastic",4)),6,"Cello");
            Console.WriteLine(p.Brand);
            Console.WriteLine(p.R.InkColour);
            Console.WriteLine(p.R.Tip.MaterialType);
       }
    }
}
