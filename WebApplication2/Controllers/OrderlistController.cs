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
            var orderlist = orderlistService.GetOrderlistByCondition(new Models.OrderlistSearchArg()
            {

            });

            ViewBag.orderlist = orderlist;

           
            return View();
        }
        

        

    }
}