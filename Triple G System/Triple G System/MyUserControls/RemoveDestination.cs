using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triple_G_System.MyUserControls
{
    public partial class RemoveDestination : UserControl
    {
        database da = new database();
        String query;

        public RemoveDestination()
        {
            InitializeComponent();
        }

        private void RemoveDestination_Load(object sender, EventArgs e)
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
            removeDataGridView.DataSource = ds.Tables[0];
        }

        private void departingSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            query = "select * from CoachDestination where departing like '" + departingSearchTextBox.Text + "%'";
            DataSet ds = da.getData(query);
            removeDataGridView.DataSource = ds.Tables[0];
        }

        private void removeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Remove Coach Destination?", "Remove Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(removeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from CoachDestination where lid =" + id + "";
                da.setData(query);
                loadData();
            }
        }

        private void RemoveDestination_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
