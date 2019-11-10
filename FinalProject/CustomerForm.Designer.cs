using System.Windows;
using System.Windows.Forms;

namespace FinalProject
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.Group_Cust_Properties = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_text_Total = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_text_highestPrice = new System.Windows.Forms.Label();
            this.label_highestPrice = new System.Windows.Forms.Label();
            this.Lable_Cart = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.CheckedListBox();
            this.Button_AddToPayment = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductSerialNum_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_Name_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_Price_COL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Last = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Button_First = new System.Windows.Forms.Button();
            this.Button_DeleteCustomer = new System.Windows.Forms.Button();
            this.Combo_Discount = new System.Windows.Forms.ComboBox();
            this.Label_Discount = new System.Windows.Forms.Label();
            this.Input_RegCustomerScore = new System.Windows.Forms.ComboBox();
            this.Lable_Score = new System.Windows.Forms.Label();
            this.Label_Customer_isVIP = new System.Windows.Forms.Label();
            this.Label_VIP = new System.Windows.Forms.Label();
            this.Label_Date_DOR = new System.Windows.Forms.Label();
            this.Label_Date_Dob = new System.Windows.Forms.Label();
            this.Label_Text_Address = new System.Windows.Forms.Label();
            this.Label_TextName = new System.Windows.Forms.Label();
            this.Label_Num_Cust_ID = new System.Windows.Forms.Label();
            this.Label_Dor = new System.Windows.Forms.Label();
            this.Label_Dob = new System.Windows.Forms.Label();
            this.Label_Address = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Cust_ID = new System.Windows.Forms.Label();
            this.Group_CreateCustomer = new System.Windows.Forms.GroupBox();
            this.CreateCustomer_Discount_Input = new System.Windows.Forms.ComboBox();
            this.CreateCustomer_VIPDiscount_Label = new System.Windows.Forms.Label();
            this.CreateCustomer_RegScore_ComboBox = new System.Windows.Forms.ComboBox();
            this.CreateCustomer_Score_Label = new System.Windows.Forms.Label();
            this.Date_Create_DOB = new System.Windows.Forms.DateTimePicker();
            this.CheckBox_Create_isVIP = new System.Windows.Forms.CheckBox();
            this.Label_Create_VIP = new System.Windows.Forms.Label();
            this.Button_Save_Customer = new System.Windows.Forms.Button();
            this.Text_Create_Address = new System.Windows.Forms.RichTextBox();
            this.Text_CreateName = new System.Windows.Forms.RichTextBox();
            this.Label_CreateDOB = new System.Windows.Forms.Label();
            this.Label_CreateAddress = new System.Windows.Forms.Label();
            this.Label_CreateName = new System.Windows.Forms.Label();
            this.Button_BackToMainForm = new System.Windows.Forms.Button();
            this.customerContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Group_Cust_Properties.SuspendLayout();
            this.Group_CreateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_Cust_Properties
            // 
            this.Group_Cust_Properties.AutoSize = true;
            this.Group_Cust_Properties.BackgroundImage = global::FinalProject.Properties.Resources.sales;
            this.Group_Cust_Properties.Controls.Add(this.button_clear);
            this.Group_Cust_Properties.Controls.Add(this.label_text_Total);
            this.Group_Cust_Properties.Controls.Add(this.label_Total);
            this.Group_Cust_Properties.Controls.Add(this.label_text_highestPrice);
            this.Group_Cust_Properties.Controls.Add(this.label_highestPrice);
            this.Group_Cust_Properties.Controls.Add(this.Lable_Cart);
            this.Group_Cust_Properties.Controls.Add(this.ItemList);
            this.Group_Cust_Properties.Controls.Add(this.Button_AddToPayment);
            this.Group_Cust_Properties.Controls.Add(this.listView1);
            this.Group_Cust_Properties.Controls.Add(this.Button_Last);
            this.Group_Cust_Properties.Controls.Add(this.Button_Next);
            this.Group_Cust_Properties.Controls.Add(this.Button_Previous);
            this.Group_Cust_Properties.Controls.Add(this.Button_First);
            this.Group_Cust_Properties.Controls.Add(this.Button_DeleteCustomer);
            this.Group_Cust_Properties.Controls.Add(this.Combo_Discount);
            this.Group_Cust_Properties.Controls.Add(this.Label_Discount);
            this.Group_Cust_Properties.Controls.Add(this.Input_RegCustomerScore);
            this.Group_Cust_Properties.Controls.Add(this.Lable_Score);
            this.Group_Cust_Properties.Controls.Add(this.Label_Customer_isVIP);
            this.Group_Cust_Properties.Controls.Add(this.Label_VIP);
            this.Group_Cust_Properties.Controls.Add(this.Label_Date_DOR);
            this.Group_Cust_Properties.Controls.Add(this.Label_Date_Dob);
            this.Group_Cust_Properties.Controls.Add(this.Label_Text_Address);
            this.Group_Cust_Properties.Controls.Add(this.Label_TextName);
            this.Group_Cust_Properties.Controls.Add(this.Label_Num_Cust_ID);
            this.Group_Cust_Properties.Controls.Add(this.Label_Dor);
            this.Group_Cust_Properties.Controls.Add(this.Label_Dob);
            this.Group_Cust_Properties.Controls.Add(this.Label_Address);
            this.Group_Cust_Properties.Controls.Add(this.Label_Name);
            this.Group_Cust_Properties.Controls.Add(this.Label_Cust_ID);
            this.Group_Cust_Properties.Location = new System.Drawing.Point(59, 51);
            this.Group_Cust_Properties.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Cust_Properties.Name = "Group_Cust_Properties";
            this.Group_Cust_Properties.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Cust_Properties.Size = new System.Drawing.Size(700, 1200);
            this.Group_Cust_Properties.TabIndex = 0;
            this.Group_Cust_Properties.TabStop = false;
            this.Group_Cust_Properties.Enter += new System.EventHandler(this.Group_Cust_Properties_Enter);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Transparent;
            this.button_clear.Location = new System.Drawing.Point(498, 84);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(140, 28);
            this.button_clear.TabIndex = 29;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_text_Total
            // 
            this.label_text_Total.AutoSize = true;
            this.label_text_Total.Location = new System.Drawing.Point(252, 503);
            this.label_text_Total.Name = "label_text_Total";
            this.label_text_Total.Size = new System.Drawing.Size(16, 17);
            this.label_text_Total.TabIndex = 28;
            this.label_text_Total.Text = "0";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(33, 503);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(44, 17);
            this.label_Total.TabIndex = 27;
            this.label_Total.Text = "Total:";
            // 
            // label_text_highestPrice
            // 
            this.label_text_highestPrice.AutoSize = true;
            this.label_text_highestPrice.Location = new System.Drawing.Point(252, 545);
            this.label_text_highestPrice.Name = "label_text_highestPrice";
            this.label_text_highestPrice.Size = new System.Drawing.Size(16, 17);
            this.label_text_highestPrice.TabIndex = 26;
            this.label_text_highestPrice.Text = "0";
            // 
            // label_highestPrice
            // 
            this.label_highestPrice.AutoSize = true;
            this.label_highestPrice.Location = new System.Drawing.Point(33, 545);
            this.label_highestPrice.Name = "label_highestPrice";
            this.label_highestPrice.Size = new System.Drawing.Size(96, 17);
            this.label_highestPrice.TabIndex = 25;
            this.label_highestPrice.Text = "Highest Price:";
            // 
            // Lable_Cart
            // 
            this.Lable_Cart.AutoSize = true;
            this.Lable_Cart.Location = new System.Drawing.Point(35, 433);
            this.Lable_Cart.Name = "Lable_Cart";
            this.Lable_Cart.Size = new System.Drawing.Size(38, 17);
            this.Lable_Cart.TabIndex = 24;
            this.Lable_Cart.Text = "Cart:";
            // 
            // ItemList
            // 
            this.ItemList.CheckOnClick = true;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(24, 584);
            this.ItemList.Margin = new System.Windows.Forms.Padding(4);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(365, 106);
            this.ItemList.TabIndex = 23;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // Button_AddToPayment
            // 
            this.Button_AddToPayment.Location = new System.Drawing.Point(416, 584);
            this.Button_AddToPayment.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddToPayment.Name = "Button_AddToPayment";
            this.Button_AddToPayment.Size = new System.Drawing.Size(138, 106);
            this.Button_AddToPayment.TabIndex = 22;
            this.Button_AddToPayment.Text = "Add To Payment";
            this.Button_AddToPayment.UseVisualStyleBackColor = true;
            this.Button_AddToPayment.Click += new System.EventHandler(this.Button_AddToPayment_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductSerialNum_COL,
            this.Item_Name_COL,
            this.Item_Price_COL});
            this.listView1.Location = new System.Drawing.Point(255, 402);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(299, 76);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProductSerialNum_COL
            // 
            this.ProductSerialNum_COL.Text = "Product Serial Number";
            // 
            // Item_Name_COL
            // 
            this.Item_Name_COL.Text = "Item Name";
            // 
            // Item_Price_COL
            // 
            this.Item_Price_COL.Text = "Item Price";
            // 
            // Button_Last
            // 
            this.Button_Last.Location = new System.Drawing.Point(502, 698);
            this.Button_Last.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Last.Name = "Button_Last";
            this.Button_Last.Size = new System.Drawing.Size(51, 28);
            this.Button_Last.TabIndex = 20;
            this.Button_Last.Text = ">>";
            this.Button_Last.UseVisualStyleBackColor = true;
            this.Button_Last.Click += new System.EventHandler(this.Button_Last_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(374, 698);
            this.Button_Next.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(51, 28);
            this.Button_Next.TabIndex = 19;
            this.Button_Next.Text = ">";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Button_Previous
            // 
            this.Button_Previous.Location = new System.Drawing.Point(158, 698);
            this.Button_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(51, 28);
            this.Button_Previous.TabIndex = 18;
            this.Button_Previous.Text = "<";
            this.Button_Previous.UseVisualStyleBackColor = true;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Button_First
            // 
            this.Button_First.Location = new System.Drawing.Point(24, 698);
            this.Button_First.Margin = new System.Windows.Forms.Padding(4);
            this.Button_First.Name = "Button_First";
            this.Button_First.Size = new System.Drawing.Size(51, 28);
            this.Button_First.TabIndex = 17;
            this.Button_First.Text = "<<";
            this.Button_First.UseVisualStyleBackColor = true;
            this.Button_First.Click += new System.EventHandler(this.Button_First_Click);
            // 
            // Button_DeleteCustomer
            // 
            this.Button_DeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.Button_DeleteCustomer.Location = new System.Drawing.Point(498, 38);
            this.Button_DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DeleteCustomer.Name = "Button_DeleteCustomer";
            this.Button_DeleteCustomer.Size = new System.Drawing.Size(140, 28);
            this.Button_DeleteCustomer.TabIndex = 16;
            this.Button_DeleteCustomer.Text = "Delete Customer";
            this.Button_DeleteCustomer.UseVisualStyleBackColor = false;
            this.Button_DeleteCustomer.Click += new System.EventHandler(this.Button_DeleteCustomer_Click);
            // 
            // Combo_Discount
            // 
            this.Combo_Discount.Enabled = false;
            this.Combo_Discount.FormattingEnabled = true;
            this.Combo_Discount.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.Combo_Discount.Location = new System.Drawing.Point(255, 318);
            this.Combo_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Combo_Discount.Name = "Combo_Discount";
            this.Combo_Discount.Size = new System.Drawing.Size(121, 24);
            this.Combo_Discount.TabIndex = 15;
            // 
            // Label_Discount
            // 
            this.Label_Discount.AutoSize = true;
            this.Label_Discount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Discount.Location = new System.Drawing.Point(35, 325);
            this.Label_Discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Discount.Name = "Label_Discount";
            this.Label_Discount.Size = new System.Drawing.Size(67, 17);
            this.Label_Discount.TabIndex = 14;
            this.Label_Discount.Text = "Discount:";
            // 
            // Input_RegCustomerScore
            // 
            this.Input_RegCustomerScore.FormattingEnabled = true;
            this.Input_RegCustomerScore.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "PLATINUM",
            "N/A"});
            this.Input_RegCustomerScore.Location = new System.Drawing.Point(255, 361);
            this.Input_RegCustomerScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_RegCustomerScore.Name = "Input_RegCustomerScore";
            this.Input_RegCustomerScore.Size = new System.Drawing.Size(121, 24);
            this.Input_RegCustomerScore.TabIndex = 13;
            // 
            // Lable_Score
            // 
            this.Lable_Score.AutoSize = true;
            this.Lable_Score.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lable_Score.Location = new System.Drawing.Point(35, 368);
            this.Lable_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lable_Score.Name = "Lable_Score";
            this.Lable_Score.Size = new System.Drawing.Size(48, 17);
            this.Lable_Score.TabIndex = 12;
            this.Lable_Score.Text = "Score:";
            // 
            // Label_Customer_isVIP
            // 
            this.Label_Customer_isVIP.AutoSize = true;
            this.Label_Customer_isVIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Customer_isVIP.Location = new System.Drawing.Point(252, 283);
            this.Label_Customer_isVIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Customer_isVIP.Name = "Label_Customer_isVIP";
            this.Label_Customer_isVIP.Size = new System.Drawing.Size(25, 17);
            this.Label_Customer_isVIP.TabIndex = 11;
            this.Label_Customer_isVIP.Text = "No";
            // 
            // Label_VIP
            // 
            this.Label_VIP.AutoSize = true;
            this.Label_VIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_VIP.Location = new System.Drawing.Point(35, 283);
            this.Label_VIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_VIP.Name = "Label_VIP";
            this.Label_VIP.Size = new System.Drawing.Size(33, 17);
            this.Label_VIP.TabIndex = 10;
            this.Label_VIP.Text = "VIP:";
            // 
            // Label_Date_DOR
            // 
            this.Label_Date_DOR.AutoSize = true;
            this.Label_Date_DOR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Date_DOR.Location = new System.Drawing.Point(252, 234);
            this.Label_Date_DOR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Date_DOR.Name = "Label_Date_DOR";
            this.Label_Date_DOR.Size = new System.Drawing.Size(82, 17);
            this.Label_Date_DOR.TabIndex = 9;
            this.Label_Date_DOR.Text = "01/01/2017";
            // 
            // Label_Date_Dob
            // 
            this.Label_Date_Dob.AutoSize = true;
            this.Label_Date_Dob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Date_Dob.Location = new System.Drawing.Point(252, 183);
            this.Label_Date_Dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Date_Dob.Name = "Label_Date_Dob";
            this.Label_Date_Dob.Size = new System.Drawing.Size(82, 17);
            this.Label_Date_Dob.TabIndex = 8;
            this.Label_Date_Dob.Text = "27/07/1984";
            // 
            // Label_Text_Address
            // 
            this.Label_Text_Address.AutoSize = true;
            this.Label_Text_Address.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Text_Address.Location = new System.Drawing.Point(252, 135);
            this.Label_Text_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Text_Address.Name = "Label_Text_Address";
            this.Label_Text_Address.Size = new System.Drawing.Size(124, 17);
            this.Label_Text_Address.TabIndex = 7;
            this.Label_Text_Address.Text = "Street 12, Netanya";
            // 
            // Label_TextName
            // 
            this.Label_TextName.AutoSize = true;
            this.Label_TextName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_TextName.Location = new System.Drawing.Point(252, 89);
            this.Label_TextName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TextName.Name = "Label_TextName";
            this.Label_TextName.Size = new System.Drawing.Size(94, 17);
            this.Label_TextName.TabIndex = 6;
            this.Label_TextName.Text = "Fname Lname";
            // 
            // Label_Num_Cust_ID
            // 
            this.Label_Num_Cust_ID.AutoSize = true;
            this.Label_Num_Cust_ID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Num_Cust_ID.Location = new System.Drawing.Point(252, 44);
            this.Label_Num_Cust_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Num_Cust_ID.Name = "Label_Num_Cust_ID";
            this.Label_Num_Cust_ID.Size = new System.Drawing.Size(48, 17);
            this.Label_Num_Cust_ID.TabIndex = 5;
            this.Label_Num_Cust_ID.Text = "00000";
            // 
            // Label_Dor
            // 
            this.Label_Dor.AutoSize = true;
            this.Label_Dor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Dor.Location = new System.Drawing.Point(35, 234);
            this.Label_Dor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Dor.Name = "Label_Dor";
            this.Label_Dor.Size = new System.Drawing.Size(130, 17);
            this.Label_Dor.TabIndex = 4;
            this.Label_Dor.Text = "Date of registration:";
            // 
            // Label_Dob
            // 
            this.Label_Dob.AutoSize = true;
            this.Label_Dob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Dob.Location = new System.Drawing.Point(35, 183);
            this.Label_Dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Dob.Name = "Label_Dob";
            this.Label_Dob.Size = new System.Drawing.Size(90, 17);
            this.Label_Dob.TabIndex = 3;
            this.Label_Dob.Text = "Date of birth:";
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Address.Location = new System.Drawing.Point(35, 135);
            this.Label_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(61, 17);
            this.Label_Address.TabIndex = 2;
            this.Label_Address.Text = "Address:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Name.Location = new System.Drawing.Point(35, 89);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(48, 17);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "Name:";
            // 
            // Label_Cust_ID
            // 
            this.Label_Cust_ID.AutoSize = true;
            this.Label_Cust_ID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Cust_ID.Location = new System.Drawing.Point(35, 44);
            this.Label_Cust_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Cust_ID.Name = "Label_Cust_ID";
            this.Label_Cust_ID.Size = new System.Drawing.Size(91, 17);
            this.Label_Cust_ID.TabIndex = 0;
            this.Label_Cust_ID.Text = "Customer ID:";
            // 
            // Group_CreateCustomer
            // 
            this.Group_CreateCustomer.AutoSize = true;
            this.Group_CreateCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Group_CreateCustomer.BackgroundImage")));
            this.Group_CreateCustomer.Controls.Add(this.CreateCustomer_Discount_Input);
            this.Group_CreateCustomer.Controls.Add(this.CreateCustomer_VIPDiscount_Label);
            this.Group_CreateCustomer.Controls.Add(this.CreateCustomer_RegScore_ComboBox);
            this.Group_CreateCustomer.Controls.Add(this.CreateCustomer_Score_Label);
            this.Group_CreateCustomer.Controls.Add(this.Date_Create_DOB);
            this.Group_CreateCustomer.Controls.Add(this.CheckBox_Create_isVIP);
            this.Group_CreateCustomer.Controls.Add(this.Label_Create_VIP);
            this.Group_CreateCustomer.Controls.Add(this.Button_Save_Customer);
            this.Group_CreateCustomer.Controls.Add(this.Text_Create_Address);
            this.Group_CreateCustomer.Controls.Add(this.Text_CreateName);
            this.Group_CreateCustomer.Controls.Add(this.Label_CreateDOB);
            this.Group_CreateCustomer.Controls.Add(this.Label_CreateAddress);
            this.Group_CreateCustomer.Controls.Add(this.Label_CreateName);
            this.Group_CreateCustomer.Location = new System.Drawing.Point(81, 50);
            this.Group_CreateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.Group_CreateCustomer.Name = "Group_CreateCustomer";
            this.Group_CreateCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.Group_CreateCustomer.Size = new System.Drawing.Size(935, 1780);
            this.Group_CreateCustomer.TabIndex = 10;
            this.Group_CreateCustomer.TabStop = false;
            // 
            // CreateCustomer_Discount_Input
            // 
            this.CreateCustomer_Discount_Input.FormattingEnabled = true;
            this.CreateCustomer_Discount_Input.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.CreateCustomer_Discount_Input.Location = new System.Drawing.Point(309, 214);
            this.CreateCustomer_Discount_Input.Margin = new System.Windows.Forms.Padding(4);
            this.CreateCustomer_Discount_Input.Name = "CreateCustomer_Discount_Input";
            this.CreateCustomer_Discount_Input.Size = new System.Drawing.Size(160, 24);
            this.CreateCustomer_Discount_Input.TabIndex = 17;
            // 
            // CreateCustomer_VIPDiscount_Label
            // 
            this.CreateCustomer_VIPDiscount_Label.AutoSize = true;
            this.CreateCustomer_VIPDiscount_Label.Location = new System.Drawing.Point(35, 218);
            this.CreateCustomer_VIPDiscount_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateCustomer_VIPDiscount_Label.Name = "CreateCustomer_VIPDiscount_Label";
            this.CreateCustomer_VIPDiscount_Label.Size = new System.Drawing.Size(92, 17);
            this.CreateCustomer_VIPDiscount_Label.TabIndex = 16;
            this.CreateCustomer_VIPDiscount_Label.Text = "VIP Discount:";
            // 
            // CreateCustomer_RegScore_ComboBox
            // 
            this.CreateCustomer_RegScore_ComboBox.FormattingEnabled = true;
            this.CreateCustomer_RegScore_ComboBox.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "PLATINUM"});
            this.CreateCustomer_RegScore_ComboBox.Location = new System.Drawing.Point(309, 263);
            this.CreateCustomer_RegScore_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreateCustomer_RegScore_ComboBox.Name = "CreateCustomer_RegScore_ComboBox";
            this.CreateCustomer_RegScore_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.CreateCustomer_RegScore_ComboBox.TabIndex = 15;
            // 
            // CreateCustomer_Score_Label
            // 
            this.CreateCustomer_Score_Label.AutoSize = true;
            this.CreateCustomer_Score_Label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateCustomer_Score_Label.Location = new System.Drawing.Point(35, 267);
            this.CreateCustomer_Score_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateCustomer_Score_Label.Name = "CreateCustomer_Score_Label";
            this.CreateCustomer_Score_Label.Size = new System.Drawing.Size(112, 17);
            this.CreateCustomer_Score_Label.TabIndex = 14;
            this.CreateCustomer_Score_Label.Text = "Customer Score:";
            // 
            // Date_Create_DOB
            // 
            this.Date_Create_DOB.Location = new System.Drawing.Point(309, 123);
            this.Date_Create_DOB.Margin = new System.Windows.Forms.Padding(4);
            this.Date_Create_DOB.Name = "Date_Create_DOB";
            this.Date_Create_DOB.Size = new System.Drawing.Size(265, 22);
            this.Date_Create_DOB.TabIndex = 13;
            // 
            // CheckBox_Create_isVIP
            // 
            this.CheckBox_Create_isVIP.AutoSize = true;
            this.CheckBox_Create_isVIP.Location = new System.Drawing.Point(312, 174);
            this.CheckBox_Create_isVIP.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_Create_isVIP.Name = "CheckBox_Create_isVIP";
            this.CheckBox_Create_isVIP.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Create_isVIP.TabIndex = 12;
            this.CheckBox_Create_isVIP.UseVisualStyleBackColor = true;
            this.CheckBox_Create_isVIP.CheckedChanged += new System.EventHandler(this.CheckBox_Create_isVIP_CheckedChanged);
            // 
            // Label_Create_VIP
            // 
            this.Label_Create_VIP.AutoSize = true;
            this.Label_Create_VIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_Create_VIP.Location = new System.Drawing.Point(35, 171);
            this.Label_Create_VIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Create_VIP.Name = "Label_Create_VIP";
            this.Label_Create_VIP.Size = new System.Drawing.Size(33, 17);
            this.Label_Create_VIP.TabIndex = 11;
            this.Label_Create_VIP.Text = "VIP:";
            // 
            // Button_Save_Customer
            // 
            this.Button_Save_Customer.Location = new System.Drawing.Point(40, 313);
            this.Button_Save_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Save_Customer.Name = "Button_Save_Customer";
            this.Button_Save_Customer.Size = new System.Drawing.Size(463, 28);
            this.Button_Save_Customer.TabIndex = 10;
            this.Button_Save_Customer.Text = "Save Customer";
            this.Button_Save_Customer.UseVisualStyleBackColor = true;
            this.Button_Save_Customer.Click += new System.EventHandler(this.Button_Save_Customer_Click);
            // 
            // Text_Create_Address
            // 
            this.Text_Create_Address.Location = new System.Drawing.Point(309, 75);
            this.Text_Create_Address.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Create_Address.Name = "Text_Create_Address";
            this.Text_Create_Address.Size = new System.Drawing.Size(248, 32);
            this.Text_Create_Address.TabIndex = 7;
            this.Text_Create_Address.Text = "";
            // 
            // Text_CreateName
            // 
            this.Text_CreateName.Location = new System.Drawing.Point(309, 28);
            this.Text_CreateName.Margin = new System.Windows.Forms.Padding(4);
            this.Text_CreateName.Name = "Text_CreateName";
            this.Text_CreateName.Size = new System.Drawing.Size(248, 32);
            this.Text_CreateName.TabIndex = 5;
            this.Text_CreateName.Text = "";
            // 
            // Label_CreateDOB
            // 
            this.Label_CreateDOB.AutoSize = true;
            this.Label_CreateDOB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_CreateDOB.Location = new System.Drawing.Point(35, 127);
            this.Label_CreateDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CreateDOB.Name = "Label_CreateDOB";
            this.Label_CreateDOB.Size = new System.Drawing.Size(90, 17);
            this.Label_CreateDOB.TabIndex = 3;
            this.Label_CreateDOB.Text = "Date of birth:";
            // 
            // Label_CreateAddress
            // 
            this.Label_CreateAddress.AutoSize = true;
            this.Label_CreateAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_CreateAddress.Location = new System.Drawing.Point(35, 79);
            this.Label_CreateAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CreateAddress.Name = "Label_CreateAddress";
            this.Label_CreateAddress.Size = new System.Drawing.Size(61, 17);
            this.Label_CreateAddress.TabIndex = 2;
            this.Label_CreateAddress.Text = "Address:";
            // 
            // Label_CreateName
            // 
            this.Label_CreateName.AutoSize = true;
            this.Label_CreateName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_CreateName.Location = new System.Drawing.Point(35, 32);
            this.Label_CreateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CreateName.Name = "Label_CreateName";
            this.Label_CreateName.Size = new System.Drawing.Size(48, 17);
            this.Label_CreateName.TabIndex = 1;
            this.Label_CreateName.Text = "Name:";
            // 
            // Button_BackToMainForm
            // 
            this.Button_BackToMainForm.Location = new System.Drawing.Point(559, 15);
            this.Button_BackToMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.Button_BackToMainForm.MaximumSize = new System.Drawing.Size(140, 28);
            this.Button_BackToMainForm.Name = "Button_BackToMainForm";
            this.Button_BackToMainForm.Size = new System.Drawing.Size(140, 28);
            this.Button_BackToMainForm.TabIndex = 14;
            this.Button_BackToMainForm.Text = "Back to Main";
            this.Button_BackToMainForm.UseVisualStyleBackColor = true;
            this.Button_BackToMainForm.Click += new System.EventHandler(this.Button_BackToMainForm_Click);
            // 
            // customerContainerBindingSource
            // 
            this.customerContainerBindingSource.DataSource = typeof(FinalProject.CustomerContainer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(FinalProject.Customer);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 803);
            this.Controls.Add(this.Button_BackToMainForm);
            this.Controls.Add(this.Group_Cust_Properties);
            this.Controls.Add(this.Group_CreateCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(730, 850);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Group_Cust_Properties.ResumeLayout(false);
            this.Group_Cust_Properties.PerformLayout();
            this.Group_CreateCustomer.ResumeLayout(false);
            this.Group_CreateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_Cust_Properties;
        private System.Windows.Forms.Label Label_Cust_ID;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.Label Label_Dob;
        private System.Windows.Forms.Label Label_Dor;
        private System.Windows.Forms.Label Label_Num_Cust_ID;
        private System.Windows.Forms.Label Label_TextName;
        private System.Windows.Forms.Label Label_Text_Address;
        private System.Windows.Forms.Label Label_Date_DOR;
        private System.Windows.Forms.GroupBox Group_CreateCustomer;
        private System.Windows.Forms.Label Label_CreateDOB;
        private System.Windows.Forms.Label Label_CreateAddress;
        private System.Windows.Forms.Label Label_CreateName;
        private System.Windows.Forms.RichTextBox Text_CreateName;
        private System.Windows.Forms.RichTextBox Text_Create_Address;
        private System.Windows.Forms.Button Button_Save_Customer;
        private System.Windows.Forms.Label Label_Create_VIP;
        private System.Windows.Forms.CheckBox CheckBox_Create_isVIP;
        private System.Windows.Forms.Label Label_VIP;
        private System.Windows.Forms.Label Label_Customer_isVIP;
        private System.Windows.Forms.Label Label_Date_Dob;
        private System.Windows.Forms.DateTimePicker Date_Create_DOB;
        private Button Button_BackToMainForm;
        private ComboBox Input_RegCustomerScore;
        private Label CreateCustomer_Score_Label;
        private Label Lable_Score;
        private ComboBox CreateCustomer_RegScore_ComboBox;
        private Label CreateCustomer_VIPDiscount_Label;
        private ComboBox CreateCustomer_Discount_Input;
        private ComboBox Combo_Discount;
        private Label Label_Discount;
        public Button Button_DeleteCustomer;
        private Button Button_First;
        private Button Button_Next;
        private Button Button_Previous;
        private Button Button_Last;
        private ListView listView1;
        private ColumnHeader ProductSerialNum_COL;
        private ColumnHeader Item_Name_COL;
        private ColumnHeader Item_Price_COL;
        private BindingSource customerContainerBindingSource;
        private CheckedListBox ItemList;
        public Button Button_AddToPayment;
        private BindingSource customerBindingSource;
        private Label Lable_Cart;
        private Label label_text_Total;
        private Label label_Total;
        private Label label_text_highestPrice;
        private Label label_highestPrice;
        public Button button_clear;
    }
}