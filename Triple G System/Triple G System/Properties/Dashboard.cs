using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triple_G_System.Properties
{
    public partial class Dashboard : Form
    {


        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard( String Users)
        {
            InitializeComponent();
            if (Users == "GuestUser")
            {
                bookTicketButton.Show();
                toSignUpButton.Show();
                addDestinationButton.Hide();
                updateDestinationButton.Hide();
                removeDestinationButton.Hide();
                logoutButton.Hide();
                myTicketButton.Hide();
                
                
            }

            else if (Users == "AdminUser")
            {
                addDestinationButton.Show();
                updateDestinationButton.Show();
                removeDestinationButton.Show();
                logoutButton.Show();
                myTicketButton.Hide();
                bookTicketButton.Hide();
                toSignUpButton.Hide();
                
            }

            else if (Users == "RegisteredUser")
            {
                bookTicketButton.Show();
                logoutButton.Show();
                myTicketButton.Show();
                updateDestinationButton.Hide();
                removeDestinationButton.Hide();
                addDestinationButton.Hide();
                toSignUpButton.Hide();
              

            }


        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout, all unsaved data would be lost", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login fm = new Login();
                this.Hide();
                fm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
                      
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addDestinations1.Visible = false;
            bookTicket1.Visible = false;
            updateDestinations1.Visible = false;
            removeDestination1.Visible = false;
            myTickets1.Visible = false;


        }

        private void addDestinationButton_Click(object sender, EventArgs e)
        {
            addDestinations1.Visible = true;
            addDestinations1.BringToFront();
        }

        private void bookTicketButton_Click(object sender, EventArgs e)
        {
            bookTicket1.Visible = true;
            bookTicket1.BringToFront();
            
        }

        private void updateDestinationButton_Click(object sender, EventArgs e)
        {
            updateDestinations1.Visible = true;
            updateDestinations1.BringToFront();
         
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit, all unsaved data would be lost", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
   
        }

        private void toSignUpButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to SignUp, current data would be lost.", "SignUp", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SignUp ds = new SignUp();
                ds.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void removeDestinationButton_Click(object sender, EventArgs e)
        {
            removeDestination1.Visible = true;
            removeDestination1.BringToFront();
        }

        private void myTicketButton_Click(object sender, EventArgs e)
        {
            myTickets1.Visible = true;
            myTickets1.BringToFront();
        }

        private void updateDestinations1_Load(object sender, EventArgs e)
        {

        }
    }
}
