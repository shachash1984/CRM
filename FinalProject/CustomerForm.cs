using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject
{
    public enum Mode { View, Edit, Create, None}
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            CreateCustomer_VIPDiscount_Label.Enabled = false;
            CreateCustomer_Discount_Input.Enabled = false;
        }
        public MainForm _mainForm;
        public Mode currentMode;
        public int currentCustomerID;
        public List<Item> tempItems = new List<Item>();
        private void Button_Save_Customer_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Create)
            {
                Customer c = new Customer();
                SaveCustomer(c);
            }
            else if (currentMode == Mode.Edit)
            {
                Customer c = CustomerContainer.S.Find(currentCustomerID);
                Console.WriteLine("Current ID: " + currentCustomerID);
                SaveCustomer(c);
            }
                     

           // DataManager.S.SaveAllToBinary(CustomerContainer.S);
            ClearCreateBox();
        }
        public void CreateCustomer()
        {
            Group_Cust_Properties.Visible = false;
            Group_Cust_Properties.SendToBack();
            Group_CreateCustomer.Visible = true;
            Group_CreateCustomer.BringToFront();
        }

        public void SaveCustomer(Customer c)
        {

            if (currentMode == Mode.Create)
            {
                if (CheckBox_Create_isVIP.Checked)
                {

                    double discount = (double)(CreateCustomer_Discount_Input.SelectedIndex);
                    discount /= 10;
                    Console.WriteLine("New Customer Discount: " + discount);
                    c = new VipCustomer(Text_CreateName.Text, Text_Create_Address.Text, new Date(Date_Create_DOB.Value.Day, Date_Create_DOB.Value.Month, Date_Create_DOB.Value.Year), new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year), tempItems, discount);
                    
                    VipCustomer v = c as VipCustomer;
                    
                }
                else
                {
                    RegCustomerType RegTypetemp = RegCustomerType.GOLD;
                    Console.WriteLine(CreateCustomer_RegScore_ComboBox.SelectedIndex);
                    switch (CreateCustomer_RegScore_ComboBox.SelectedItem.ToString())
                    {
                        case "SILVER":
                            RegTypetemp = RegCustomerType.SILVER;
                            break;
                        case "PLATINUM":
                            RegTypetemp = RegCustomerType.PLATINUM;
                            break;
                        default:
                            break;
                    }
                    c = new RegCustomer(Text_CreateName.Text, Text_Create_Address.Text, new Date(Date_Create_DOB.Value.Day, Date_Create_DOB.Value.Month, Date_Create_DOB.Value.Year), new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year), tempItems, RegTypetemp);

                }
                CustomerContainer.S.Add(c);
            }
            else if (currentMode == Mode.Edit)

            {
                c = CustomerContainer.S.Find(currentCustomerID);
                Console.WriteLine("Name: " + c.Name + "Type: " + c.GetType().ToString());
                c.Name = Text_CreateName.Text;
                c.Address = Text_Create_Address.Text;
                c.dob = new Date(Date_Create_DOB.Value.Day, Date_Create_DOB.Value.Month, Date_Create_DOB.Value.Year);

                if (c is VipCustomer)
                {
                    VipCustomer v = c as VipCustomer;
                    v.Discount = (double)(CreateCustomer_Discount_Input.SelectedIndex) / 10;
                    CreateCustomer_Discount_Input.SelectedIndex = (int)(Math.Round(v.Discount * 10));
                }
                else if (c is RegCustomer)
                {
                    Console.WriteLine("c is REG");
                    RegCustomer r = c as RegCustomer;

                    RegCustomerType RegTypetemp = (RegCustomerType)CreateCustomer_RegScore_ComboBox.SelectedIndex;
                    Console.WriteLine("Save Cust RegType: " + RegTypetemp.ToString());
                    Console.WriteLine((RegCustomerType)CreateCustomer_RegScore_ComboBox.SelectedIndex);
                    switch (RegTypetemp)
                    {
                        case RegCustomerType.SILVER:
                            break;
                        case RegCustomerType.GOLD:
                            break;
                        case RegCustomerType.PLATINUM:
                            break;
                        default:
                            break;
                    }

                    r.RegType = RegTypetemp;
                }
            }
                
            DataManager.S.SaveToBinary(c);
            DataManager.S.SaveAllToBinary(CustomerContainer.S);
            _mainForm.Update();
        }
        
        public void ViewCustomer(int customerID)
        {
            currentMode = Mode.View;            
            EnableAll(true);
            Customer c = CustomerContainer.S.Find(customerID);            
            Group_CreateCustomer.Visible = false;
            Group_CreateCustomer.SendToBack();
            Group_Cust_Properties.Visible = true;
            Group_Cust_Properties.BringToFront();
            Button_DeleteCustomer.Enabled = false;
            Button_DeleteCustomer.Visible = false;
            try
            {
                Label_Num_Cust_ID.Text = c.CustomerID.ToString();
                Label_TextName.Text = c.Name;
                Label_Text_Address.Text = c.Address;
                Label_Date_Dob.Text = c.dob.ToString();
                Label_Date_DOR.Text = c.dor.ToString();
                listView1.Enabled = true;
                InitItemList();
                SetCustomerItemList(c);
                label_text_highestPrice.Text = c.GetHighestPrice().ToString();
                label_text_Total.Text = c.GetTotalAmount().ToString();
                Button_AddToPayment.Enabled = true;
                
                if (c is VipCustomer)
                {
                    Label_Customer_isVIP.Text = "Yes";
                    VipCustomer v = c as VipCustomer;
                    Label_Discount.Enabled = true;
                    Combo_Discount.Enabled = false;
                    Console.WriteLine("Discount: " + v.Discount);
                    Combo_Discount.SelectedIndex = (int)(v.Discount * 10);
                    Input_RegCustomerScore.SelectedIndex = 3;
                    Input_RegCustomerScore.Enabled = false;
                }

                else if (c is RegCustomer)
                {
                    Label_Customer_isVIP.Text = "No";
                    Label_Discount.Enabled = false;
                    Combo_Discount.Enabled = false;
                    Combo_Discount.SelectedIndex = 0;
                    RegCustomer r = c as RegCustomer;
                    Console.WriteLine(((int)r.RegType).ToString());
                    Input_RegCustomerScore.SelectedIndex = (int)r.RegType;
                    Input_RegCustomerScore.Enabled = false;
                }
            }
            catch (NullReferenceException e)
            {
                DialogResult d = MessageBox.Show("Customer not found", "No ID found", MessageBoxButtons.OK);                
            }         
            
                
        }

        public void UpdateCustomer(int customerID, out int custID)
        {
            custID = customerID;
            CreateCustomer();
            Customer c = CustomerContainer.S.Find(customerID);
            Text_CreateName.Text = c.Name;
            Text_Create_Address.Text = c.Address;
            DateTime temp = new DateTime(c.dob.Year, c.dob.Month, c.dob.Day);
            Date_Create_DOB.Value = temp;
            if(c is VipCustomer)
            {
                VipCustomer v = c as VipCustomer;
                CheckBox_Create_isVIP.Checked = true;
                CheckBox_Create_isVIP.Enabled = false;                
                CreateCustomer_Discount_Input.SelectedIndex = (int)(Math.Round(v.Discount * 10));
                CreateCustomer_RegScore_ComboBox.Enabled = false;
                Lable_Score.Enabled = false;

            }
            else if(c is RegCustomer)
            {
                RegCustomer r = c as RegCustomer;
                CheckBox_Create_isVIP.Checked = false;
                CheckBox_Create_isVIP.Enabled = false;
                CreateCustomer_RegScore_ComboBox.SelectedIndex = (int)r.RegType;
                CreateCustomer_Discount_Input.SelectedIndex = 0;
                CreateCustomer_Discount_Input.Enabled = false;
                CreateCustomer_RegScore_ComboBox.Enabled = true;                
            }    

        }

        public void ClearCreateBox()
        {
            Text_CreateName.Clear();
            Text_Create_Address.Clear();
            Date_Create_DOB.Value = DateTime.Now;
            CheckBox_Create_isVIP.Checked = false;
            string text = "Test";
            string caption = " TestCaption";
            if (currentMode == Mode.Create)
            {
                text = "Customer added successfully";
                caption = "Customer created";
            }                
            else if(currentMode==Mode.Edit)
            {
                text = "Customer Updated successfully";
                caption = "Customer Updated";
            }
            DialogResult result = MessageBox.Show(text,caption, MessageBoxButtons.OK);
        }

        public void Button_BackToMainForm_Click(object sender, EventArgs e)
        {
            currentMode = Mode.None;
            _mainForm.ReturnToMainForm();
            _mainForm.BringToFront();
            this.SendToBack();
            this.Size = MinimumSize;
            this.Location = new Point(0, 0);
        }

        private void Group_Cust_Properties_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox_Create_isVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Create_isVIP.Checked)
            {
                CreateCustomer_RegScore_ComboBox.Enabled = false;
                CreateCustomer_Score_Label.Enabled = false;
                CreateCustomer_VIPDiscount_Label.Enabled = true;
                CreateCustomer_Discount_Input.Enabled = true;                
            }

            else
            {
                CreateCustomer_RegScore_ComboBox.Enabled = true;
                CreateCustomer_Score_Label.Enabled = true;
                CreateCustomer_VIPDiscount_Label.Enabled = false;
                CreateCustomer_Discount_Input.Enabled = false;
                CreateCustomer_Discount_Input.SelectedItem = CreateCustomer_Discount_Input.Items[0];
            }
                
        }

        private void Button_DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete Customer: " + CustomerContainer.S.Find(int.Parse(Label_Num_Cust_ID.Text)).Name, "Delete Customer", MessageBoxButtons.YesNoCancel);
            switch (d)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    if (CustomerContainer.S.Find(int.Parse(Label_Num_Cust_ID.Text)) != null)
                    {
                        DataManager.S.DeleteCustomer(CustomerContainer.S.Find(int.Parse(Label_Num_Cust_ID.Text)));
                        CustomerContainer.S.Remove(CustomerContainer.S.Find(int.Parse(Label_Num_Cust_ID.Text)));
                        DataManager.S.SaveAllToBinary(CustomerContainer.S);
                        CustomerContainer.S.Init();
                        DialogResult dr = MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK);
                        EnableAll(false);
                        Button_DeleteCustomer.Enabled = false;
                        break;
                    }
                    else
                        break;                    
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            
        }

        public void EnableAll(bool on)
        {
            Label_Cust_ID.Enabled = on;
            Label_Num_Cust_ID.Enabled = on;
            Label_Name.Enabled = on;
            Label_TextName.Enabled = on;
            Label_Address.Enabled = on;
            Label_Text_Address.Enabled = on;
            Label_Dob.Enabled = on;
            Label_Date_Dob.Enabled = on;
            Label_Dor.Enabled = on;
            Label_Date_DOR.Enabled = on;
            Label_VIP.Enabled = on;
            Label_Customer_isVIP.Enabled = on;
            Label_Discount.Enabled = on;
            Combo_Discount.Enabled = on;
            Lable_Score.Enabled = on;
            Input_RegCustomerScore.Enabled = on;
        }

        private void Button_First_Click(object sender, EventArgs e)
        {
            ViewCustomer(0);
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Count: " + CustomerContainer.S.customers.Count);
            if (Label_Num_Cust_ID.Text == "0")
                ViewCustomer(CustomerContainer.S.customers[CustomerContainer.S.customers.Count-1].CustomerID);
            else
                ViewCustomer(CustomerContainer.S.customers[(int.Parse(Label_Num_Cust_ID.Text) - 1)].CustomerID);
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (int.Parse(Label_Num_Cust_ID.Text) == CustomerContainer.S.customers.Count-1)
                ViewCustomer(0);
            else
                ViewCustomer(CustomerContainer.S.customers[(int.Parse(Label_Num_Cust_ID.Text) + 1)].CustomerID);
        }

        private void Button_Last_Click(object sender, EventArgs e)
        {
            ViewCustomer(CustomerContainer.S.customers[CustomerContainer.S.customers.Count - 1].CustomerID);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitItemList()
        {
            string[] itemDetails = new string[ItemContainer.S.inventory.Count];
            for (int i = 0; i < ItemContainer.S.inventory.Count; i++)
            {
                string str = ItemContainer.S.inventory[i].ToString();
                itemDetails[i] = str;
            }
            
            ItemContainer.S.InitInventory();
            ItemList.Items.AddRange(itemDetails);
            
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            InitItemList();
        }

        private void Button_AddToPayment_Click(object sender, EventArgs e)
        {
            if(ItemList.CheckedIndices.Count > 1)
            {
                DialogResult d = MessageBox.Show("You can only add one item at a time", "Warning - Multiple Items Selected", MessageBoxButtons.OK);
            }
            else
            {
                Customer c = CustomerContainer.S.Find(int.Parse(Label_Num_Cust_ID.Text));
                List<Item> purchases = new List<Item>();
                foreach (int num in ItemList.CheckedIndices)
                {
                    c.items.Add(ItemContainer.S.Find(num));
                    purchases.Add(ItemContainer.S.Find(num));
                }
                foreach (Item purchase in purchases)
                {
                    if(c is VipCustomer)
                    {
                        VipCustomer v = c as VipCustomer;
                        v.AddToPayment(purchase.Price);                        
                    }
                    else
                    {
                        c.AddToPayment(purchase.Price);                        
                    }
                    
                }

                SetCustomerItemList(c);
                label_text_highestPrice.Text = c.GetHighestPrice().ToString();
                label_text_Total.Text = c.GetTotalAmount().ToString();
            }
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Label_Num_Cust_ID.Text = "N/A";
            Label_TextName.Text = "N/A";
            Label_Text_Address.Text = "N/A";
            Label_Date_Dob.Text = "N/A";
            Label_Date_DOR.Text = "N/A";
            Label_Customer_isVIP.Text = "N/A";
            Combo_Discount.SelectedIndex = 0;
            Input_RegCustomerScore.SelectedIndex = 3;
            label_text_Total.Text = "N/A";
            label_text_highestPrice.Text = "N/A";            
            listView1.Items.Clear();
            Button_AddToPayment.Enabled = false;

        }

        public void SetCustomerItemList(Customer c)
        {
            ListViewItem lvi = new ListViewItem();
            for (int i = 0; i < c.items.Count; i++)
            {
                lvi.SubItems.Insert(0, new ListViewItem.ListViewSubItem(lvi, (c.items[i].ProductSerialNum.ToString())));
                lvi.SubItems.Insert(1, new ListViewItem.ListViewSubItem(lvi, (c.items[i].Name.ToString())));
                if (c is VipCustomer)
                {
                    VipCustomer v = c as VipCustomer;
                    lvi.SubItems.Insert(2, new ListViewItem.ListViewSubItem(lvi, (c.items[i].Price * (1 - v.Discount)).ToString()));
                }
                else
                    lvi.SubItems.Insert(2, new ListViewItem.ListViewSubItem(lvi, (c.items[i].Price.ToString())));
            }
            listView1.Items.Add(lvi);
            listView1.View = View.Details;
        }
    }
}
