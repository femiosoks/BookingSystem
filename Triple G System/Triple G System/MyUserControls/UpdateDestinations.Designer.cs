
namespace Triple_G_System.MyUserControls
{
    partial class UpdateDestinations
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
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateDataGridView = new System.Windows.Forms.DataGridView();
            this.ArrivingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NewCoachTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DepartingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departingSearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update Coach Destination";
            // 
            // UpdateDataGridView
            // 
            this.UpdateDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UpdateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UpdateDataGridView.Location = new System.Drawing.Point(13, 105);
            this.UpdateDataGridView.Name = "UpdateDataGridView";
            this.UpdateDataGridView.RowTemplate.Height = 25;
            this.UpdateDataGridView.Size = new System.Drawing.Size(582, 206);
            this.UpdateDataGridView.TabIndex = 4;
            this.UpdateDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateDataGridView_CellClick);
            // 
            // ArrivingTextBox
            // 
            this.ArrivingTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ArrivingTextBox.ForeColor = System.Drawing.Color.Black;
            this.ArrivingTextBox.Location = new System.Drawing.Point(13, 407);
            this.ArrivingTextBox.Name = "ArrivingTextBox";
            this.ArrivingTextBox.PlaceholderText = "Arriving station";
            this.ArrivingTextBox.ReadOnly = true;
            this.ArrivingTextBox.Size = new System.Drawing.Size(186, 23);
            this.ArrivingTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Going to";
            // 
            // NewPriceTextBox
            // 
            this.NewPriceTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NewPriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewPriceTextBox.Location = new System.Drawing.Point(409, 351);
            this.NewPriceTextBox.Name = "NewPriceTextBox";
            this.NewPriceTextBox.PlaceholderText = "Price";
            this.NewPriceTextBox.Size = new System.Drawing.Size(186, 23);
            this.NewPriceTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(409, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(535, 445);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 30);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Coach";
            // 
            // NewCoachTextBox
            // 
            this.NewCoachTextBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NewCoachTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewCoachTextBox.Location = new System.Drawing.Point(409, 406);
            this.NewCoachTextBox.Name = "NewCoachTextBox";
            this.NewCoachTextBox.PlaceholderText = "Coach";
            this.NewCoachTextBox.Size = new System.Drawing.Size(186, 23);
            this.NewCoachTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Leaving from";
            // 
            // DepartingTextBox
            // 
            this.DepartingTextBox.Location = new System.Drawing.Point(13, 352);
            this.DepartingTextBox.Name = "DepartingTextBox";
            this.DepartingTextBox.PlaceholderText = "Departing Station";
            this.DepartingTextBox.ReadOnly = true;
            this.DepartingTextBox.Size = new System.Drawing.Size(186, 23);
            this.DepartingTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Leaving from";
            // 
            // departingSearchTextBox
            // 
            this.departingSearchTextBox.Location = new System.Drawing.Point(13, 75);
            this.departingSearchTextBox.Name = "departingSearchTextBox";
            this.departingSearchTextBox.PlaceholderText = "Search Departing station";
            this.departingSearchTextBox.Size = new System.Drawing.Size(186, 23);
            this.departingSearchTextBox.TabIndex = 17;
            this.departingSearchTextBox.TextChanged += new System.EventHandler(this.departingSearchTextBox_TextChanged);
            // 
            // UpdateDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departingSearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DepartingTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewCoachTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.NewPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArrivingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "UpdateDestinations";
            this.Size = new System.Drawing.Size(610, 475);
            this.Load += new System.EventHandler(this.UpdateDestinations_Load);
            this.Enter += new System.EventHandler(this.UpdateDestinations_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView UpdateDataGridView;
        private System.Windows.Forms.TextBox ArrivingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewCoachTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepartingTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox departingSearchTextBox;
    }
}
