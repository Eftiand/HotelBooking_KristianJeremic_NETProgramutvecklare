using HotelBooking_KristianJeremic_NETProgramutvecklare.Classes;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Repository;
using System;
using System.Windows.Forms;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Views
{
    public partial class WorkerForm : Form
    {
        WorkerRepo _workerRepo;
        public WorkerForm()
        {
            InitializeComponent();
            _workerRepo = new WorkerRepo();
        }

        private void PinCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PinCodeTextBox.TextLength == 4)
                TryLogin();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TryLogin();
        }
        void TryLogin()
        {

            var worker = _workerRepo.Find(UserNameTextBox.Text, PinCodeTextBox.Text);

            if (worker != null)
            {
                MessageBox.Show($"Welcome {worker.Name}");
                AppInfo.LoggedInWorker = worker;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or pincode");
            }

        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                _workerRepo.Add(new Worker
                {
                    Name = UserNameTextBox.Text,
                    SecretCode = int.Parse(PinCodeTextBox.Text)
                });
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}