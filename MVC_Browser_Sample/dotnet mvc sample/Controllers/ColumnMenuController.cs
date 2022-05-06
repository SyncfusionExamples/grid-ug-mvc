using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static dotnet_mvc_sample.Controllers.OrdersDetailsController;


namespace dotnet_mvc_sample.Controllers
{
    public class ColumnMenuController : Controller
    {
        // GET: ColumnMenu
        public ActionResult ColumnMenuEvents()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult CustomColumnMenuItem()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult CustomizeMenuItemForParticularColumn()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult CustomizeIconOfColumnMenu()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}