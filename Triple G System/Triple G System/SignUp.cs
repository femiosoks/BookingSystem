using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Triple_G_System.Properties;

namespace Triple_G_System
{
    public partial class SignUp : Form
    {
        database da = new database();
        String query;

        public SignUp()
        {
            InitializeComponent();
        }

        public string validateEmail()
        {
            string emailAddress = emailTextBox.Text;
            return emailAddress;
        }

        public string validatePassword()
        {
            string password = passwordTextBox.Text;
            return password;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            DataTable table = da.getDataAsDataTable("select * from RegisteredUsers where emailAddress = '" + emailTextBox.Text.Trim() + "'");

            Users registeredUser = new Users();

            if (emailTextBox.TextLength == 0 && passwordTextBox.TextLength == 0 && confirmPasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please input your details.", "Empty Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

            else if (registeredUser.ValidEmail(validateEmail()))
            {
                MessageBox.Show("Please check your email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            

            else if (!registeredUser.ValidPassword(validatePassword()))
            {
                MessageBox.Show("Minimum Password length is 8 characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            
            else if (validatePassword() != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Your Password must match", "Unmatched Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            
            else if (table.Rows.Count == 1)
            {
                MessageBox.Show("It seems you already have an account with us, kindly move to login", "Email already exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else 
            {
                query = "insert into RegisteredUsers(emailAddress, password) values('" + emailTextBox.Text + "','"  + passwordTextBox.Text + "')";
                da.setData(query);
                MessageBox.Show("Please Login with your newly created account", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login ds = new Login();
                this.Hide();
                ds.Show();
            }

        }



        private void linkContinueBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ds = new Login();
            this.Hide();
            ds.Show();
        }
    }
}
