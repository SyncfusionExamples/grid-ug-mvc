using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotnet_mvc_sample.Models;
namespace dotnet_mvc_sample.Controllers
{
    public class ColumnReorderController : Controller
    {
        // GET: ColumnReorder
        public ActionResult ReorderSingleColumn()
        {
            var Emp = EmployeeView.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public ActionResult ReorderMultipleColumn()
        {
            var Emp = EmployeeView.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public ActionResult ReorderEvents()
        {
            var Emp = EmployeeView.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
    }
}