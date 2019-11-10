using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace FinalProject
{
    public sealed class DataManager
    {
        
        private static object syncLock = new object();
        private DataManager() { }
        static private volatile DataManager s;
        public static DataManager S
        {
            get
            {
                if (s == null)
                {
                    lock (syncLock)
                    {
                        if (s == null)
                            s = new DataManager();
                    }
                }
                return s;
            }
        }

        public void SaveToBinary(Customer c)
        {
            Stream stream = File.OpenWrite("customersBin\\Customer_" + c.CustomerID + ".dat");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, c);
            stream.Close();
        }

        public void SaveToBinary(User u)
        {
            Stream stream = File.OpenWrite("usersBin\\User_" + u.ID + ".dat");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, u);
            stream.Close();
        }

        public void SaveAllToBinary(CustomerContainer cc)
        {
            Stream stream = File.OpenWrite("customersBin\\Customer_List.dat");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, cc);
            stream.Close();
        }

        public void SaveAllToBinary(UserList ul)
        {
            Stream stream = File.OpenWrite("usersBin\\User_List.dat");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, ul);
            stream.Close();
        }

        public Customer LoadFromBinary(int customerID)
        {
            Stream stream = File.Open("customersBin\\Customer_" + customerID + ".dat", FileMode.Open);            
            BinaryFormatter bf = new BinaryFormatter();
            Customer c = (Customer)bf.Deserialize(stream);
            stream.Close();
            return c;
        }

        public User LoadUserFromBinary(int userID)
        {
            Stream stream = File.Open("usersBin\\User_" + userID + ".dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            User u = (User)bf.Deserialize(stream);
            stream.Close();
            return u;
        }

        public CustomerContainer LoadAllFromBinary()
        {
            CustomerContainer cc = new CustomerContainer();
            Stream stream = File.Open("customersBin\\Customer_List.dat", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (stream.Length > 0)
                    cc = (CustomerContainer)bf.Deserialize(stream);
                else
                    cc = new CustomerContainer();
                
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
            }
            
            stream.Close();
            return cc;
        }

        public UserList LoadAllUsersFromBinary()
        {
            UserList ul = new UserList();
            Stream stream = File.Open("userBin\\User_List.dat", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (stream.Length > 0)
                    ul = (UserList)bf.Deserialize(stream);
                else
                    ul = new UserList();

            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
            }

            stream.Close();
            return ul;
        }

        public void DeleteCustomer(Customer c)
        {
            try
            {
                File.Delete("customersBin\\Customer_" + c.CustomerID + ".dat");

            }
            catch (Exception)
            {
                DialogResult d = MessageBox.Show("Customer could not be found", "Customer not found", MessageBoxButtons.OK);
            }
        }

        public void DeleteAll(CustomerContainer cc)
        {
            foreach (Customer c in cc.customers)
            {
                DeleteCustomer(c);
            }

            File.Delete("customersBin\\Customer_List.dat");
        }
    }
}
