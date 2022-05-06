using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static dotnet_mvc_sample.Controllers.OrdersDetailsController;

namespace dotnet_mvc_sample.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult HeaderText()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult HeaderTemplate()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult ChangeHeaderTextDynamically()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult ChangingOrientationOfHeaderText()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}