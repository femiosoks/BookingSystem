using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triple_G_System.MyUserControls
{
    public partial class MyTickets : UserControl
    {
        string foreignKey = Login.setForeignKey;
        database da = new database();
        String query;

        public MyTickets()
        {
            InitializeComponent();
        }

        private void MyTickets_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void myTicketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = ("select * from MyTickets where emailAddress = '" + foreignKey + "'");
            DataSet ds = da.getData(query);
            myTicketsDataGridView.DataSource = ds.Tables[0];
        }

        private void departingSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from MyTickets where emailAddress = '" + foreignKey + "' and departing like '" + departingSearchTextBox.Text + "%'";
            DataSet ds = da.getData(query);
            myTicketsDataGridView.DataSource = ds.Tables[0];
        }

        private void myTicketsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Ticket?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(myTicketsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()); 
                query = "delete from MyTickets where lid =" + id + "";
                da.setData(query);
                loadData();
                
            }
        }

        private void MyTickets_Enter(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
