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
    public class UserList : ISerializable
    {
        public List<User> users = new List<User>();
        private static object syncLock = new object();
        static private volatile UserList s;
        public static UserList S
        {
            get
            {
                if (s == null)
                {
                    lock (syncLock)
                    {
                        if (s == null)
                            s = new UserList();
                    }
                }
                return s;
            }

            private set { s = value; }
        }
        

        public User this[int index]
        {
            get
            {
                if (index < 0 || index >= users.Count())
                    return null;
                else
                    return users[index];
            }
            set
            {
                if (!(index < 0 || index >= users.Count()))
                    users[index] = value;
            }
        }
        public UserList() { }
        public UserList(SerializationInfo info, StreamingContext context)
        {
            this.users = (List<User>)info.GetValue("users", typeof(List<User>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("users", this.users);
        }

        
            public void Init()
        {
            S = DataManager.S.LoadAllUsersFromBinary();
        }
    
    }
}
