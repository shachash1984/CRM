using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    class VipCustomer : Customer
    {
        #region Properties

        static private int MemberNum;
        public int CustMemberNum { get; set; }
        private double discount;
        public double Discount
        {
            get { return discount; }
            set
            {
                if (value >= 0 && value <= 1.0)
                    discount = value;
                else
                    value = 0;
            }
        }
        #endregion

        #region Constructor

        public VipCustomer() { }
        public VipCustomer(String name, String address, Date dob, Date dor, List<Item> _items ,double discount) : base(name, address, dob, dor, _items)
        {
            this.discount = discount;
            this.CustMemberNum = MemberNum++;
        }
        public VipCustomer(SerializationInfo info, StreamingContext ctxt) :base(info, ctxt)
        {
            this.discount = (double)info.GetValue("Discount", typeof(double));
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "\nMember number: " + this.CustMemberNum + "\nDiscount: " + this.discount;
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
            base.AddToPayment(itemPrice - (itemPrice * this.discount));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {            
            base.GetObjectData(info, context);
            info.AddValue("Discount", this.discount);
        }
        #endregion
    }
}
