using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public enum RegCustomerType
    {
        SILVER,
        GOLD,
        PLATINUM
    }

    [Serializable]
    class RegCustomer : Customer
    {
        #region Properties

        public RegCustomerType RegType { get; set; }
        #endregion

        #region Constructor

        public RegCustomer() { }
        public RegCustomer(SerializationInfo info, StreamingContext ctxt) :base(info, ctxt)
        {
            this.RegType = (RegCustomerType)info.GetValue("RegType", typeof(RegCustomerType));
        }
        public RegCustomer(String name, String address, Date dob, Date dor, List<Item> _items ,RegCustomerType regType) : base(name, address, dob, dor, _items)
        {
            this.RegType = regType;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString() + "\nRegular customer type: " + this.RegType;
        }

        public override void Print(string str)
        {
            base.Print(str);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void AddToPayment(double itemPrice)
        {
            base.AddToPayment(itemPrice);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("RegType", this.RegType);
        }

       
        #endregion

    }
}
