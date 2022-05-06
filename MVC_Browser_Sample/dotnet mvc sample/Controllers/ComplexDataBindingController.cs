using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotnet_mvc_sample.Models;


namespace dotnet_mvc_sample.Controllers
{
    public class ComplexDataBindingController : Controller
    {
        // GET: ComplexDataBinding
        public ActionResult ComplexDataBinding()
        {
            var Emp = EmployeeView.GetAllRecords();
            ViewBag.dataSource = Emp;
            return View();
        }
    }
}