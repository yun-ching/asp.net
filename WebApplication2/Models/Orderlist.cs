using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    [MetadataType(typeof(Orderlist))]
    public class Orderlist
    {
        
        public int OrderId { get; set; } //訂購編號

        public String CustomerId { get; set; } //顧客編號

        public String EmployeeId { get; set; } //員工編號

        public String ShipperID { get; set; } //出貨編號

        public String CustomerName { get; set; } //顧客姓名

        public String EmployeeName { get; set; } //員工姓名

        public DateTime? OrderDate { get; set; } //訂購日期

        public DateTime? ShippedDate { get; set; } //出貨日期

        public DateTime? RequiredDate { get; set; } //需要日期

        public String CompanyName { get; set; } //出貨公司名稱

        public String ShipName { get; set; } //出貨姓名

        public String ShipCountry { get; set; } //出貨國家

        public String ShipCity { get; set; } //出貨城市

        public String ShipRegion { get; set; } //出貨地區

        public String ShipPostalCode { get; set; } //郵遞區號

        public String ShipAddress { get; set; } //出貨地址

        public Decimal Freight { get; set; } //貨物

        public string ProductID { get; set; } //產品編號

        public string ProductName { get; set; } //產品姓名

        public Decimal UnitPrice { get; set; } //單價

        public int Qty { get; set; } //數量

        public Decimal Discount { get; set; } //折扣
    }
}