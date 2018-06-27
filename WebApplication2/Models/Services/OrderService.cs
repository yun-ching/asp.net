using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    /// <summary>
    /// 提供訂單增刪改查的服務
    /// </summary>
    /// 
    public class OrderService
    {
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }

        public List<Models.Order> GetOrderlistByCondition(Models.OrderSearchArg arg)
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { OrderId = 1, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Order() { OrderId = 2, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Order() { OrderId = 3, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Order() { OrderId = 4, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Order() { OrderId = 5, OrderDate = Convert.ToDateTime("2006-07-08") });

            return result;
        }
        
        internal object GetOrderlistByCondition()
        {
            throw new NotImplementedException();
        }
    }
}