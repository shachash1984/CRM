using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }
        CustomerForm cf = new CustomerForm();

        private void MainForm_Load(object sender, EventArgs e)
        {
            cf.currentMode = Mode.None;
            CustomerContainer.S.Init();
            Update();
        }

        private void Cf_FormClosing(object sender, FormClosingEventArgs e)
        {            
            //ReturnToMainForm();
            Console.WriteLine(CustomerContainer.S.ToString());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            cf.FormClosing -= Cf_FormClosing;
        }

        private void Button_AddCustomer_Click(object sender, EventArgs e)
        {
            if (cf == null)
                cf = new CustomerForm();
            cf.currentMode = Mode.Create;
            
            cf.Size = cf.MaximumSize;
            cf._mainForm = this;
            cf.CreateCustomer();                          
            cf.Show();
            cf.BringToFront();
            this.SendToBack();
            this.Size = MinimumSize;
            this.Location = new Point(0, 0);
            cf.FormClosing += Cf_FormClosing;
        }

        private void Button_FindCustomer_Click(object sender, EventArgs e)
        {
            cf.currentMode = Mode.View;
            ShowCustomer(TextBox_Search_CustomerByID, sender);
        }

        public void ReturnToMainForm()
        {            
            this.Size = MaximumSize;
            TextBox_Search_CustomerByID.Clear();            
            cf.FormClosing -= Cf_FormClosing;            
            Update();
        }

        public void Update()
        {
            List<Customer> customerList = new List<Customer>();
            customerList.AddRange(CustomerContainer.S.customers);
            dataGridView1.DataSource = customerList;
            Console.WriteLine("Update Customer count: "  + customerList.Count);
            try
            {               
                
                for (int i = 0; i < CustomerContainer.S.customers.Count; i++)
                {

                    if (dataGridView1.Rows[i].Cells[0].Value == null)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = CustomerContainer.S.customers[i].CustomerID;
                        dataGridView1.Rows[i].Cells[1].Value = CustomerContainer.S.customers[i].Name;
                        dataGridView1.Rows[i].Cells[2].Value = CustomerContainer.S.customers[i].Address;
                        dataGridView1.Rows[i].Cells[3].Value = CustomerContainer.S.customers[i].dob.ToString();
                        dataGridView1.Rows[i].Cells[4].Value = CustomerContainer.S.customers[i].dor.ToString();
                        if (CustomerContainer.S.customers[i] is VipCustomer)
                        {
                            VipCustomer v = CustomerContainer.S.customers[i] as VipCustomer;
                            Console.WriteLine("CellFormatting Discount: " + v.Discount);
                            dataGridView1.Rows[i].Cells[5].Value = (v.Discount * 100).ToString() + "%";
                            dataGridView1.Rows[i].Cells[6].Value = "N/A";
                        }
                        else
                        {
                            RegCustomer r = CustomerContainer.S.customers[i] as RegCustomer;
                            dataGridView1.Rows[i].Cells[5].Value = "N/A";
                            dataGridView1.Rows[i].Cells[6].Value = r.RegType.ToString();
                        }
                        dataGridView1.Rows[i].Cells[7].Value = CustomerContainer.S.customers[i].TotalAmount;
                    }                           
                }
            }
            catch (Exception h)
            {
                Console.WriteLine(h.Message + "\nTest Count: " + CustomerContainer.S.customers.Count + "\nrows count: " + dataGridView1.Rows.Count);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ShowCustomer(RichTextBox rtb, object sender)
        {
            try
            {
                if (cf == null)
                    cf = new CustomerForm();
                cf.Size = cf.MaximumSize;
                Customer c = CustomerContainer.S.Find(int.Parse(rtb.Text));
                if (c == null)
                {
                    DialogResult res = MessageBox.Show("\nCustomer not found", "Error", MessageBoxButtons.OK);
                    return;
                }
                    
                cf._mainForm = this;
                cf.ViewCustomer(c.CustomerID);
                cf.Show();
                cf.BringToFront();
                this.SendToBack();
                this.Size = MinimumSize;
                this.Location = new Point(0, 0);
                cf.FormClosing += Cf_FormClosing;
                if (rtb.Name.Contains("Options"))
                {
                    if(sender.Equals(Button_UpdateCustomer))
                    {
                        cf.Button_DeleteCustomer.Enabled = false;
                        cf.Button_DeleteCustomer.Visible = false;
                        cf.Button_AddToPayment.Enabled = false;
                        cf.button_clear.Enabled = false;
                        //allow field editing
                        //save new values
                        //cannot purchas while in update mode
                        
                    }

                    else if (sender.Equals(Button_Delete_Cust))
                    {      
                        cf.Button_DeleteCustomer.Enabled = true;
                        cf.Button_DeleteCustomer.Visible = true;
                        cf.Button_AddToPayment.Enabled = false;
                        cf.button_clear.Enabled = false;
                    }

                    else
                    {
                        cf.Button_DeleteCustomer.Enabled = false;
                        cf.Button_DeleteCustomer.Visible = false;
                        cf.Button_AddToPayment.Enabled = true;
                        cf.button_clear.Enabled = true;
                    }                 
                    
                    //IF DELETE customer
                    //allow deleting the customer and update the customer list
                }
                
            }            
            catch (Exception h)
            {
                DialogResult res = MessageBox.Show(h.Message + "\nCustomer not found", "Error", MessageBoxButtons.OK);              
            }
        }

        private void Button_UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                cf.currentMode = Mode.Edit;
                if (cf == null)
                    cf = new CustomerForm();
                cf.currentCustomerID = (int.Parse(Options_Input_SearchByID.Text));
                cf.UpdateCustomer(int.Parse(Options_Input_SearchByID.Text), out cf.currentCustomerID);            
            }
            
            catch (Exception h)
            {
                DialogResult res = MessageBox.Show("\nCustomer not found", "Error", MessageBoxButtons.OK);
            }

            cf.Size = cf.MaximumSize;
            cf._mainForm = this;
            cf.CreateCustomer();
            cf.Show();
            cf.BringToFront();
            this.SendToBack();
            this.Size = MinimumSize;
            this.Location = new Point(0, 0);
            cf.FormClosing += Cf_FormClosing;
            //show editing options
        }

        private void Button_Delete_Cust_Click(object sender, EventArgs e)
        {
            ShowCustomer(Options_Input_SearchByID, sender);

            //show delete option
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }

        private void Button_RemoveAll_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete all Customers?", "Warning - Delete All Customers", MessageBoxButtons.YesNoCancel);
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
                    DataManager.S.DeleteAll(CustomerContainer.S);                    
                    DialogResult f = MessageBox.Show("All Customers deleted successfully!", "Deleted all customers", MessageBoxButtons.OK);
                    CustomerContainer.S.Init();
                    ReturnToMainForm();
                    break;
                case DialogResult.No:                    
                    break;
                default:
                    break;
            }

            Update();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
