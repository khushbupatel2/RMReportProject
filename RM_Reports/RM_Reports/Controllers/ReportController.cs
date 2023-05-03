using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RM_Reports.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MonthlyReport(int vendorId,string month,string issueYear,string vehicleType,bool isShowTotal) {
            ViewBag.vendorId = vendorId.ToString();
         ViewBag.month = month;
            ViewBag.issueYear = issueYear;
            ViewBag.vehicleType = vehicleType;
              ViewBag.isShowTotal = isShowTotal;
            return View();
        }
        public ActionResult WorkOrderReport(string poId)
        {
            ViewBag.poId = poId;
            return View();
        }
    }
}