namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    partial class IndexForm
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
            this.MonthCalenderLeft = new System.Windows.Forms.MonthCalendar();
            this.MonthCalenderRight = new System.Windows.Forms.MonthCalendar();
            this.AvailbeLabel = new System.Windows.Forms.Label();
            this.DatePickerLeft = new System.Windows.Forms.DateTimePicker();
            this.DatePickerRight = new System.Windows.Forms.DateTimePicker();
            this.BookingInternalSystemLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCalenderLeft
            // 
            this.MonthCalenderLeft.Location = new System.Drawing.Point(18, 270);
            this.MonthCalenderLeft.Name = "MonthCalenderLeft";
            this.MonthCalenderLeft.ShowTodayCircle = false;
            this.MonthCalenderLeft.TabIndex = 0;
            this.MonthCalenderLeft.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalenderLeft_DateChanged);
            // 
            // MonthCalenderRight
            // 
            this.MonthCalenderRight.Location = new System.Drawing.Point(256, 270);
            this.MonthCalenderRight.Name = "MonthCalenderRight";
            this.MonthCalenderRight.ShowTodayCircle = false;
            this.MonthCalenderRight.TabIndex = 1;
            this.MonthCalenderRight.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalenderRight_DateChanged);
            // 
            // AvailbeLabel
            // 
            this.AvailbeLabel.AutoSize = true;
            this.AvailbeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailbeLabel.Location = new System.Drawing.Point(18, 245);
            this.AvailbeLabel.Name = "AvailbeLabel";
            this.AvailbeLabel.Size = new System.Drawing.Size(85, 16);
            this.AvailbeLabel.TabIndex = 2;
            this.AvailbeLabel.Text = "Availble Dates";
            // 
            // DatePickerLeft
            // 
            this.DatePickerLeft.Location = new System.Drawing.Point(18, 210);
            this.DatePickerLeft.Name = "DatePickerLeft";
            this.DatePickerLeft.Size = new System.Drawing.Size(220, 20);
            this.DatePickerLeft.TabIndex = 3;
            // 
            // DatePickerRight
            // 
            this.DatePickerRight.Location = new System.Drawing.Point(256, 210);
            this.DatePickerRight.Name = "DatePickerRight";
            this.DatePickerRight.Size = new System.Drawing.Size(220, 20);
            this.DatePickerRight.TabIndex = 4;
            // 
            // BookingInternalSystemLabel
            // 
            this.BookingInternalSystemLabel.AutoSize = true;
            this.BookingInternalSystemLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingInternalSystemLabel.Location = new System.Drawing.Point(12, 9);
            this.BookingInternalSystemLabel.Name = "BookingInternalSystemLabel";
            this.BookingInternalSystemLabel.Size = new System.Drawing.Size(186, 21);
            this.BookingInternalSystemLabel.TabIndex = 5;
            this.BookingInternalSystemLabel.Text = "BookingInternalSystem";
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(12, 33);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(18, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 16);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(21, 91);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(217, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(21, 137);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(217, 20);
            this.EmailTextBox.TabIndex = 10;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(18, 120);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 16);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(259, 91);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(217, 20);
            this.AgeTextBox.TabIndex = 12;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(256, 74);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 16);
            this.AgeLabel.TabIndex = 11;
            this.AgeLabel.Text = "Age";
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(401, 134);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Create Booking";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BookingInternalSystemLabel);
            this.Controls.Add(this.DatePickerRight);
            this.Controls.Add(this.DatePickerLeft);
            this.Controls.Add(this.AvailbeLabel);
            this.Controls.Add(this.MonthCalenderRight);
            this.Controls.Add(this.MonthCalenderLeft);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalenderLeft;
        private System.Windows.Forms.MonthCalendar MonthCalenderRight;
        private System.Windows.Forms.Label AvailbeLabel;
        private System.Windows.Forms.DateTimePicker DatePickerLeft;
        private System.Windows.Forms.DateTimePicker DatePickerRight;
        private System.Windows.Forms.Label BookingInternalSystemLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button CreateButton;
    }
}