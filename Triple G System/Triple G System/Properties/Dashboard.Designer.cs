
namespace Triple_G_System.Properties
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toSignUpButton = new System.Windows.Forms.Button();
            this.myTicketButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.updateDestinationButton = new System.Windows.Forms.Button();
            this.addDestinationButton = new System.Windows.Forms.Button();
            this.removeDestinationButton = new System.Windows.Forms.Button();
            this.bookTicketButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myTickets1 = new Triple_G_System.MyUserControls.MyTickets();
            this.removeDestination1 = new Triple_G_System.MyUserControls.RemoveDestination();
            this.updateDestinations1 = new Triple_G_System.MyUserControls.UpdateDestinations();
            this.bookTicket1 = new Triple_G_System.MyUserControls.BookTicket();
            this.addDestinations1 = new Triple_G_System.MyUserControls.addDestinations();
            this.welcomeUserControl1 = new Triple_G_System.MyUserControls.WelcomeUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.toSignUpButton);
            this.panel1.Controls.Add(this.myTicketButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.updateDestinationButton);
            this.panel1.Controls.Add(this.addDestinationButton);
            this.panel1.Controls.Add(this.removeDestinationButton);
            this.panel1.Controls.Add(this.bookTicketButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 475);
            this.panel1.TabIndex = 0;
            // 
            // toSignUpButton
            // 
            this.toSignUpButton.Location = new System.Drawing.Point(132, 434);
            this.toSignUpButton.Name = "toSignUpButton";
            this.toSignUpButton.Size = new System.Drawing.Size(68, 26);
            this.toSignUpButton.TabIndex = 7;
            this.toSignUpButton.Text = "SignUp";
            this.toSignUpButton.UseVisualStyleBackColor = true;
            this.toSignUpButton.Click += new System.EventHandler(this.toSignUpButton_Click);
            // 
            // myTicketButton
            // 
            this.myTicketButton.Location = new System.Drawing.Point(21, 93);
            this.myTicketButton.Name = "myTicketButton";
            this.myTicketButton.Size = new System.Drawing.Size(160, 32);
            this.myTicketButton.TabIndex = 6;
            this.myTicketButton.Text = "My Tickets";
            this.myTicketButton.UseVisualStyleBackColor = true;
            this.myTicketButton.Click += new System.EventHandler(this.myTicketButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(132, 434);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(68, 26);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 434);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(65, 26);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // updateDestinationButton
            // 
            this.updateDestinationButton.Location = new System.Drawing.Point(21, 93);
            this.updateDestinationButton.Name = "updateDestinationButton";
            this.updateDestinationButton.Size = new System.Drawing.Size(160, 32);
            this.updateDestinationButton.TabIndex = 3;
            this.updateDestinationButton.Text = "Update Destinations";
            this.updateDestinationButton.UseVisualStyleBackColor = true;
            this.updateDestinationButton.Click += new System.EventHandler(this.updateDestinationButton_Click);
            // 
            // addDestinationButton
            // 
            this.addDestinationButton.Location = new System.Drawing.Point(21, 46);
            this.addDestinationButton.Name = "addDestinationButton";
            this.addDestinationButton.Size = new System.Drawing.Size(160, 32);
            this.addDestinationButton.TabIndex = 2;
            this.addDestinationButton.Text = "Add Destinations";
            this.addDestinationButton.UseVisualStyleBackColor = true;
            this.addDestinationButton.Click += new System.EventHandler(this.addDestinationButton_Click);
            // 
            // removeDestinationButton
            // 
            this.removeDestinationButton.Location = new System.Drawing.Point(21, 142);
            this.removeDestinationButton.Name = "removeDestinationButton";
            this.removeDestinationButton.Size = new System.Drawing.Size(160, 32);
            this.removeDestinationButton.TabIndex = 1;
            this.removeDestinationButton.Text = "Remove Destinations";
            this.removeDestinationButton.UseVisualStyleBackColor = true;
            this.removeDestinationButton.Click += new System.EventHandler(this.removeDestinationButton_Click);
            // 
            // bookTicketButton
            // 
            this.bookTicketButton.Location = new System.Drawing.Point(21, 46);
            this.bookTicketButton.Name = "bookTicketButton";
            this.bookTicketButton.Size = new System.Drawing.Size(160, 32);
            this.bookTicketButton.TabIndex = 0;
            this.bookTicketButton.Text = "Book Ticket";
            this.bookTicketButton.UseVisualStyleBackColor = true;
            this.bookTicketButton.Click += new System.EventHandler(this.bookTicketButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.myTickets1);
            this.panel2.Controls.Add(this.removeDestination1);
            this.panel2.Controls.Add(this.updateDestinations1);
            this.panel2.Controls.Add(this.bookTicket1);
            this.panel2.Controls.Add(this.addDestinations1);
            this.panel2.Controls.Add(this.welcomeUserControl1);
            this.panel2.Location = new System.Drawing.Point(235, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 475);
            this.panel2.TabIndex = 1;
            // 
            // myTickets1
            // 
            this.myTickets1.BackColor = System.Drawing.Color.White;
            this.myTickets1.Location = new System.Drawing.Point(1, 1);
            this.myTickets1.Name = "myTickets1";
            this.myTickets1.Size = new System.Drawing.Size(610, 475);
            this.myTickets1.TabIndex = 5;
            // 
            // removeDestination1
            // 
            this.removeDestination1.BackColor = System.Drawing.Color.White;
            this.removeDestination1.Location = new System.Drawing.Point(0, 0);
            this.removeDestination1.Name = "removeDestination1";
            this.removeDestination1.Size = new System.Drawing.Size(610, 475);
            this.removeDestination1.TabIndex = 4;
            // 
            // updateDestinations1
            // 
            this.updateDestinations1.BackColor = System.Drawing.Color.White;
            this.updateDestinations1.Location = new System.Drawing.Point(0, 0);
            this.updateDestinations1.Name = "updateDestinations1";
            this.updateDestinations1.Size = new System.Drawing.Size(610, 475);
            this.updateDestinations1.TabIndex = 3;
            // 
            // bookTicket1
            // 
            this.bookTicket1.BackColor = System.Drawing.Color.White;
            this.bookTicket1.Location = new System.Drawing.Point(0, 0);
            this.bookTicket1.Name = "bookTicket1";
            this.bookTicket1.Size = new System.Drawing.Size(610, 475);
            this.bookTicket1.TabIndex = 2;
            // 
            // addDestinations1
            // 
            this.addDestinations1.BackColor = System.Drawing.Color.White;
            this.addDestinations1.Location = new System.Drawing.Point(0, 0);
            this.addDestinations1.Name = "addDestinations1";
            this.addDestinations1.Size = new System.Drawing.Size(610, 475);
            this.addDestinations1.TabIndex = 1;
            // 
            // welcomeUserControl1
            // 
            this.welcomeUserControl1.BackColor = System.Drawing.Color.White;
            this.welcomeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.welcomeUserControl1.Name = "welcomeUserControl1";
            this.welcomeUserControl1.Size = new System.Drawing.Size(610, 475);
            this.welcomeUserControl1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(857, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "4";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateDestinationButton;
        private System.Windows.Forms.Button addDestinationButton;
        private System.Windows.Forms.Button removeDestinationButton;
        private System.Windows.Forms.Button bookTicketButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel2;
        private MyUserControls.WelcomeUserControl welcomeUserControl1;
        private MyUserControls.addDestinations addDestinations1;
        private MyUserControls.BookTicket bookTicket1;
        private System.Windows.Forms.Button myTicketButton;
        private System.Windows.Forms.Button toSignUpButton;
        private MyUserControls.UpdateDestinations updateDestinations1;
        private MyUserControls.RemoveDestination removeDestination1;
        private MyUserControls.MyTickets myTickets1;
    }
}