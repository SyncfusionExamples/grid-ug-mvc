using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static dotnet_mvc_sample.Controllers.OrdersDetailsController;

namespace dotnet_mvc_sample.Controllers
{
    public class ColumnChooserController : Controller
    {
        // GET: ColumnChooser
        public ActionResult ColumnChooser()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public ActionResult OpenColumnChooserUsingExternalButton()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}