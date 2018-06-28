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

            List<Customer> employee = new List<Customer>();
            customer = dataSet.Tables[0].AsEnumerable().Select(
                dataRow => new Customer()
                {
                    
                }).ToList();

            return customer;
        }

        public Order getData(int OrderID)
        {
            DaoConnect daoConnect = new DaoConnect();
            SqlConnection conn = daoConnect.SqlConnect();
            List<Order> orderList = new List<Order>();
            orderList = this.getAll();
            Order orderData = orderList.Single(m => m.OrderID == OrderID);

            return orderData;
        }
    }
}