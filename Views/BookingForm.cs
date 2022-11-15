using HotelBooking_KristianJeremic_NETProgramutvecklare.Classes;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class BookingForm : Form
    {
        private Customer _customer;
        private Booking _booking;
        private int _counter;
        public BookingForm(Booking booking, Customer customer,int counter)
        {
            InitializeComponent();
            _customer = customer;
            _booking = booking;
            _counter = counter;
            SetSettings();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetSettings()
        {
            var repo = new BookingRepo();

            foreach (var item in repo.GetAvailableRooms(_booking.StartDate, _booking.EndDate, _counter))
            {
                DateGridView.Rows.Add(item.ID, item.RoomType.Name, item.Name, item.RoomType.Spots,item.RoomType.AvailbleExtraBeds);
            }

            DateLeftLabel.Text = _booking.StartDate.ToShortDateString();
            DateRightLabel.Text = _booking.EndDate.ToShortDateString();

            int width = 80; 

            DateGridView.Columns[0].Width = width;
            DateGridView.Columns[1].Width = width;
            DateGridView.Columns[2].Width = width;
            DateGridView.Columns[3].Width = width;
            DateGridView.Columns[4].Width = width;
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            var customerRepo = new CustomerRepo();
            customerRepo.Add(_customer);

            var roomRepo = new RoomRepo();

            var repo = new BookingRepo();
            _booking.RoomID = roomRepo.Get(int.Parse(DateGridView.SelectedRows[0].Cells[0].Value.ToString())).ID;
            _booking.CustomerID = _customer.ID;
            _booking.WorkerID = AppInfo.LoggedInWorker.ID;
            repo.Add(_booking);

            MessageBox.Show("Booking created");

            this.Close();
        }
    }
}
