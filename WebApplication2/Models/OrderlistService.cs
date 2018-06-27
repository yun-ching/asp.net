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
    public class OrderlistService
    {
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }

        public List<Models.Orderlist> GetOrderlistByCondition(Models.OrderlistSearchArg arg)
        {
            List<Models.Orderlist> result = new List<Orderlist>();
            result.Add(new Orderlist() { OrderId = 1, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Orderlist() { OrderId = 2, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Orderlist() { OrderId = 3, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Orderlist() { OrderId = 4, OrderDate = Convert.ToDateTime("2006-07-08") });
            result.Add(new Orderlist() { OrderId = 5, OrderDate = Convert.ToDateTime("2006-07-08") });

            return result;
        }
        
        internal object GetOrderlistByCondition()
        {
            throw new NotImplementedException();
        }
    }
}