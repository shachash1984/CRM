using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    [Serializable]
    public class Customer : ISerializable, IComparable, IComparer
    {

        #region Properties
        static public int id = 0;
        public String Name { get; set; }
        public String Address { get; set; }
        public Date dob { get; set; } //Date of birth
        public Date dor { get; private set; } // Date of registration
        public int ItemCount { get; set; }
        public double TotalAmount { get; set; }
        public int CustomerID { get; set; }
        public List<Item> items = new List<Item>();
        #endregion

        #region Constructor
        public Customer() { }
        public Customer(SerializationInfo info, StreamingContext ctxt)
        {
            this.Name = (string)info.GetValue("Name", typeof(string));
            this.Address = (string)info.GetValue("Address", typeof(string));
            this.dob= (Date)info.GetValue("dob", typeof(Date));
            this.dor = (Date)info.GetValue("dor", typeof(Date));
            this.ItemCount = (int)info.GetValue("ItemCount", typeof(int));
            this.TotalAmount = (double)info.GetValue("TotalAmount", typeof(double));
            this.CustomerID = (int)info.GetValue("CustomerID", typeof(int));
            this.items = (List<Item>)info.GetValue("items", typeof(List<Item>));
        }
        public Customer(String name, String address, Date dob, Date dor, List<Item> _items)
        {
            CustomerContainer.S.Init();
            this.Name = name;
            this.Address = address;
            this.dob = dob;
            this.dor = dor;
            //this.CustomerID = id++;           
            this.CustomerID = CustomerContainer.S.currentID++;         
            Console.WriteLine("Customer ID: " + this.CustomerID);
            this.items = _items;
        }
        #endregion       

        #region Methods
        //methods
        public override string ToString()
        {
            return "Name: " + this.Name + "\nAddress: " + this.Address + "\nDate of birth: " + this.dob + "\nDate of registration: " + this.dor + "\nID: " + this.CustomerID;
        }

        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }

        public override bool Equals(object obj)
        {
            Customer c = obj as Customer;
            try
            {
                return this.CustomerID == c.CustomerID;
            }
            catch (Exception)
            {
                Console.WriteLine("The argument is not a Customer");
                return false;
            }            
        }        
        
        public virtual void AddToPayment(double itemPrice)
        {
            this.TotalAmount += itemPrice;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("Address", this.Address);
            info.AddValue("dob", this.dob);
            info.AddValue("dor", this.dor);
            info.AddValue("ItemCount", this.ItemCount);
            info.AddValue("TotalAmount", this.TotalAmount);
            info.AddValue("CustomerID", this.CustomerID);
            info.AddValue("items", this.items);
        }

        public int CompareTo(object obj)
        {
            Customer c = obj as Customer;
            if (this.CustomerID > c.CustomerID)
                return 1;
            else if (this.CustomerID == c.CustomerID)
                return 0;
            else
                return -1;
        }

        public int Compare(object x, object y)
        {
            Customer c = x as Customer;
            Customer d = y as Customer;
            if (c.CustomerID > d.CustomerID)
                return 1;
            else if (c.CustomerID == d.CustomerID)
                return 0;
            else
                return -1;
        }

        public double GetHighestPrice()
        {
            double highest = 0;
            foreach (Item i in items)
            {
                if (i.Price > highest)
                    highest = i.Price;
            }

            return highest;
        }

        public double GetTotalAmount()
        {
            return TotalAmount;
        }
    }

    
    #endregion

}
