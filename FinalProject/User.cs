using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    [Serializable]
    public class User : ISerializable
    {
        public User (string userName, string password, int id)
        {
            this.UserName = userName;
            this.Password = password;
            this.ID = id;
        }
        
        public User(SerializationInfo info, StreamingContext ctxt)
        {
            this.UserName = (string)info.GetValue("UserName", typeof(string));
            this.Password = (string)info.GetValue("Password", typeof(string));
            this.ID = (int)info.GetValue("ID", typeof(int));
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        private string userName;
        public string UserName
        {
            get { return userName; }  
            private set { userName = value; }          
        }

        private string password;
        public string Password
        {
            get { return password; }
            private set { password = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("UserName", this.UserName);
            info.AddValue("Password", this.Password);
            info.AddValue("ID", this.ID);
        }

        
    }
}
