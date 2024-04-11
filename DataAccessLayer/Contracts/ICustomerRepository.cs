using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customers customer);

        public List<Customers> GetCustomers();
    }
}
