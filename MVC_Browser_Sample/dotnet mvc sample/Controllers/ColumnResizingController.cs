using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static dotnet_mvc_sample.Controllers.OrdersDetailsController;

namespace dotnet_mvc_sample.Controllers
{
    public class ColumnResizingController : Controller
    {
        // GET: ColumnResizing
        public ActionResult ColumnResizingUsingMethod()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult MinAndMaxWidth()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult ResizeStackedColumns()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult TouchInteraction()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult ResizingEvent()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}