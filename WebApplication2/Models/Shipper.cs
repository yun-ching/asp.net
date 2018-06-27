using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Shipper
    {
        [DisplayName("出貨編號")]
        public int ShipperID { get; set; } //出貨編號

        [DisplayName("公司名稱")]
        public string CompanyName { get; set; } //公司名稱

        [DisplayName("電話")]
        public string Phone { get; set; } //電話
    }
}