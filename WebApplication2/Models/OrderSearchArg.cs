using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class OrderSearchArg
    {
        [Display(Name = "訂購編號")]
        public int? OrderID { get; set; } //訂購編號

        [Display(Name = "客戶名稱")]
        public string CompanyName { get; set; } //客戶名稱

        [Display(Name = "員工編號")]
        public int? EmployeeID { get; set; } //員工編號

        [Display(Name = "出貨編號")]
        public int? ShipperID { get; set; } //出貨編號

        [Display(Name = "訂購日期")]
        public DateTime? OrderDate { get; set; } //訂購日期

        [Display(Name = "需要日期")]
        public DateTime? RequiredDate { get; set; } //需要日期

        [Display(Name = "出貨日期")]
        public DateTime? ShipedDate { get; set; } //出貨日期
    }
}