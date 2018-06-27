using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication2.Models
{
    [MetadataType(typeof(Order))]
    public class Employee
    {

        [DisplayName("員工編號")]
        public int EmployeeID { get; set; } //員工編號

        [DisplayName("姓氏")]
        public string LastName { get; set; } //姓氏

        [DisplayName("名字")]
        public string FirstName { get; set; } //名字
    }
}