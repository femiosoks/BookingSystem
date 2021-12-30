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
    public partial class MyCart : Form
    {

        public MyCart()
        {
            InitializeComponent();
            
        }

        private void MyCart_Load(object sender, EventArgs e)
        {
            
        }

        public string validateHolderName()
        {
            string holdername = cardNameTextBox.Text;
            return holdername;
        }

        public string validateCardNum()
        {
            string cardNum = cardNumbertextBox.Text;
            return cardNum;
        }

        public string validateExMonth()
        {
            string exMonth = exMonthTextBox.Text;
            return exMonth;
        }

        public string validateExYear()
        {
            string exYear = exYearTextBox.Text;
            return exYear;
        }

        public string validateCvcCode()
        {
            string cvcCode = cvcCodeTextBox.Text;
            return cvcCode;
        }



   
        private void paymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmPay_Click(object sender, EventArgs e)
        {

            Payment details = new Payment();

            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Ops, it seems you have removed your tickets", "Ticket not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (cardNameTextBox.TextLength == 0 || cardNumbertextBox.TextLength == 0 || exMonthTextBox.Text.Length == 0 || exYearTextBox.Text.Length == 0 || cvcCodeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all empty spaces.", "Empty Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (!details.ValidName(validateHolderName()))
            {
                MessageBox.Show("Please write the full name on the card", "Invalid Cardholder Name", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }



            else if (!details.ValidCardNumber(validateCardNum()))
            {
                MessageBox.Show("Card Number should be 16 digits", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (!details.ValidExMonth(validateExMonth()))
            {
                MessageBox.Show("Expiration Month should be 2 digits", "Invalid Expiration month", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (!details.ValidExYear(validateExYear()))
            {
                MessageBox.Show("Expiration Year should be 4 digits ", "Invalid Expiration Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (!details.ValidCvcCode(validateCvcCode()))
            {
                MessageBox.Show("CVC code is the 3 digits number at the back of your card", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MasterCardCheckBox1.CheckState== CheckState.Checked && VisaCheckBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Ops, it seems you checked the two payment methods", "Card Type Unknown", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (MasterCardCheckBox1.CheckState == CheckState.Unchecked && VisaCheckBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please check the card type", "Card Type Unknown", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

          

            else
            {
                MessageBox.Show("Congrats, Your ticket has been successfully saved to your local machine.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();
                cardNameTextBox.ResetText();
                cardNumbertextBox.ResetText();
                exMonthTextBox.ResetText();
                exYearTextBox.ResetText();
                cvcCodeTextBox.ResetText();
                MasterCardCheckBox1.ResetText();
                VisaCheckBox.ResetText();

                this.Hide();
                
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int cellAmount;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value != null)
            {
                cellAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please select row with ticket details to remove.", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cellAmount = 0;
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                int oldTotal = int.Parse(totalPayLabel.Text.ToString());
                int newTotal = oldTotal - cellAmount;
                totalPayLabel.Text = newTotal.ToString();
            }
            catch
            {
                MessageBox.Show("Please select the whole row by clicking on the row's first cell.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cardNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }

        }

        private void exMonthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void exYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cvcCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to go back, all unsaved data would be lost", "Back", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                cardNameTextBox.ResetText();
                cardNumbertextBox.ResetText();
                exMonthTextBox.ResetText();
                exYearTextBox.ResetText();
                cvcCodeTextBox.ResetText();
                MasterCardCheckBox1.ResetText();
                VisaCheckBox.ResetText();
                this.Hide();
            }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }

        }
    }
}
