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
    public delegate void CustomerAction(Customer c);
    [Serializable]
    public class CustomerContainer : ISerializable
    {
        
        #region Constructor
        public CustomerContainer() { }
        public CustomerContainer(SerializationInfo info, StreamingContext ctxt)
        {
            this.customers = (List<Customer>)info.GetValue("customers", typeof(List<Customer>));
            this.currentID = (int)info.GetValue("currentID", typeof(int));
        }
        #endregion
        private static object syncLock = new object();
        static private volatile CustomerContainer s;
        public static CustomerContainer S
        {
            get
            {
                if (s == null)
                {
                    lock (syncLock)
                    {
                        if (s == null)
                            s = new CustomerContainer();
                    }
                }
                return s;
            }

            private set { s = value; }
        }
        public List<Customer> customers = new List<Customer>();
        public Customer this[int index]
        {
            get
            {
                if (index < 0 || index >= customers.Count())
                    return null;
                else
                    return customers[index];
            }
            set
            {
                if (!(index < 0 || index >= customers.Count()))
                    customers[index] = value;                    
            }
        }
        public int currentID; 

        #region Methods
        public void PerformActionOnCustomer(CustomerAction cAction)
        {
            foreach (Customer c in customers)
            {
                cAction(c);
            }
        }

        public void Add(Customer c)
        {
            customers.Add(c);           
        }

        public Customer Find(int custId)
        {
            foreach (Customer c in customers)
            {
                if (c.CustomerID == custId)
                    return c;                
            }
            return null;
        }

        public int Find(Customer c)
        {
            return customers.IndexOf(c);
        }        

        public bool Contains(Customer c)
        {
            return customers.Contains(c);
        }        

        public void Remove(Customer c)
        {
            customers.Remove(c);
        }

        public void Remove(String custName)
        {            
            try
            {
                customers.Remove(Find(customers.Find(c => c.Name.Equals(custName)).CustomerID));
            }
            catch (Exception)
            {
                Console.WriteLine("Customer Named: " + custName + " could not be found");
            }            
        }

        public void Remove(int index)
        {
            customers.Remove(customers[index]);
        }

        public void RemoveAll()
        {
            customers.Clear();            
        }

        public void PrintAll()
        {
            Console.WriteLine(this.ToString());
        }

        public override String ToString()
        {
            StringBuilder strb = new StringBuilder();
            foreach (Customer c in customers)
            {
                if (customers.Count() > 0)
                    strb.Append("\n" + c.ToString());
                else
                    return "There are no registered customers";
            }
            return strb.ToString();
        }

        public void AddPaymentToAll(double itemPrice)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].AddToPayment(itemPrice);
            }
        }

        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("customers", this.customers);
            info.AddValue("currentID", this.currentID);
        }

        public void Init()
        {
            S = DataManager.S.LoadAllFromBinary();
            Console.WriteLine("Customer Count: " + customers.Count);
            if (customers.Count > 0)
                currentID = customers[customers.Count - 1].CustomerID;
            else
                currentID = 0;
        }

    }
}
