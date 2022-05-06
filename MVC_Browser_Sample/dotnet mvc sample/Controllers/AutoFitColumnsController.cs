using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static dotnet_mvc_sample.Controllers.OrdersDetailsController;
namespace dotnet_mvc_sample.Controllers
{
    public class AutoFitColumnsController : Controller
    {
        // GET: AutoFitColumns
        public ActionResult AutoFitColumns()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}