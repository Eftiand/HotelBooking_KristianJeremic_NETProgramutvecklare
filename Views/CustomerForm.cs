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
    public partial class CustomerForm : Form
    {
        private CustomerRepo _customer;
        public CustomerForm()
        {
            InitializeComponent();
            SetSettings();
            _customer = new CustomerRepo();
        }
        void SetSettings()
        {
            CustomerGridView.Rows.Clear();


            var repo = new CustomerRepo();
            foreach (var item in repo.GetAll())
            {
                CustomerGridView.Rows.Add(item.ID, item.Name, item.Email, item.Age);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var customer = _customer.Get(SelectedRow);

            NameTextBox.Text = customer.Name;
            EmailTextBox.Text = customer.Email;
            AgeTextBox.Text = customer.Age.ToString();

        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var customer = _customer.Get(SelectedRow);
            customer.Name = NameTextBox.Text;
            customer.Email = EmailTextBox.Text;
            customer.Age = int.Parse(AgeTextBox.Text);

            _customer.Update(customer);

            MessageBox.Show("Customer updated");

            SetSettings();
        }
        private int SelectedRow
        {
            get {
                if (CustomerGridView.SelectedRows.Count > 0)
                {
                    return int.Parse(CustomerGridView.SelectedRows[0].Cells[0].Value.ToString());
                }
                return 0;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var customer = _customer.Get(SelectedRow);
            try
            {
                _customer.Remove(customer);
                MessageBox.Show("Customer deleted");
                SetSettings();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}
