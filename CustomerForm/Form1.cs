using System.Text.RegularExpressions;
using DataAccessLayer.Repositories;
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

            CustomerRepository db = new CustomerRepository();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGridData();
        }
        private void RefreshGridData()
        {
            CustomerRepository db = new CustomerRepository();
            List<Customers> customers = db.GetCustomers();
            CustomerFormGrid.DataSource = customers;
        }
    }
}


