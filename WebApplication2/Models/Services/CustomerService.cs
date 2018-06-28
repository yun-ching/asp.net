using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Dao;

namespace WebApplication2.Models.Services
{
    public class CustomerService
    {
        public List<Customer> getAll()
        {
            DaoConnect daoConnect = new DaoConnect();
            SqlConnection conn = daoConnect.SqlConnect();

            //SQL
            string sql = "Select * From [Sales].Customer";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Customer");

            List<Customer> customer = new List<Customer>();
            customer = dataSet.Tables[0].AsEnumerable().Select(
                dataRow => new Customer()
                {
                    
                }).ToList();

            return customer;
        }

        public Customer getData(int CustomerID)
        {
            DaoConnect daoConnect = new DaoConnect();
            SqlConnection conn = daoConnect.SqlConnect();
            List<Customer> customer = new List<Customer>();
            customer = this.getAll();
            Customer customerData = customer.Single(m => m.CustomerID == CustomerID);

            return customerData;
        }
    }
}