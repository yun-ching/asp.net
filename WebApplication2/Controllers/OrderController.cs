using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Services;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        // GET: Orderlist
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult SearchOrder()
        {
            OrderService orderService = new OrderService();
            List<Order> orderList = orderService.getAll();

            ViewBag.orderAllList = orderList;
            return View();
        }

        public ActionResult InsertOrder()
        {
            
            return View();
        }


    }
}