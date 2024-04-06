﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DomainModel.Models;


namespace DataAccessLayer
{
    public class CustomerDataAccess
    {
        public void AddCustomer(Customers customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings
                ["CustomerFormConnectionString"].ConnectionString;

            string query = @"insert into CustomerForm
(FirstName, LastName, Email,PhoneNumber) values (@FirstName, @LastName, @Email, @PhoneNumber)";


            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, customer);
            }
        }
    }
}
