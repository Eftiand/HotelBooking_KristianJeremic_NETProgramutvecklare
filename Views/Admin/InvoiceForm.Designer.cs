namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    partial class InvoiceForm
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
            this.LastDayToPayLabel = new System.Windows.Forms.Label();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InvoiceDataGrid = new System.Windows.Forms.DataGridView();
            this.IdText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDayToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceLabel = new System.Windows.Forms.Label();
            this.BookingIDAnswerLabel = new System.Windows.Forms.Label();
            this.PaidComboBox = new System.Windows.Forms.ComboBox();
            this.LastDayToPayAnswerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LastDayToPayLabel
            // 
            this.LastDayToPayLabel.AutoSize = true;
            this.LastDayToPayLabel.Location = new System.Drawing.Point(318, 126);
            this.LastDayToPayLabel.Name = "LastDayToPayLabel";
            this.LastDayToPayLabel.Size = new System.Drawing.Size(86, 13);
            this.LastDayToPayLabel.TabIndex = 30;
            this.LastDayToPayLabel.Text = "Last Day To Pay";
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Location = new System.Drawing.Point(318, 83);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(28, 13);
            this.PaidLabel.TabIndex = 28;
            this.PaidLabel.Text = "Paid";
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Location = new System.Drawing.Point(318, 41);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(57, 13);
            this.BookingIDLabel.TabIndex = 26;
            this.BookingIDLabel.Text = "BookingID";
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(321, 169);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(71, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(398, 169);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(71, 23);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InvoiceDataGrid
            // 
            this.InvoiceDataGrid.AllowUserToAddRows = false;
            this.InvoiceDataGrid.AllowUserToDeleteRows = false;
            this.InvoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdText,
            this.BookingID,
            this.Paid,
            this.LastDayToPay});
            this.InvoiceDataGrid.EnableHeadersVisualStyles = false;
            this.InvoiceDataGrid.Location = new System.Drawing.Point(12, 41);
            this.InvoiceDataGrid.MultiSelect = false;
            this.InvoiceDataGrid.Name = "InvoiceDataGrid";
            this.InvoiceDataGrid.ReadOnly = true;
            this.InvoiceDataGrid.RowHeadersVisible = false;
            this.InvoiceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDataGrid.Size = new System.Drawing.Size(303, 175);
            this.InvoiceDataGrid.TabIndex = 23;
            this.InvoiceDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDataGrid_CellClick);
            // 
            // IdText
            // 
            this.IdText.HeaderText = "ID";
            this.IdText.Name = "IdText";
            this.IdText.ReadOnly = true;
            this.IdText.Visible = false;
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            // 
            // LastDayToPay
            // 
            this.LastDayToPay.HeaderText = "LastDayToPay";
            this.LastDayToPay.Name = "LastDayToPay";
            this.LastDayToPay.ReadOnly = true;
            // 
            // InvoiceLabel
            // 
            this.InvoiceLabel.AutoSize = true;
            this.InvoiceLabel.Location = new System.Drawing.Point(13, 13);
            this.InvoiceLabel.Name = "InvoiceLabel";
            this.InvoiceLabel.Size = new System.Drawing.Size(47, 13);
            this.InvoiceLabel.TabIndex = 33;
            this.InvoiceLabel.Text = "Invoices";
            // 
            // BookingIDAnswerLabel
            // 
            this.BookingIDAnswerLabel.AutoSize = true;
            this.BookingIDAnswerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BookingIDAnswerLabel.Location = new System.Drawing.Point(381, 41);
            this.BookingIDAnswerLabel.Name = "BookingIDAnswerLabel";
            this.BookingIDAnswerLabel.Size = new System.Drawing.Size(34, 13);
            this.BookingIDAnswerLabel.TabIndex = 34;
            this.BookingIDAnswerLabel.Text = "Temp";
            // 
            // PaidComboBox
            // 
            this.PaidComboBox.FormattingEnabled = true;
            this.PaidComboBox.Location = new System.Drawing.Point(368, 80);
            this.PaidComboBox.Name = "PaidComboBox";
            this.PaidComboBox.Size = new System.Drawing.Size(61, 21);
            this.PaidComboBox.TabIndex = 35;
            this.PaidComboBox.Text = "false";
            // 
            // LastDayToPayAnswerLabel
            // 
            this.LastDayToPayAnswerLabel.AutoSize = true;
            this.LastDayToPayAnswerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LastDayToPayAnswerLabel.Location = new System.Drawing.Point(410, 126);
            this.LastDayToPayAnswerLabel.Name = "LastDayToPayAnswerLabel";
            this.LastDayToPayAnswerLabel.Size = new System.Drawing.Size(34, 13);
            this.LastDayToPayAnswerLabel.TabIndex = 36;
            this.LastDayToPayAnswerLabel.Text = "Temp";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(486, 242);
            this.Controls.Add(this.LastDayToPayAnswerLabel);
            this.Controls.Add(this.PaidComboBox);
            this.Controls.Add(this.BookingIDAnswerLabel);
            this.Controls.Add(this.InvoiceLabel);
            this.Controls.Add(this.LastDayToPayLabel);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.BookingIDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InvoiceDataGrid);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LastDayToPayLabel;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView InvoiceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDayToPay;
        private System.Windows.Forms.Label InvoiceLabel;
        private System.Windows.Forms.Label BookingIDAnswerLabel;
        private System.Windows.Forms.ComboBox PaidComboBox;
        private System.Windows.Forms.Label LastDayToPayAnswerLabel;
    }
}