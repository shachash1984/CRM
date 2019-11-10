using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public static bool userAuthorized;
        public LoginForm()
        {
            InitializeComponent();
            userAuthorized = false;
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            userAuthorized = CheckPassword(userInputField.Text);
            if (userAuthorized)
                this.Close();
            else
                Application.Exit();
        }

        public bool CheckPassword(string userName)
        {
            foreach (User u in UserList.S.users)
            {
                if (u.UserName == userName && u.Password == passwordInputField.Text)
                    return true;
            }
            return false;
        }
    }

    
}
