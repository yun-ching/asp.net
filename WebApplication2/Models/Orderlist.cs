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
        public string OrderId { get; set; }

        public string CompanyName { get; set; }

        public string OrderDate { get; set; }

        public string ShippedDate { get; set; }

        public string RequiredDate { get; set; }
    }
}