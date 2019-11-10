using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace FinalProject
{
    class Program
    {
        //static object o = new object();
        //public object o1 = new object();
        static private bool noUsersExist = false;


        static void Main(string[] args)
        {
            DataManager dataManager = DataManager.S;
            UserList userList = UserList.S;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            User u = new User("shachash", "1234", 0);
            userList.users.Add(u);
            dataManager.SaveToBinary(u);
            User u1 = new User("Jackie", "0000", 1);
            userList.users.Add(u1);
            dataManager.SaveToBinary(u1);
            //User u2 = new User("", "", 2);
            //userList.users.Add(u2);
            //dataManager.SaveToBinary(u2);
            dataManager.SaveAllToBinary(userList);

            Application.Run(new LoginForm());
            
            if (LoginForm.userAuthorized || noUsersExist)
            {
                Application.Run(new MainForm());
            }

            #region Tests
            /*CustomerContainer cc = new CustomerContainer();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    cc.Add(new VipCustomer("Customer_" + i.ToString(), "Adress_" + i.ToString(), new Date(i, i, 1980 + i), new Date(i + 1, i + 1, 2009 + i), i * 0.05));
                else
                    cc.Add(new RegCustomer("Customer_" + i.ToString(), "Adress_" + i.ToString(), new Date(i, i, 1980 + i), new Date(i + 1, i + 1, 2009 + i), RegCustomerType.GOLD));
            }

            //cc.PerformActionOnCustomer(Show);

            cc.PerformActionOnCustomer(delegate (Customer c) 
            {
                c.Print(c.Name);
            });*/

            /*
            Customer cust = new Customer();
            cust.Address = "sdgfsdgs";
            cust.Name = "rrrrrr";
            //cust.dob = new Date(1, 1, 11);
            //cust.dor = new Date(1, 1, 11);
            cust.CustomerID = 54;

            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            TextWriter textWriter = new StreamWriter(@"customer.xml");
            serializer.Serialize(textWriter, cust);
            textWriter.Close();*/
            /* Customer c = new Customer();
             c.CustomerID = 123;
             c.Name = "Hizu";
             c.Address = "gordon 11b";
             c.dob = new Date(27, 7, 1984);
             c.dor = new Date(1, 1, 1998);

             Console.WriteLine("c after init: " + c.ToString());
             Stream stream = File.Open("CustomerInfo.cus", FileMode.Create);
             BinaryFormatter bformatter = new BinaryFormatter();

             bformatter.Serialize(stream, c);
             stream.Close();

             c = new Customer("ido", "po108", new Date(5,5,1955), new Date(8,8,1988));

             Console.WriteLine(c.ToString());
             stream = File.Open("CustomerInfo.cus", FileMode.Open);
             c = (Customer)bformatter.Deserialize(stream);

             Console.WriteLine("c after deserialization:" + c.ToString());*/


            /*
            CustomerContainer cc = new CustomerContainer();
            for (int i = 0; i < 3; i++)
            {
                if (i % 2 == 0)
                {
                    RegCustomer rc = new RegCustomer("Customer" + i, "Adress" + i, new Date(i, i, 1970 + i), new Date(i, 4, 2017), RegCustomerType.SILVER);
                    cc.Add(rc);
                }
                else
                {
                    VipCustomer vc = new VipCustomer("Customer" + i, "Adress" + i, new Date(i, i, 1970 + i), new Date(i, 3, 2017), 0.2);
                    cc.Add(vc);
                }

                cc.customers[i].Print();
                cc.customers[i].AddToPayment(i*10);
            }
            cc.Remove(cc[3]);
            cc.PrintAll();
            cc.Remove(cc.Find(6));
            cc.PrintAll();
            cc.RemoveAll();
            cc.PrintAll();*/

            /*     

                 Thread t1 = new Thread(testThread);
                 Thread t2 = new Thread(testThread);
                 t1.Name = "first";
                 t2.Name = "second";
                 t1.Start();
                 t2.Start();
             }

             public static void Show(Customer c)
             {
                 c.Print(c.ToString());
             }

             public static void testThread()
             {

                 lock (o)
                 {
                     for (int i = 0; i < 1000; i++)
                     {
                         Console.WriteLine(Thread.CurrentThread.Name.ToString() + "_" + i);
                     }
                 }          

             }*/
        }

        /*public static void RunMainForm()
        {
            Application.Run(new MainForm());
        }*/
        #endregion

    }
}

