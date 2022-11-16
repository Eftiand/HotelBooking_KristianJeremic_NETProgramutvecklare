using HotelBooking_KristianJeremic_NETProgramutvecklare.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class InvoiceForm : Form
    {
        private InvoiceRepo _invoiceRepo;
        public InvoiceForm()
        {
            InitializeComponent();
            _invoiceRepo = new InvoiceRepo();
            SetSettings();
        }
        private void SetSettings()
        {
            InvoiceDataGrid.Rows.Clear();
            PaidComboBox.Items.Clear();

            PaidComboBox.Items.Add("true");
            PaidComboBox.Items.Add("false");

            InvoiceDataGrid.Rows.Clear();

            var result = _invoiceRepo.GetAll();
            foreach (var item in result)
            {
                InvoiceDataGrid.Rows.Add(item.ID, item.BookingID, item.Paid, item.LastDayToPay);
            }

        } 
        private int GetSelectedRow()
        {
            if (int.Parse(InvoiceDataGrid.SelectedRows[0].Cells[0].Value.ToString()) > 0)
            {
                return int.Parse(InvoiceDataGrid.SelectedRows[0].Cells[0].Value.ToString());    
            }
            return 0;
        }


        private void InvoiceDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = _invoiceRepo.Get(GetSelectedRow());
            BookingIDAnswerLabel.Text = selected.BookingID.ToString();
            PaidComboBox.Text = selected.Paid.ToString();
            LastDayToPayAnswerLabel.Text = selected.LastDayToPay.ToShortDateString().ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var selected = _invoiceRepo.Get(GetSelectedRow());
            if (PaidComboBox.Text == "false")
            {
                selected.Paid = false;
                selected.LastDayToPay = selected.Booking.StartDate.AddDays(10);
            }
            else
            {
                selected.Paid = true;
                selected.LastDayToPay = selected.Booking.EndDate;
            }

            _invoiceRepo.Update(selected);
            SetSettings();
            MessageBox.Show("Updated Invoice.");

        }
    }
}
