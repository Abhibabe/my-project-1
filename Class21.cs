using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Order

    {
        int orderd;
        string orderdate;
        Customer cust;
        Item item;
       public Order(int orderd, string orderdate, Customer cust, Item item)
        {
            this.orderd = orderd;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = item;

        }

       public  Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }
        public Item Item1
        {
            set { item = value; }
            get { return item; }
        }
    }
    class Customer
    {
        int customerid;
        string customername;
        Address address;
        public Customer(int customerid, string customername, Address address)
        {
            this.customerid = customerid;
            this.customername = customername;
            this.address = address;
        }
    }
          



            class Address
            {
                string address1;
                string city;
                int pincode;
                public Address(string address1, string city, int pincode)
                {
                    this.address1 = address1;
                    this.city = city;
                    this.pincode = pincode;

                }
                public string Address1
                {
                    set { address1 = value; }
                    get { return address1; }
                }
                public string City
                {
                    set { city = value; }
                    get { return city; }
                }
                public int Pincode
                {
                    set { pincode = value; }
                    get { return pincode; }
                }

            }
            class Item
            {
                int itemid;
                string itemname;
                int price;
                public Item(int itemid, string itemname, int price)
                {
                    this.itemid = itemid;
                    this.itemname = itemname;
                    this.price = price;

                }
                public int Itemid
                {
                    set { itemid = value; }
                    get { return itemid; }
                }
                public string Itemname
                {
                    set { itemname = value; }
                    get { return itemname; }
                }
                public int Price
                {
                    set { price = value; }
                    get { return price; }
                }
                static void Main(string []args)
                { Customer c = new Customer(101, "Abhi", new Address("bhavnagar", "jaipur", 201301));
            Order o1 = new Order(1223, "12/02/2022", c, new Item(101, "abhi", 209));
                }
            }
        
    
}
