using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    [Serializable]
    public class ItemContainer : ISerializable
    {

        #region Properties
        //not in an array because of the check box list
        private Item Mobile = new Item(0, "Mobile", 2345);
        private Item TV = new Item(1, "TV", 5400);
        private Item Speakers = new Item(2, "Speakers", 899);
        private Item Tablet = new Item(3, "Tablet", 999);
        private Item Cover = new Item(4, "Cover", 59);
        //private Item[] items = new Item[] { new Item(12, "Mobile", 1500), new Item(45, "TV", 2200), new Item(34, "Oven", 1750) };
        public List<Item> inventory = new List<Item>();
        #endregion

        #region Constructor
        public ItemContainer() { }
        public ItemContainer(SerializationInfo info, StreamingContext ctxt)
        {
            this.inventory = (List<Item>)info.GetValue("inventory", typeof(List<Item>));
            
        }
        #endregion
        private static object syncLock = new object();
        static private volatile ItemContainer s;
        public static ItemContainer S
        {
            get
            {
                if (s == null)
                {
                    lock (syncLock)
                    {
                        if (s == null)
                            s = new ItemContainer();
                    }
                }
                return s;
            }

            private set { s = value; }
        }        
        public Item this[int index]
        {
            get
            {
                if (index < 0 || index >= inventory.Count())
                    return null;
                else
                    return inventory[index];
            }
            set
            {
                if (!(index < 0 || index >= inventory.Count()))
                    inventory[index] = value;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("inventory", this.inventory);
        }

        public void InitInventory()
        {
            inventory.Add(Mobile);
            inventory.Add(TV);
            inventory.Add(Speakers);
            inventory.Add(Tablet);
            inventory.Add(Cover);
        }

        public Item Find(int psn)
        {            
            foreach (Item i in inventory)
                {
                    if (i.ProductSerialNum == psn)
                        return i;
                }
            return null;
        }
    }   
}
