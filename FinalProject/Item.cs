using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    [Serializable]
    public class Item : ISerializable
    {
        //properties
        public int ProductSerialNum { get; set; }
        public String Name { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set {
                if (value >= 0.0)
                    price = value;
                else
                    Console.WriteLine("Price can not be a negative number");
            }
        }

        //ctor
        public Item() { }
        public Item(SerializationInfo info, StreamingContext ctxt)
        {
            this.ProductSerialNum = (int)info.GetValue("ProductSerialNum", typeof(int));
            this.Name = (string)info.GetValue("Name", typeof(string));
            this.Price = (double)info.GetValue("Price", typeof(double));
            
            
        }
        public Item(int PSN, String name, int price)
        {
            this.ProductSerialNum = PSN;
            this.Name = name;
            this.Price = price;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Price", this.Price);
            info.AddValue("Name", this.Name);
            info.AddValue("ProductSerialNum", this.ProductSerialNum);
        }

        public override string ToString()
        {
            return "PSN: " + this.ProductSerialNum + " Name: " + this.Name + " Price: " + this.price;
        }
    }

}
