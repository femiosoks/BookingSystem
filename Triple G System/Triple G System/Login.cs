using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triple_G_System.Properties;

namespace Triple_G_System
{

    public partial class Login : Form
    {
        public static string setForeignKey;
        database da = new database();
        

        public Login()
        {
            InitializeComponent();
        }

    

        private void linkContinueAsGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("GuestUser");
            ds.Show();
            this.Hide();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable table = da.getDataAsDataTable("select * from RegisteredUsers where emailAddress = '" + userNameTextBox.Text.Trim() + "' and password = '" + passwordTextBox.Text.Trim() + "'");
            if (table.Rows.Count == 1)
            { 
                setForeignKey = userNameTextBox.Text;
                Dashboard ds = new Dashboard("RegisteredUser");
                this.Hide();
                ds.Show();
            }

            else if (userNameTextBox.TextLength == 0 || passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Please input your details.", "Empty Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (userNameTextBox.Text == "Femi" && passwordTextBox.Text == "Osoks")
            {
                Dashboard ds = new Dashboard("AdminUser");
                this.Hide();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Please check your details.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp ds = new SignUp();
            ds.Show();
            this.Hide();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





