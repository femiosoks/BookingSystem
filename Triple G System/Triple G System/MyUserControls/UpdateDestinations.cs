using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triple_G_System.MyUserControls
{
    public partial class UpdateDestinations : UserControl
    {
        database da = new database();
        String query;

        public UpdateDestinations()
        {
            InitializeComponent();
        }



        private void UpdateDestinations_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch
            {

            }
        }

        public void loadData()
        {
            query = "select * from CoachDestination";
            DataSet ds = da.getData(query);
            UpdateDataGridView.DataSource = ds.Tables[0];
        }


        private void departingSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from CoachDestination where departing like '" + departingSearchTextBox.Text + "%'";
            DataSet ds = da.getData(query);
            UpdateDataGridView.DataSource = ds.Tables[0];
        }

        int id;
        private void UpdateDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(UpdateDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            string departing  = UpdateDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string arriving = UpdateDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(UpdateDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            string coach = UpdateDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            DepartingTextBox.Text = departing;
            ArrivingTextBox.Text = arriving;
            NewPriceTextBox.Text = price.ToString();
            NewCoachTextBox.Text = coach;
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            query = "update CoachDestination set price="+ NewPriceTextBox.Text+",coach = '"+NewCoachTextBox.Text+"' where lid = "+id+"";
            da.setData(query);
            MessageBox.Show("Destination details have been updated.", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();

            DepartingTextBox.Clear();
            ArrivingTextBox.Clear();
            NewPriceTextBox.Clear();
            NewCoachTextBox.Clear();
        }

        private void UpdateDestinations_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
