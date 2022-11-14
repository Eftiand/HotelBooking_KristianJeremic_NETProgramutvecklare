using HotelBooking_KristianJeremic_NETProgramutvecklare.Classes;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Repository;
using System;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            SetSettings();
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
            MonthCalenderRight.BoldedDates = new DateTime[] { };

            MonthCalenderRight.SelectionStart = DateTime.Now.AddDays(7);
            MonthCalenderLeft.MinDate = DateTime.Now;
            MonthCalenderRight.MinDate = DateTime.Now;
        }
        void AdjustForm()
        {
            if (AppInfo.LoggedInWorker != null)
            {
                LoginButton.Text = "Logout";
            }
            else
            {
                LoginButton.Text = "Login";
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
            if(LoginButton.Text == "Login")
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
    }
}
