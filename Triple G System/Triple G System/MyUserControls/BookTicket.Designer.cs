
namespace Triple_G_System.MyUserControls
{
    partial class BookTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookTicketlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coachTextBox = new System.Windows.Forms.TextBox();
            this.availableDepartures = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ticketQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketDate = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.ticketTime = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arrivingSearch = new System.Windows.Forms.TextBox();
            this.availableArriving = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivingStationLabel = new System.Windows.Forms.Label();
            this.TimecomboBox = new System.Windows.Forms.ComboBox();
            this.DepartingStationLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.proceedToPayment = new System.Windows.Forms.Button();
            this.addToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTicketlabel
            // 
            this.bookTicketlabel.AutoSize = true;
            this.bookTicketlabel.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bookTicketlabel.Location = new System.Drawing.Point(11, 10);
            this.bookTicketlabel.Name = "bookTicketlabel";
            this.bookTicketlabel.Size = new System.Drawing.Size(140, 25);
            this.bookTicketlabel.TabIndex = 0;
            this.bookTicketlabel.Text = "Book Ticket";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(424, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(355, 354);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(185, 23);
            this.priceTextBox.TabIndex = 29;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(355, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Coach";
            // 
            // coachTextBox
            // 
            this.coachTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coachTextBox.Location = new System.Drawing.Point(355, 399);
            this.coachTextBox.Name = "coachTextBox";
            this.coachTextBox.ReadOnly = true;
            this.coachTextBox.Size = new System.Drawing.Size(86, 33);
            this.coachTextBox.TabIndex = 27;
            // 
            // availableDepartures
            // 
            this.availableDepartures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableDepartures.FormattingEnabled = true;
            this.availableDepartures.Items.AddRange(new object[] {
            "London Station",
            "Nottingham Station",
            "Coventry Station",
            "Yorkshire Station",
            "Birmingham Station",
            "Manchester Station",
            "Leeds Station",
            "Newcastle Station",
            "Liverpool Station",
            "Portsmouth Station",
            "Bristol Station",
            "Sheffield Station",
            "Leicester Station",
            "Edinburgh Station",
            "Reading Station",
            "Derby Station",
            "Plymouth Station",
            "Wolverhampton Station",
            "Middlesbrough Station",
            "Sunderland Station",
            "Warrington Station",
            "Huddersfield Station",
            "Oxford Station Station"});
            this.availableDepartures.Location = new System.Drawing.Point(11, 70);
            this.availableDepartures.Name = "availableDepartures";
            this.availableDepartures.Size = new System.Drawing.Size(131, 23);
            this.availableDepartures.TabIndex = 26;
            this.availableDepartures.SelectedIndexChanged += new System.EventHandler(this.availableDepartures_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(355, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(454, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(410, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quantity";
            // 
            // ticketQuantity
            // 
            this.ticketQuantity.Location = new System.Drawing.Point(355, 309);
            this.ticketQuantity.Name = "ticketQuantity";
            this.ticketQuantity.Size = new System.Drawing.Size(185, 23);
            this.ticketQuantity.TabIndex = 19;
            this.ticketQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketQuantity.ValueChanged += new System.EventHandler(this.ticketQuantity_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(430, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(433, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(424, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = " Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(424, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time";
            // 
            // ticketDate
            // 
            this.ticketDate.Location = new System.Drawing.Point(355, 219);
            this.ticketDate.Name = "ticketDate";
            this.ticketDate.ReadOnly = true;
            this.ticketDate.Size = new System.Drawing.Size(185, 23);
            this.ticketDate.TabIndex = 14;
            this.ticketDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(355, 174);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(185, 23);
            this.toTextBox.TabIndex = 13;
            this.toTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ticketTime
            // 
            this.ticketTime.Location = new System.Drawing.Point(355, 264);
            this.ticketTime.Name = "ticketTime";
            this.ticketTime.ReadOnly = true;
            this.ticketTime.Size = new System.Drawing.Size(185, 23);
            this.ticketTime.TabIndex = 12;
            this.ticketTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(355, 129);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(185, 23);
            this.fromTextBox.TabIndex = 11;
            this.fromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Time";
            // 
            // arrivingSearch
            // 
            this.arrivingSearch.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.arrivingSearch.Location = new System.Drawing.Point(155, 70);
            this.arrivingSearch.Name = "arrivingSearch";
            this.arrivingSearch.PlaceholderText = "Search";
            this.arrivingSearch.Size = new System.Drawing.Size(121, 22);
            this.arrivingSearch.TabIndex = 8;
            this.arrivingSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arrivingSearch.TextChanged += new System.EventHandler(this.arrivingSearch_TextChanged);
            // 
            // availableArriving
            // 
            this.availableArriving.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.availableArriving.FormattingEnabled = true;
            this.availableArriving.ItemHeight = 15;
            this.availableArriving.Location = new System.Drawing.Point(155, 98);
            this.availableArriving.Name = "availableArriving";
            this.availableArriving.Size = new System.Drawing.Size(121, 334);
            this.availableArriving.TabIndex = 7;
            this.availableArriving.SelectedIndexChanged += new System.EventHandler(this.availableArriving_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(288, 69);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // arrivingStationLabel
            // 
            this.arrivingStationLabel.AutoSize = true;
            this.arrivingStationLabel.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.arrivingStationLabel.Location = new System.Drawing.Point(155, 51);
            this.arrivingStationLabel.Name = "arrivingStationLabel";
            this.arrivingStationLabel.Size = new System.Drawing.Size(107, 16);
            this.arrivingStationLabel.TabIndex = 5;
            this.arrivingStationLabel.Text = "Arriving Station";
            // 
            // TimecomboBox
            // 
            this.TimecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimecomboBox.FormattingEnabled = true;
            this.TimecomboBox.Items.AddRange(new object[] {
            "6 am",
            "10 am",
            "2 pm",
            "6 pm"});
            this.TimecomboBox.Location = new System.Drawing.Point(505, 69);
            this.TimecomboBox.Name = "TimecomboBox";
            this.TimecomboBox.Size = new System.Drawing.Size(94, 23);
            this.TimecomboBox.TabIndex = 2;
            this.TimecomboBox.SelectedIndexChanged += new System.EventHandler(this.TimecomboBox_SelectedIndexChanged);
            // 
            // DepartingStationLabel
            // 
            this.DepartingStationLabel.AutoSize = true;
            this.DepartingStationLabel.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DepartingStationLabel.Location = new System.Drawing.Point(11, 51);
            this.DepartingStationLabel.Name = "DepartingStationLabel";
            this.DepartingStationLabel.Size = new System.Drawing.Size(116, 16);
            this.DepartingStationLabel.TabIndex = 1;
            this.DepartingStationLabel.Text = "Departing Station";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceTextBox.Location = new System.Drawing.Point(454, 399);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(86, 33);
            this.totalPriceTextBox.TabIndex = 32;
            // 
            // proceedToPayment
            // 
            this.proceedToPayment.Location = new System.Drawing.Point(454, 443);
            this.proceedToPayment.Name = "proceedToPayment";
            this.proceedToPayment.Size = new System.Drawing.Size(145, 23);
            this.proceedToPayment.TabIndex = 33;
            this.proceedToPayment.Text = "Proceed to Payment";
            this.proceedToPayment.UseVisualStyleBackColor = true;
            this.proceedToPayment.Click += new System.EventHandler(this.proceedToPayment_Click);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(324, 443);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(97, 23);
            this.addToCart.TabIndex = 34;
            this.addToCart.Text = "Add to Cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.proceedToPayment);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.coachTextBox);
            this.Controls.Add(this.availableDepartures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ticketQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketDate);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.ticketTime);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrivingSearch);
            this.Controls.Add(this.availableArriving);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.arrivingStationLabel);
            this.Controls.Add(this.TimecomboBox);
            this.Controls.Add(this.DepartingStationLabel);
            this.Controls.Add(this.bookTicketlabel);
            this.Name = "BookTicket";
            this.Size = new System.Drawing.Size(610, 475);
            ((System.ComponentModel.ISupportInitialize)(this.ticketQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox coachT;
        private System.Windows.Forms.Label bookTicketlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox coachTextBox;
        private System.Windows.Forms.ComboBox availableDepartures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ticketQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ticketDate;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox ticketTime;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrivingSearch;
        private System.Windows.Forms.ListBox availableArriving;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label arrivingStationLabel;
        private System.Windows.Forms.ComboBox TimecomboBox;
        private System.Windows.Forms.Label DepartingStationLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button proceedToPayment;
        private System.Windows.Forms.Button addToCart;
    }
}
