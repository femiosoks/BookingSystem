
namespace Triple_G_System.MyUserControls
{
    partial class MyTickets
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.departingSearchTextBox = new System.Windows.Forms.TextBox();
            this.myTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(378, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Click on row to Remove Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Leaving from";
            // 
            // departingSearchTextBox
            // 
            this.departingSearchTextBox.Location = new System.Drawing.Point(8, 74);
            this.departingSearchTextBox.Name = "departingSearchTextBox";
            this.departingSearchTextBox.PlaceholderText = "Search Departing station";
            this.departingSearchTextBox.Size = new System.Drawing.Size(186, 23);
            this.departingSearchTextBox.TabIndex = 39;
            this.departingSearchTextBox.TextChanged += new System.EventHandler(this.departingSearchTextBox_TextChanged);
            // 
            // myTicketsDataGridView
            // 
            this.myTicketsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.myTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTicketsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.myTicketsDataGridView.Location = new System.Drawing.Point(8, 103);
            this.myTicketsDataGridView.Name = "myTicketsDataGridView";
            this.myTicketsDataGridView.RowTemplate.Height = 25;
            this.myTicketsDataGridView.Size = new System.Drawing.Size(582, 324);
            this.myTicketsDataGridView.TabIndex = 38;
            this.myTicketsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myTicketsDataGridView_CellClick);
            this.myTicketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myTicketsDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "My Tickets";
            // 
            // MyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departingSearchTextBox);
            this.Controls.Add(this.myTicketsDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "MyTickets";
            this.Size = new System.Drawing.Size(610, 475);
            this.Load += new System.EventHandler(this.MyTickets_Load);
            this.Enter += new System.EventHandler(this.MyTickets_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.myTicketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox departingSearchTextBox;
        private System.Windows.Forms.DataGridView myTicketsDataGridView;
        private System.Windows.Forms.Label label2;
    }
}
