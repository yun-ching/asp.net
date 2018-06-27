using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Product
    {
        [DisplayName("產品編號")]
        public int ProductID { get; set; } //產品編號

        [DisplayName("產品名稱")]
        public string ProductName { get; set; } //產品名稱

        [DisplayName("單價")]
        public decimal UnitPrice { get; set; }//單價
    }
}