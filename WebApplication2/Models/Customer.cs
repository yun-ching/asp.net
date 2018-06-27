using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Customer
    {
        [DisplayName("顧客編號")]
        public int CustomerID { get; set; } //顧客編號

        [DisplayName("公司名稱")]
        public string CompanyName { get; set; } //公司名稱

        [DisplayName("聯絡人名稱")]
        public string ContactName { get; set; } //聯絡人名稱

        [DisplayName("地址")]
        public string Address { get; set; } //地址
    }
}