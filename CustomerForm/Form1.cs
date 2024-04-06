using System.Text.RegularExpressions;
using DataAccessLayer;
using DomainModel.Models;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = Regex.Replace(PhoneNumberText.Text, "[^0-9]", "");

            Customers customers = new Customers();

            customers.FirstName = FirstNameText.Text;
            customers.LastName = LastNameText.Text;
            customers.Email = EmailText.Text;
            customers.PhoneNumber = phoneNumber;

            CustomerDataAccess db = new CustomerDataAccess();
            db.AddCustomer(customers);
            ClearAllFields();

         
        }
        private void ClearAllFields()
        {
            FirstNameText.Text = default;
            LastNameText.Text = default;
            EmailText.Text = default;
            PhoneNumberText.Text = default;
        }
    }
}


