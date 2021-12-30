
namespace Triple_G_System
{
    partial class MyCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.totalPayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cvcCodeTextBox = new System.Windows.Forms.TextBox();
            this.exMonthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exYearTextBox = new System.Windows.Forms.TextBox();
            this.cardNumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VisaCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MasterCardCheckBox1 = new System.Windows.Forms.CheckBox();
            this.confirmPay = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(19, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Departure";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Arrival";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Coach";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(20, 431);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 25);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.Color.White;
            this.paymentPanel.Controls.Add(this.label9);
            this.paymentPanel.Controls.Add(this.totalPayLabel);
            this.paymentPanel.Controls.Add(this.label6);
            this.paymentPanel.Controls.Add(this.label5);
            this.paymentPanel.Controls.Add(this.label4);
            this.paymentPanel.Controls.Add(this.cvcCodeTextBox);
            this.paymentPanel.Controls.Add(this.exMonthTextBox);
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.exYearTextBox);
            this.paymentPanel.Controls.Add(this.cardNumbertextBox);
            this.paymentPanel.Controls.Add(this.label2);
            this.paymentPanel.Controls.Add(this.cardNameTextBox);
            this.paymentPanel.Controls.Add(this.label3);
            this.paymentPanel.Controls.Add(this.VisaCheckBox);
            this.paymentPanel.Controls.Add(this.pictureBox2);
            this.paymentPanel.Controls.Add(this.pictureBox1);
            this.paymentPanel.Controls.Add(this.MasterCardCheckBox1);
            this.paymentPanel.Location = new System.Drawing.Point(20, 233);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(799, 193);
            this.paymentPanel.TabIndex = 2;
            this.paymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentPanel_Paint);
            // 
            // totalPayLabel
            // 
            this.totalPayLabel.AutoSize = true;
            this.totalPayLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.totalPayLabel.Location = new System.Drawing.Point(740, 157);
            this.totalPayLabel.Name = "totalPayLabel";
            this.totalPayLabel.Size = new System.Drawing.Size(27, 19);
            this.totalPayLabel.TabIndex = 18;
            this.totalPayLabel.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(721, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(421, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "CVC Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(421, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expiration date";
            // 
            // cvcCodeTextBox
            // 
            this.cvcCodeTextBox.Location = new System.Drawing.Point(421, 153);
            this.cvcCodeTextBox.Name = "cvcCodeTextBox";
            this.cvcCodeTextBox.PlaceholderText = "000";
            this.cvcCodeTextBox.Size = new System.Drawing.Size(41, 23);
            this.cvcCodeTextBox.TabIndex = 14;
            this.cvcCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cvcCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvcCodeTextBox_KeyPress);
            // 
            // exMonthTextBox
            // 
            this.exMonthTextBox.Location = new System.Drawing.Point(421, 96);
            this.exMonthTextBox.Name = "exMonthTextBox";
            this.exMonthTextBox.PlaceholderText = "MM";
            this.exMonthTextBox.Size = new System.Drawing.Size(33, 23);
            this.exMonthTextBox.TabIndex = 13;
            this.exMonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exMonthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exMonthTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method";
            // 
            // exYearTextBox
            // 
            this.exYearTextBox.Location = new System.Drawing.Point(460, 96);
            this.exYearTextBox.Name = "exYearTextBox";
            this.exYearTextBox.PlaceholderText = "YYYY";
            this.exYearTextBox.Size = new System.Drawing.Size(71, 23);
            this.exYearTextBox.TabIndex = 12;
            this.exYearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exYearTextBox_KeyPress);
            // 
            // cardNumbertextBox
            // 
            this.cardNumbertextBox.Location = new System.Drawing.Point(39, 153);
            this.cardNumbertextBox.Name = "cardNumbertextBox";
            this.cardNumbertextBox.PlaceholderText = "5555555555555555";
            this.cardNumbertextBox.Size = new System.Drawing.Size(183, 23);
            this.cardNumbertextBox.TabIndex = 11;
            this.cardNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumbertextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Card Number";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(39, 96);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.PlaceholderText = "eg. John Smith";
            this.cardNameTextBox.Size = new System.Drawing.Size(183, 23);
            this.cardNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cardholder Name";
            // 
            // VisaCheckBox
            // 
            this.VisaCheckBox.AutoSize = true;
            this.VisaCheckBox.Location = new System.Drawing.Point(148, 33);
            this.VisaCheckBox.Name = "VisaCheckBox";
            this.VisaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.VisaCheckBox.TabIndex = 6;
            this.VisaCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MasterCardCheckBox1
            // 
            this.MasterCardCheckBox1.AutoSize = true;
            this.MasterCardCheckBox1.Location = new System.Drawing.Point(18, 33);
            this.MasterCardCheckBox1.Name = "MasterCardCheckBox1";
            this.MasterCardCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.MasterCardCheckBox1.TabIndex = 1;
            this.MasterCardCheckBox1.UseVisualStyleBackColor = true;
            // 
            // confirmPay
            // 
            this.confirmPay.Location = new System.Drawing.Point(721, 431);
            this.confirmPay.Name = "confirmPay";
            this.confirmPay.Size = new System.Drawing.Size(98, 25);
            this.confirmPay.TabIndex = 3;
            this.confirmPay.Text = "Confirm Pay";
            this.confirmPay.UseVisualStyleBackColor = true;
            this.confirmPay.Click += new System.EventHandler(this.confirmPay_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(721, 206);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 25);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "My Cart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Checkout";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(723, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "£";
            // 
            // MyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.confirmPay);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyCart";
            this.Text = "MyCart";
            this.Load += new System.EventHandler(this.MyCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.CheckBox MasterCardCheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cvcCodeTextBox;
        private System.Windows.Forms.TextBox exMonthTextBox;
        private System.Windows.Forms.TextBox exYearTextBox;
        private System.Windows.Forms.TextBox cardNumbertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox VisaCheckBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button confirmPay;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label totalPayLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
    }
}