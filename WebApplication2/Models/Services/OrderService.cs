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








        public void Insert(Order ins)
        {
            DaoConnect daoConnect = new DaoConnect();
            SqlConnection conn = daoConnect.SqlConnect();

            string sql = @"INSERT INTO [Sales].[Orders]
                            ([CustomerID],[EmployeeID],[ShipperID],[OrderDate],[ShippedDate],[RequiredDate],[ShipCountry],[ShipCity],[ShipRegion],[ShipPostalCode],[ShipAddress],[Freight])
                           VALUE
                            (@CustomerID,@EmployeeID,@ShipperID,@OrderDate,@ShippedDate,@RequiredDate,@ShipCountry,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipAddress,@Freight)  SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@CustomerID", ins.CustomerID));
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", ins.EmployeeID));
            cmd.Parameters.Add(new SqlParameter("@ShipperID", ins.ShipperID));
            cmd.Parameters.Add(new SqlParameter("@OrderDate", ins.OrderDate));
            cmd.Parameters.Add(new SqlParameter("@ShippedDate", ins.ShippedDate));
            cmd.Parameters.Add(new SqlParameter("@RequiredDate", ins.RequiredDate));
            cmd.Parameters.Add(new SqlParameter("@ShipName", ""));
            cmd.Parameters.Add(new SqlParameter("@ShipCountry", ins.ShipCountry));
            cmd.Parameters.Add(new SqlParameter("@ShipCity", ins.ShipCity));
            cmd.Parameters.Add(new SqlParameter("@ShipRegion", ins.ShipRegion));
            cmd.Parameters.Add(new SqlParameter("@ShipPostalCode", ins.ShipPostalCode));
            cmd.Parameters.Add(new SqlParameter("@ShipAddress", ins.ShipAddress));
            cmd.Parameters.Add(new SqlParameter("@Freight", ins.Freight));

            conn.Open();
            int orderId = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
        }

    }
}
