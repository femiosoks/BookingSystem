
namespace Triple_G_System.MyUserControls
{
    partial class RemoveDestination
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
            this.label3 = new System.Windows.Forms.Label();
            this.departingSearchTextBox = new System.Windows.Forms.TextBox();
            this.removeDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.removeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Leaving from";
            // 
            // departingSearchTextBox
            // 
            this.departingSearchTextBox.Location = new System.Drawing.Point(15, 82);
            this.departingSearchTextBox.Name = "departingSearchTextBox";
            this.departingSearchTextBox.PlaceholderText = "Search Departing station";
            this.departingSearchTextBox.Size = new System.Drawing.Size(186, 23);
            this.departingSearchTextBox.TabIndex = 25;
            this.departingSearchTextBox.TextChanged += new System.EventHandler(this.departingSearchTextBox_TextChanged);
            // 
            // removeDataGridView
            // 
            this.removeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.removeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.removeDataGridView.Location = new System.Drawing.Point(15, 111);
            this.removeDataGridView.Name = "removeDataGridView";
            this.removeDataGridView.RowTemplate.Height = 25;
            this.removeDataGridView.Size = new System.Drawing.Size(582, 324);
            this.removeDataGridView.TabIndex = 20;
            this.removeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.removeDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Remove Coach Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(385, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Click on row to Remove Destination";
            // 
            // RemoveDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departingSearchTextBox);
            this.Controls.Add(this.removeDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "RemoveDestination";
            this.Size = new System.Drawing.Size(610, 475);
            this.Load += new System.EventHandler(this.RemoveDestination_Load);
            this.Enter += new System.EventHandler(this.RemoveDestination_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.removeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox departingSearchTextBox;
        private System.Windows.Forms.DataGridView removeDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}
