
namespace Triple_G_System.MyUserControls
{
    partial class addDestinations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coachTextBox = new System.Windows.Forms.TextBox();
            this.arrivingTextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.departingComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Coach Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leaving from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Going to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // coachTextBox
            // 
            this.coachTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.coachTextBox.ForeColor = System.Drawing.Color.Black;
            this.coachTextBox.Location = new System.Drawing.Point(71, 393);
            this.coachTextBox.Name = "coachTextBox";
            this.coachTextBox.PlaceholderText = "Coach";
            this.coachTextBox.Size = new System.Drawing.Size(441, 23);
            this.coachTextBox.TabIndex = 4;
            // 
            // arrivingTextBox
            // 
            this.arrivingTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.arrivingTextBox.ForeColor = System.Drawing.Color.Black;
            this.arrivingTextBox.Location = new System.Drawing.Point(71, 219);
            this.arrivingTextBox.Name = "arrivingTextBox";
            this.arrivingTextBox.PlaceholderText = "Arriving station";
            this.arrivingTextBox.Size = new System.Drawing.Size(441, 23);
            this.arrivingTextBox.TabIndex = 5;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pricetextBox.ForeColor = System.Drawing.Color.Black;
            this.pricetextBox.Location = new System.Drawing.Point(71, 305);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.PlaceholderText = "Price";
            this.pricetextBox.Size = new System.Drawing.Size(441, 23);
            this.pricetextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(243, 422);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // departingComboBox
            // 
            this.departingComboBox.AccessibleDescription = "";
            this.departingComboBox.AllowDrop = true;
            this.departingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departingComboBox.FormattingEnabled = true;
            this.departingComboBox.Items.AddRange(new object[] {
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
            this.departingComboBox.Location = new System.Drawing.Point(71, 139);
            this.departingComboBox.Name = "departingComboBox";
            this.departingComboBox.Size = new System.Drawing.Size(441, 23);
            this.departingComboBox.TabIndex = 8;
            this.departingComboBox.SelectedIndexChanged += new System.EventHandler(this.departingComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Coach";
            // 
            // addDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departingComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.arrivingTextBox);
            this.Controls.Add(this.coachTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addDestinations";
            this.Size = new System.Drawing.Size(610, 475);
            this.Leave += new System.EventHandler(this.addDestinations_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coachTextBox;
        private System.Windows.Forms.TextBox arrivingTextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox departingComboBox;
        private System.Windows.Forms.Label label5;
    }
}
