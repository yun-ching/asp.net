using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        // GET: Orderlist
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult OrderlistSearch()
        {
            Models.OrderService orderlistService = new Models.OrderService();
            var orderlist = orderlistService.GetOrderlistByCondition(new Models.OrderSearchArg()
            {

            });

            ViewBag.orderlist = orderlist;

           
            return View();
        }
        

        

    }
}