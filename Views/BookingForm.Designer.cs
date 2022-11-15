namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    partial class BookingForm
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
            this.DateGridView = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.CheckInDateLabel = new System.Windows.Forms.Label();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.DateLeftLabel = new System.Windows.Forms.Label();
            this.DateRightLabel = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpotsTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpotsExtraBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DateGridView
            // 
            this.DateGridView.AllowUserToAddRows = false;
            this.DateGridView.AllowUserToDeleteRows = false;
            this.DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTxt,
            this.RoomTypeTxt,
            this.NameTxt,
            this.SpotsTxt,
            this.SpotsExtraBed});
            this.DateGridView.Location = new System.Drawing.Point(12, 112);
            this.DateGridView.MultiSelect = false;
            this.DateGridView.Name = "DateGridView";
            this.DateGridView.ReadOnly = true;
            this.DateGridView.RowHeadersVisible = false;
            this.DateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateGridView.Size = new System.Drawing.Size(404, 261);
            this.DateGridView.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(12, 83);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookButton.Location = new System.Drawing.Point(341, 83);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(75, 23);
            this.BookButton.TabIndex = 15;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // CheckInDateLabel
            // 
            this.CheckInDateLabel.AutoSize = true;
            this.CheckInDateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateLabel.Location = new System.Drawing.Point(89, 9);
            this.CheckInDateLabel.Name = "CheckInDateLabel";
            this.CheckInDateLabel.Size = new System.Drawing.Size(52, 16);
            this.CheckInDateLabel.TabIndex = 16;
            this.CheckInDateLabel.Text = "CheckIn";
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLabel.Location = new System.Drawing.Point(256, 9);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(63, 16);
            this.CheckOutLabel.TabIndex = 17;
            this.CheckOutLabel.Text = "CheckOut";
            // 
            // DateLeftLabel
            // 
            this.DateLeftLabel.AutoSize = true;
            this.DateLeftLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLeftLabel.Location = new System.Drawing.Point(89, 36);
            this.DateLeftLabel.Name = "DateLeftLabel";
            this.DateLeftLabel.Size = new System.Drawing.Size(37, 15);
            this.DateLeftLabel.TabIndex = 18;
            this.DateLeftLabel.Text = "Temp";
            // 
            // DateRightLabel
            // 
            this.DateRightLabel.AutoSize = true;
            this.DateRightLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRightLabel.Location = new System.Drawing.Point(256, 36);
            this.DateRightLabel.Name = "DateRightLabel";
            this.DateRightLabel.Size = new System.Drawing.Size(37, 15);
            this.DateRightLabel.TabIndex = 19;
            this.DateRightLabel.Text = "Temp";
            // 
            // IDTxt
            // 
            this.IDTxt.HeaderText = "ID";
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.ReadOnly = true;
            // 
            // RoomTypeTxt
            // 
            this.RoomTypeTxt.HeaderText = "RoomType";
            this.RoomTypeTxt.Name = "RoomTypeTxt";
            this.RoomTypeTxt.ReadOnly = true;
            // 
            // NameTxt
            // 
            this.NameTxt.HeaderText = "Name";
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            // 
            // SpotsTxt
            // 
            this.SpotsTxt.HeaderText = "Spots";
            this.SpotsTxt.Name = "SpotsTxt";
            this.SpotsTxt.ReadOnly = true;
            // 
            // SpotsExtraBed
            // 
            this.SpotsExtraBed.HeaderText = "Extra Beds";
            this.SpotsExtraBed.Name = "SpotsExtraBed";
            this.SpotsExtraBed.ReadOnly = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(429, 385);
            this.Controls.Add(this.DateRightLabel);
            this.Controls.Add(this.DateLeftLabel);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.CheckInDateLabel);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DateGridView);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DateGridView;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Label CheckInDateLabel;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.Label DateLeftLabel;
        private System.Windows.Forms.Label DateRightLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotsTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotsExtraBed;
    }
}