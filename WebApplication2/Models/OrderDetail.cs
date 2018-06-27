using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class OrderDetail
    {

        public int OrderID { get; set; } //訂購編號

        [DisplayName("產品編號")]
        public int ProductID { get; set; } //產品編號

        [DisplayName("單價")]
        public decimal UnitPrice { get; set; } //單價

        [DisplayName("數量")]
        public int Qty { get; set; } //數量
    }
}