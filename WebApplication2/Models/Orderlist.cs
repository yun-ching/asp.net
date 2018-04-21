using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    
    public class Orderlist
    {
        
        public string OrderId { get; set; } //訂購編號

        public string ContactName { get; set; } //客戶名稱

        public string OrderDate { get; set; } //訂購日期

        public string ShippedDate { get; set; } //出貨日期

        public string RequiredDate { get; set; } //需要日期

        public string CompanyName { get; set; } //出貨公司名稱

        public string FirstName { get; set; } //員工姓名

        public string LastName { get; set; } //員工姓名

        public string ShipCountry { get; set; } //出貨國家

        public string ShipCity { get; set; } //出貨城市

        public string ShipRegion { get; set; } //出貨地區

        public string ShipPostalCode { get; set; } //郵遞區號

        public string ShipAddress { get; set; } //出貨地址
    }
}