using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triple_G_System.MyUserControls
{
    public partial class addDestinations : UserControl
    {
        database da = new database();
        String query;
        bool parseAble;
        decimal inputedPrice;

        public addDestinations()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataTable table = da.getDataAsDataTable("select * from CoachDestination where departing = '" + departingComboBox.Text.Trim() + "' and arriving = '" + arrivingTextBox.Text.Trim() + "'");
            parseAble = decimal.TryParse(pricetextBox.Text, out inputedPrice);

            if (departingComboBox.SelectedIndex == -1 || arrivingTextBox.TextLength == 0 || pricetextBox.TextLength == 0 || coachTextBox.TextLength == 0)
            {
                MessageBox.Show("Please fill empty spaces.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
            else if (!parseAble)
            {
                MessageBox.Show("Price can only be in figures.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            else if (table.Rows.Count == 1)
            {
                MessageBox.Show("It seems Destination already exists, kindly move to Update or Remove Destinations", "Exact Destination Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                query = "insert into CoachDestination(departing, arriving, price, coach) values('" + departingComboBox.Text + "','" + arrivingTextBox.Text + "','" + pricetextBox.Text + "','" + coachTextBox.Text + "')";
                da.setData(query);
                MessageBox.Show("New destination saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            
        }

        public void clearAll()
        {
            coachTextBox.Clear();
            arrivingTextBox.Clear();
            pricetextBox.Clear();
            coachTextBox.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addDestinations_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void departingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
