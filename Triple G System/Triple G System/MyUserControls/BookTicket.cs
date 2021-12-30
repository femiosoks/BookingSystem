using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Triple_G_System.Properties;

namespace Triple_G_System.MyUserControls
{
    public partial class BookTicket : UserControl
    {
        MyCart cart = new MyCart();

        database da = new database();
        Login lg = new Login();
        String query;


       /* public BookTicket(MyCart ch)
        {
            InitializeComponent();
            this.cart = ch;
        }*/

        public BookTicket()
        {
            InitializeComponent();
        }



        private void availableDepartures_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Clearing existing data
            ticketQuantity.ResetText();
            toTextBox.ResetText();
            priceTextBox.ResetText();
            totalPriceTextBox.ResetText();
            coachTextBox.ResetText();
            ticketDate.ResetText();
            ticketTime.ResetText();

            String departures = availableDepartures.Text;
            query = "select * from CoachDestination where departing = '" + departures + "'";
            accessDatabase(query);

            String ticketFrom = availableDepartures.GetItemText(availableDepartures.SelectedItem);
            fromTextBox.Text = ticketFrom;
        }

        private void arrivingSearch_TextChanged(object sender, EventArgs e)
        {   
            String departures = availableDepartures.Text;
            query = "select * from CoachDestination where departing = '" + departures + "' and arriving like '" + arrivingSearch.Text + "%'";
            accessDatabase(query);
        }

        private void accessDatabase(String query)
        {
            availableArriving.Items.Clear();
            DataSet ds = da.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                availableArriving.Items.Add(ds.Tables[0].Rows[i][2].ToString());
            }
        }

        private void availableArriving_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clearing existing data
            ticketQuantity.ResetText();
            toTextBox.ResetText();
            totalPriceTextBox.ResetText();
            priceTextBox.ResetText();
            ticketDate.ResetText();
            ticketTime.ResetText();
            

            String ticketFrom = availableDepartures.GetItemText(availableDepartures.SelectedItem);
            String ticketTo = availableArriving.GetItemText(availableArriving.SelectedItem);
            toTextBox.Text = ticketTo;

            query = "select * from CoachDestination where departing = '" + ticketFrom + "' and arriving = '" + ticketTo + "'";
            DataSet ds = da.getData(query);

            try
            {
                priceTextBox.Text = ds.Tables[0].Rows[0][3].ToString();
                coachTextBox.Text = " "+ ds.Tables[0].Rows[0][4].ToString();
            }
            catch { }
        }

        private void TimecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String time = TimecomboBox.GetItemText(TimecomboBox.SelectedItem);
            ticketTime.Text = time;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            String date = dateTimePicker.Value.ToString("dddd,dd-MMMM-yyyy");
            ticketDate.Text = date;
        }

        private void ticketQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(toTextBox.TextLength ==0)
            {
                MessageBox.Show("Please select your destination.", "Empty Destination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ticketQuantity.ResetText();
            }
            else
            {
                Int64 ticketQuan = Int64.Parse(ticketQuantity.Value.ToString());
                Int64 price = Int64.Parse(priceTextBox.Text);
                totalPriceTextBox.Text = ( ticketQuan * price).ToString();
            }
            
        }

        
        int totalPay = 0;

        private void addToCart_Click(object sender, EventArgs e)
        {
            string foreignKey = Login.setForeignKey;

            if (fromTextBox.TextLength == 0 || toTextBox.TextLength == 0 || ticketDate.Text.Length == 0 || ticketTime.TextLength == 0 || ticketQuantity.Value.ToString() == "0" || coachTextBox.TextLength == 0 || totalPriceTextBox.TextLength == 0)
            {
                MessageBox.Show("All details have to be entered.", "Empty Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                query = "insert into MyTickets(emailAddress, departing, arriving, date, time, quantity, coach, price) values('" + foreignKey + "','" + fromTextBox.Text + "', '" + toTextBox.Text + "', '" + ticketDate.Text + "','" + ticketTime.Text + "', '" + ticketQuantity.Value.ToString() + "','" + coachTextBox.Text + "','" + totalPriceTextBox.Text + "')";
                da.setData(query);

                int n = cart.dataGridView1.Rows.Add();
               
                cart.dataGridView1.Rows[n].Cells[0].Value = fromTextBox.Text;
                cart.dataGridView1.Rows[n].Cells[1].Value = toTextBox.Text;
                cart.dataGridView1.Rows[n].Cells[2].Value = ticketDate.Text;
                cart.dataGridView1.Rows[n].Cells[3].Value = ticketTime.Text;
                cart.dataGridView1.Rows[n].Cells[4].Value = ticketQuantity.Value.ToString();
                cart.dataGridView1.Rows[n].Cells[5].Value = coachTextBox.Text;
                cart.dataGridView1.Rows[n].Cells[6].Value = totalPriceTextBox.Text;
                totalPay += int.Parse(totalPriceTextBox.Text);               
                MessageBox.Show("You can now proceed to payment.", "Successsfully added to cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ticketQuantity.ResetText();
                toTextBox.ResetText();
                priceTextBox.ResetText();
                totalPriceTextBox.ResetText();
                coachTextBox.ResetText();
                ticketDate.ResetText();
                ticketTime.ResetText();
                
                cart.totalPayLabel.Text =totalPay.ToString();
            }
           
        }

        private void proceedToPayment_Click(object sender, EventArgs e)
        {
            if (cart.dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Kindly add to cart first.", "Your cart is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cart.Show();
                this.Hide();
            }

        }

    }
 
}
