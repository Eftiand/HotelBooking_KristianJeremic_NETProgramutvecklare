using System;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            InvoiceForm form = new InvoiceForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            AllBookingsForm form = new AllBookingsForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
