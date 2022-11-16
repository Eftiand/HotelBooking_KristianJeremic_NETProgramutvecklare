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
    public partial class AllBookingsForm : Form
    {
        private BookingRepo _bookingRepo;
        public AllBookingsForm()
        {
            InitializeComponent();
            _bookingRepo = new BookingRepo();
            SetSettings();
        }
        private void SetSettings()
        {
            BookingDataGrid.Rows.Clear();

            foreach (var item in _bookingRepo.GetAll())
            {
                BookingDataGrid.Rows.Add(item.ID, item.Customer.Name,item.Room.Name, item.StartDate, item.EndDate);
            }
        }

        private void BookingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = _bookingRepo.Get(GetSelectedRow());

            StartDatePicker.Text = result.StartDate.ToShortDateString();
            EndDatePicker.Text = result.EndDate.ToShortDateString();
        }
        private int GetSelectedRow()
        {
            if (int.Parse(BookingDataGrid.SelectedRows[0].Cells[0].Value.ToString()) > 0)
            {
                return int.Parse(BookingDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
            return 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = _bookingRepo.Get(GetSelectedRow());
                
            var invoiceRepo = new InvoiceRepo();
            invoiceRepo.Remove(invoiceRepo.GetAll().Where(x => x.BookingID == result.ID).FirstOrDefault());
            _bookingRepo.Remove(result.ID);
            SetSettings();
            MessageBox.Show("Booking/Invoice deleted");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = _bookingRepo.Get(GetSelectedRow());

            result.StartDate = StartDatePicker.Value;
            result.EndDate = EndDatePicker.Value;
            try
            {
                _bookingRepo.Update(result);
                MessageBox.Show("Updated Booking");
                SetSettings();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
