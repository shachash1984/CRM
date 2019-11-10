namespace FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label_HeadLine = new System.Windows.Forms.Label();
            this.Button_AddCustomer = new System.Windows.Forms.Button();
            this.Group_Search = new System.Windows.Forms.GroupBox();
            this.Button_FindCustomer = new System.Windows.Forms.Button();
            this.Label_Search_ByID = new System.Windows.Forms.Label();
            this.TextBox_Search_CustomerByID = new System.Windows.Forms.RichTextBox();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Button_Delete_Cust = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Options_Label_SearchByID = new System.Windows.Forms.Label();
            this.Button_UpdateCustomer = new System.Windows.Forms.Button();
            this.Options_Input_SearchByID = new System.Windows.Forms.RichTextBox();
            this.Label_Options = new System.Windows.Forms.Label();
            this.Group_Summary_And_Options = new System.Windows.Forms.GroupBox();
            this.Button_RemoveAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIPDISCOUNT_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGSCORE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALAMT_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Group_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Group_Summary_And_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerContainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_HeadLine
            // 
            this.Label_HeadLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_HeadLine.AutoSize = true;
            this.Label_HeadLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label_HeadLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_HeadLine.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HeadLine.Location = new System.Drawing.Point(363, 100);
            this.Label_HeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HeadLine.Name = "Label_HeadLine";
            this.Label_HeadLine.Size = new System.Drawing.Size(405, 50);
            this.Label_HeadLine.TabIndex = 0;
            this.Label_HeadLine.Text = "Customer Manager";
            this.Label_HeadLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_AddCustomer
            // 
            this.Button_AddCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddCustomer.Location = new System.Drawing.Point(30, 166);
            this.Button_AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddCustomer.Name = "Button_AddCustomer";
            this.Button_AddCustomer.Size = new System.Drawing.Size(177, 59);
            this.Button_AddCustomer.TabIndex = 7;
            this.Button_AddCustomer.Text = "Add New Customer";
            this.Button_AddCustomer.UseVisualStyleBackColor = true;
            this.Button_AddCustomer.Click += new System.EventHandler(this.Button_AddCustomer_Click);
            // 
            // Group_Search
            // 
            this.Group_Search.BackColor = System.Drawing.Color.RoyalBlue;
            this.Group_Search.Controls.Add(this.Button_FindCustomer);
            this.Group_Search.Controls.Add(this.Label_Search_ByID);
            this.Group_Search.Controls.Add(this.TextBox_Search_CustomerByID);
            this.Group_Search.Controls.Add(this.Label_Search);
            this.Group_Search.Location = new System.Drawing.Point(15, 214);
            this.Group_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Search.Name = "Group_Search";
            this.Group_Search.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Search.Size = new System.Drawing.Size(535, 236);
            this.Group_Search.TabIndex = 10;
            this.Group_Search.TabStop = false;
            // 
            // Button_FindCustomer
            // 
            this.Button_FindCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FindCustomer.Location = new System.Drawing.Point(32, 174);
            this.Button_FindCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_FindCustomer.Name = "Button_FindCustomer";
            this.Button_FindCustomer.Size = new System.Drawing.Size(412, 44);
            this.Button_FindCustomer.TabIndex = 10;
            this.Button_FindCustomer.Text = "View Customer";
            this.Button_FindCustomer.UseVisualStyleBackColor = true;
            this.Button_FindCustomer.Click += new System.EventHandler(this.Button_FindCustomer_Click);
            // 
            // Label_Search_ByID
            // 
            this.Label_Search_ByID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Search_ByID.AutoSize = true;
            this.Label_Search_ByID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Search_ByID.Location = new System.Drawing.Point(29, 102);
            this.Label_Search_ByID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Search_ByID.Name = "Label_Search_ByID";
            this.Label_Search_ByID.Size = new System.Drawing.Size(160, 29);
            this.Label_Search_ByID.TabIndex = 11;
            this.Label_Search_ByID.Text = "Search By ID:";
            this.Label_Search_ByID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Search_CustomerByID
            // 
            this.TextBox_Search_CustomerByID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Search_CustomerByID.Location = new System.Drawing.Point(231, 105);
            this.TextBox_Search_CustomerByID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Search_CustomerByID.MaximumSize = new System.Drawing.Size(213, 29);
            this.TextBox_Search_CustomerByID.Name = "TextBox_Search_CustomerByID";
            this.TextBox_Search_CustomerByID.Size = new System.Drawing.Size(213, 29);
            this.TextBox_Search_CustomerByID.TabIndex = 10;
            this.TextBox_Search_CustomerByID.Text = "";
            // 
            // Label_Search
            // 
            this.Label_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Search.AutoSize = true;
            this.Label_Search.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Search.Location = new System.Drawing.Point(25, 20);
            this.Label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(333, 48);
            this.Label_Search.TabIndex = 9;
            this.Label_Search.Text = "Search Customer:";
            this.Label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Delete_Cust
            // 
            this.Button_Delete_Cust.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete_Cust.Location = new System.Drawing.Point(386, 166);
            this.Button_Delete_Cust.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Delete_Cust.Name = "Button_Delete_Cust";
            this.Button_Delete_Cust.Size = new System.Drawing.Size(154, 59);
            this.Button_Delete_Cust.TabIndex = 8;
            this.Button_Delete_Cust.Text = "Delete Customer";
            this.Button_Delete_Cust.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_Delete_Cust.UseVisualStyleBackColor = true;
            this.Button_Delete_Cust.Click += new System.EventHandler(this.Button_Delete_Cust_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.Options_Label_SearchByID);
            this.groupBox1.Controls.Add(this.Button_UpdateCustomer);
            this.groupBox1.Controls.Add(this.Options_Input_SearchByID);
            this.groupBox1.Controls.Add(this.Button_Delete_Cust);
            this.groupBox1.Controls.Add(this.Label_Options);
            this.groupBox1.Controls.Add(this.Button_AddCustomer);
            this.groupBox1.Location = new System.Drawing.Point(572, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Options_Label_SearchByID
            // 
            this.Options_Label_SearchByID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Options_Label_SearchByID.AutoSize = true;
            this.Options_Label_SearchByID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options_Label_SearchByID.Location = new System.Drawing.Point(25, 101);
            this.Options_Label_SearchByID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Options_Label_SearchByID.Name = "Options_Label_SearchByID";
            this.Options_Label_SearchByID.Size = new System.Drawing.Size(160, 29);
            this.Options_Label_SearchByID.TabIndex = 15;
            this.Options_Label_SearchByID.Text = "Search By ID:";
            this.Options_Label_SearchByID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_UpdateCustomer
            // 
            this.Button_UpdateCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpdateCustomer.Location = new System.Drawing.Point(215, 166);
            this.Button_UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UpdateCustomer.Name = "Button_UpdateCustomer";
            this.Button_UpdateCustomer.Size = new System.Drawing.Size(163, 59);
            this.Button_UpdateCustomer.TabIndex = 10;
            this.Button_UpdateCustomer.Text = "Update Customer";
            this.Button_UpdateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_UpdateCustomer.UseVisualStyleBackColor = true;
            this.Button_UpdateCustomer.Click += new System.EventHandler(this.Button_UpdateCustomer_Click);
            // 
            // Options_Input_SearchByID
            // 
            this.Options_Input_SearchByID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options_Input_SearchByID.Location = new System.Drawing.Point(229, 102);
            this.Options_Input_SearchByID.Margin = new System.Windows.Forms.Padding(4);
            this.Options_Input_SearchByID.MaximumSize = new System.Drawing.Size(213, 29);
            this.Options_Input_SearchByID.Name = "Options_Input_SearchByID";
            this.Options_Input_SearchByID.Size = new System.Drawing.Size(213, 29);
            this.Options_Input_SearchByID.TabIndex = 14;
            this.Options_Input_SearchByID.Text = "";
            // 
            // Label_Options
            // 
            this.Label_Options.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Options.AutoSize = true;
            this.Label_Options.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Options.Location = new System.Drawing.Point(21, 20);
            this.Label_Options.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Options.Name = "Label_Options";
            this.Label_Options.Size = new System.Drawing.Size(154, 48);
            this.Label_Options.TabIndex = 9;
            this.Label_Options.Text = "Options";
            this.Label_Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Group_Summary_And_Options
            // 
            this.Group_Summary_And_Options.BackColor = System.Drawing.Color.RoyalBlue;
            this.Group_Summary_And_Options.Controls.Add(this.dataGridView1);
            this.Group_Summary_And_Options.Location = new System.Drawing.Point(15, 461);
            this.Group_Summary_And_Options.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Summary_And_Options.Name = "Group_Summary_And_Options";
            this.Group_Summary_And_Options.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Summary_And_Options.Size = new System.Drawing.Size(1112, 371);
            this.Group_Summary_And_Options.TabIndex = 11;
            this.Group_Summary_And_Options.TabStop = false;
            // 
            // Button_RemoveAll
            // 
            this.Button_RemoveAll.BackColor = System.Drawing.Color.Red;
            this.Button_RemoveAll.Location = new System.Drawing.Point(15, 100);
            this.Button_RemoveAll.Name = "Button_RemoveAll";
            this.Button_RemoveAll.Size = new System.Drawing.Size(123, 70);
            this.Button_RemoveAll.TabIndex = 13;
            this.Button_RemoveAll.Text = "Remove All Customers";
            this.Button_RemoveAll.UseVisualStyleBackColor = false;
            this.Button_RemoveAll.Click += new System.EventHandler(this.Button_RemoveAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COL,
            this.NAME_COL,
            this.ADDRESS_COL,
            this.DOB_COL,
            this.DOR_COL,
            this.VIPDISCOUNT_COL,
            this.REGSCORE_COL,
            this.TOTALAMT_COL});
            this.dataGridView1.DataSource = this.customerContainerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ID_COL
            // 
            this.ID_COL.HeaderText = "ID";
            this.ID_COL.Name = "ID_COL";
            // 
            // NAME_COL
            // 
            this.NAME_COL.HeaderText = "Name";
            this.NAME_COL.Name = "NAME_COL";
            // 
            // ADDRESS_COL
            // 
            this.ADDRESS_COL.HeaderText = "Address";
            this.ADDRESS_COL.Name = "ADDRESS_COL";
            // 
            // DOB_COL
            // 
            this.DOB_COL.HeaderText = "Date of Birth";
            this.DOB_COL.Name = "DOB_COL";
            // 
            // DOR_COL
            // 
            this.DOR_COL.HeaderText = "Date of registration";
            this.DOR_COL.Name = "DOR_COL";
            // 
            // VIPDISCOUNT_COL
            // 
            this.VIPDISCOUNT_COL.HeaderText = "VIP Discount";
            this.VIPDISCOUNT_COL.Name = "VIPDISCOUNT_COL";
            // 
            // REGSCORE_COL
            // 
            this.REGSCORE_COL.HeaderText = "Score";
            this.REGSCORE_COL.Name = "REGSCORE_COL";
            // 
            // TOTALAMT_COL
            // 
            this.TOTALAMT_COL.HeaderText = "Total Amount";
            this.TOTALAMT_COL.Name = "TOTALAMT_COL";
            // 
            // customerContainerBindingSource
            // 
            this.customerContainerBindingSource.DataSource = typeof(FinalProject.CustomerContainer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1142, 822);
            this.Controls.Add(this.Button_RemoveAll);
            this.Controls.Add(this.Group_Summary_And_Options);
            this.Controls.Add(this.Group_Search);
            this.Controls.Add(this.Label_HeadLine);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(960, 540);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2396, 1338);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Group_Search.ResumeLayout(false);
            this.Group_Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Group_Summary_And_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerContainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_HeadLine;
        private System.Windows.Forms.Button Button_AddCustomer;
        private System.Windows.Forms.GroupBox Group_Search;
        private System.Windows.Forms.Label Label_Search_ByID;
        private System.Windows.Forms.RichTextBox TextBox_Search_CustomerByID;
        private System.Windows.Forms.Button Button_Delete_Cust;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_Options;
        private System.Windows.Forms.Button Button_FindCustomer;
        private System.Windows.Forms.BindingSource customerContainerBindingSource;
        private System.Windows.Forms.GroupBox Group_Summary_And_Options;
        private System.Windows.Forms.Button Button_UpdateCustomer;
        private System.Windows.Forms.Label Options_Label_SearchByID;
        public System.Windows.Forms.RichTextBox Options_Input_SearchByID;
        private System.Windows.Forms.Button Button_RemoveAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIPDISCOUNT_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGSCORE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALAMT_COL;
    }
}