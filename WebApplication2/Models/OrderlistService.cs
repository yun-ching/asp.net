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
        public List<Models.Orderlist> GetOrderlistByCondtioin(Models.OrderlistSearchArg arg)
        {
            List<Models.Orderlist> result = new List<Orderlist>();
            result.Add(new Orderlist() { OrderId = "1", CompanyName = "Customer IBVRG", OrderDate = "2006-07-08" });
            result.Add(new Orderlist() { OrderId = "2", CompanyName = "Customer IBVRG", OrderDate = "2006-07-08" });
            result.Add(new Orderlist() { OrderId = "3", CompanyName = "Customer IBVRG", OrderDate = "2006-07-08" });
            result.Add(new Orderlist() { OrderId = "4", CompanyName = "Customer NRCSK", OrderDate = "2006-07-08" });
            result.Add(new Orderlist() { OrderId = "5", CompanyName = "Customer NRCSK", OrderDate = "2006-07-08" });

            return result;
        }

        internal object GetOrderlistByCondtioin()
        {
            throw new NotImplementedException();
        }
    }
}