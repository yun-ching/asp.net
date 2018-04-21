using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderlistController : Controller
    {
        // GET: Orderlist
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult OrderlistSearch()
        {
            Models.OrderlistService orderlistService = new Models.OrderlistService();
            
            var orderlist = orderlistService.GetOrderlistByCondtioin(new Models.OrderlistSearchArg()
            {

            });

            ViewBag.orderlist = orderlist;

           
            return View();
        }

        public ActionResult insertcheck(string OrderId, string ContactName, DateTime OrderDate, DateTime ShippedDate, DateTime RequiredDate, string CompanyName, string FirstName, string LastName, string ShipCountry, string ShipCity, string ShipRegion, string ShipPostalCode, string ShipAddress)
        {

              
            return View();
        }

        [HttpPost]
        public ActionResult insertcheck(FormCollection post)
        {
            string  OrderId= post["OrderId"];
            string ContactName = post["ContactName"];
            DateTime OrderDate = Convert.ToDateTime(post["OrderDate"]);
            DateTime ShippedDate = Convert.ToDateTime(post["ShippedDate"]);
            DateTime RequiredDate = Convert.ToDateTime(post["RequiredDate"]);
            string CompanyName = post["CompanyName"];
            string FirstName = post["FirstName"];
            string LastName = post["LastName"];
            string ShipCountry = post["ShipCountry"];
            string ShipCity = post["ShipCity"];
            string ShipRegion = post["ShipRegion"];
            string ShipPostalCode = post["ShipPostalCode"];
            string ShipAddress = post["ShipAddress"];

            

            return View();
        }

    }
}