using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    [MetadataType(typeof(Order))]
    public class Order
    {
        
        public int OrderId { get; set; } //訂購編號

        [DisplayName("顧客編號")]
        public String CustomerId { get; set; } //顧客編號

        [DisplayName("員工編號")]
        public String EmployeeId { get; set; } //員工編號

        [DisplayName("出貨編號")]
        public String ShipperID { get; set; } //出貨編號

        [DisplayName("訂購日期")]
        public DateTime? OrderDate { get; set; } //訂購日期

        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; } //出貨日期

        [DisplayName("需要日期")]
        public DateTime? RequiredDate { get; set; } //需要日期

        [DisplayName("出貨國家")]
        public String ShipCountry { get; set; } //出貨國家

        [DisplayName("出貨城市")]
        public String ShipCity { get; set; } //出貨城市

        [DisplayName("出貨地區")]
        public String ShipRegion { get; set; } //出貨地區

        [DisplayName("出貨郵遞區號")]
        public String ShipPostalCode { get; set; } //郵遞區號

        [DisplayName("出貨地址")]
        public String ShipAddress { get; set; } //出貨地址

        [DisplayName("運費")]
        public Decimal Freight { get; set; } //運費
        
    }
}