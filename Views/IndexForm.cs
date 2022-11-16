using HotelBooking_KristianJeremic_NETProgramutvecklare.Classes;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Repository;
using System;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class IndexForm : Form
    {
        int _counter = 0;
        public IndexForm()
        {
            InitializeComponent();
            SetSettings();
            CheckInvoicePayments();
        }
        void CheckInvoicePayments()
        {
            foreach (var item in new InvoiceRepo().GetAll())
            {
                if (item.Paid == false && item.LastDayToPay < DateTime.Now)
                {
                    new InvoiceRepo().Remove(item);
                    new BookingRepo().Remove(item.Booking);
                }

            }
        }
        void SetSettings()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hotel Booking";

            BookingRepo bookingRepo = new BookingRepo();
            //Put into the array of days that are not available
            MonthCalenderLeft.BoldedDates = bookingRepo.GetBookedDates;
            MonthCalenderRight.BoldedDates = bookingRepo.GetBookedDates;

            MonthCalenderRight.SelectionStart = DateTime.Now.AddDays(7);
            MonthCalenderLeft.MinDate = DateTime.Now;
            MonthCalenderRight.MinDate = DateTime.Now;

            AdjustForm();
        }
        void AdjustForm()
        {
            if (AppInfo.LoggedInWorker != null)
            {
                LoginButton.Text = "Logout";

                NameLabel.Visible = true;
                NameTextBox.Visible = true;

                AgeLabel.Visible = true;
                AgeTextBox.Visible = true;

                EmailLabel.Visible = true;
                EmailTextBox.Visible = true;

                BookButton.Visible = true;
                CustomerLabel.Visible = true;
                AdminButton.Visible = true;

                MinusButton.Visible = true;
                PlusButton.Visible = true;
                PeopleLabel.Visible = true;
                CounterLabel.Visible = true;
            }
            else
            {
                LoginButton.Text = "Login";
                NameLabel.Visible = false;
                NameTextBox.Visible = false;

                AgeLabel.Visible = false;
                AgeTextBox.Visible = false;

                EmailLabel.Visible = false;
                EmailTextBox.Visible = false;

                BookButton.Visible = false;
                CustomerLabel.Visible = false;
                AdminButton.Visible = false;

                MinusButton.Visible = false;
                PlusButton.Visible = false;
                PeopleLabel.Visible = false;
                CounterLabel.Visible = false;

            }
        }

        private void MonthCalenderLeft_DateChanged(object sender, DateRangeEventArgs e)
        {
            DatePickerLeft.Text = MonthCalenderLeft.SelectionStart.ToShortDateString();
        }

        private void MonthCalenderRight_DateChanged(object sender, DateRangeEventArgs e)
        {
            DatePickerRight.Text = MonthCalenderRight.SelectionStart.ToShortDateString();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginButton.Text == "Login")
            {
                var form = new WorkerForm();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
            else if (LoginButton.Text == "Logout")
            {
                AppInfo.LoggedInWorker = null;
            }
            AdjustForm();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = NameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text),
                Email = EmailTextBox.Text
            };

            var booking = new Booking
            {
                StartDate = DatePickerLeft.Value,
                EndDate = DatePickerRight.Value
            };

            BookingForm form = new BookingForm(booking, customer, _counter);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (_counter > 0)
                _counter--;
            CounterLabel.Text = _counter.ToString();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _counter++;
            CounterLabel.Text = _counter.ToString();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
