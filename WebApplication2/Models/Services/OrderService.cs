using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Dao;

namespace WebApplication2.Models.Services
{
    /// <summary>
    /// 提供訂單增刪改查的服務
    /// </summary>
    /// 
    public class OrderService
    {
        public List<Order> getAll()
        {
            DaoConnect daoConnect = new DaoConnect();
            SqlConnection conn = daoConnect.SqlConnect();

            //SQL
            string sql = "Select * From [Sales].Orders";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Order");

            List<Order> order = new List<Order>();
            order = dataSet.Tables[0].AsEnumerable().Select(
                dataRow => new Order()
                {
                    
                    OrderID = dataRow.Field<int>("OrderID"), //訂購編號

                    CustomerID = dataRow.Field<int>("CustomerID"), //顧客編號

                    EmployeeID = dataRow.Field<int>("EmployeeID"),//員工編號

                    ShipperID = dataRow.Field<int>("ShipperID"), //出貨編號

                    OrderDate = dataRow.Field<DateTime>("OrderDate"), //訂購日期

                    ShippedDate = dataRow.Field<DateTime?>("ShippedDate"), //出貨日期

                    RequiredDate = dataRow.Field<DateTime>("RequiredDate"),  //需要日期

                    ShipCountry = dataRow.Field<String>("ShipCountry").ToString(), //出貨國家

                    ShipCity = dataRow.Field<String>("ShipCity"), //出貨城市

                    ShipRegion = dataRow.Field<String>("ShipRegion"), //出貨地區

                    ShipPostalCode = dataRow.Field<String>("ShipPostalCode"), //郵遞區號

                    ShipAddress = dataRow.Field<String>("ShipAddress"), //出貨地址

                    Freight = dataRow.Field<decimal>("Freight") //運費

                }).ToList();

            return order;
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
