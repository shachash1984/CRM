namespace FinalProject
{
    partial class LoginForm
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
            this.Button_Login = new System.Windows.Forms.Button();
            this.userInputField = new System.Windows.Forms.TextBox();
            this.passwordInputField = new System.Windows.Forms.TextBox();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(99, 132);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(75, 23);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // userInputField
            // 
            this.userInputField.Location = new System.Drawing.Point(152, 41);
            this.userInputField.Name = "userInputField";
            this.userInputField.Size = new System.Drawing.Size(100, 20);
            this.userInputField.TabIndex = 1;
            // 
            // passwordInputField
            // 
            this.passwordInputField.Location = new System.Drawing.Point(152, 88);
            this.passwordInputField.Name = "passwordInputField";
            this.passwordInputField.PasswordChar = '*';
            this.passwordInputField.Size = new System.Drawing.Size(100, 20);
            this.passwordInputField.TabIndex = 2;
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Location = new System.Drawing.Point(44, 44);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(60, 13);
            this.UserName_Label.TabIndex = 3;
            this.UserName_Label.Text = "UserName:";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(44, 88);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.Controls.Add(this.passwordInputField);
            this.Controls.Add(this.userInputField);
            this.Controls.Add(this.Button_Login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox userInputField;
        private System.Windows.Forms.TextBox passwordInputField;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label Password_Label;
    }
}