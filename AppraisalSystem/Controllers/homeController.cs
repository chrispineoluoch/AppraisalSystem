using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppraisalSystem.Models;
using System.IO;
using PagedList;
using PagedList.Mvc;
using OfficeOpenXml;
using Microsoft.AspNet.Identity;

namespace AppraisalSystem.Controllers
{
    public class homeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [CustomAuthorize(Roles = "Admin, User")]
        // GET: covid19_status
        public ActionResult Index()
        {
            return View();
        }

        public List<County> GetCountyList()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            List<County> countyList = db.County_Dbset.ToList();

            return countyList;
        }
    }
}