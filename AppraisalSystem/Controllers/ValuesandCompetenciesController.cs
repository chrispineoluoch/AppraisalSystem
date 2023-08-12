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
using Microsoft.AspNet.Identity;

namespace AppraisalSystem.Controllers
{
    public class ValuesandCompetenciesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: valuesandcompetencies
        public async Task<ActionResult> Index()
        {
            return View(await db.valuesandcompetencyDbset.ToListAsync());
        }

        // GET: valuesandcompetencies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valuesandcompetency valuesandcompetency = await db.valuesandcompetencyDbset.FindAsync(id);
            if (valuesandcompetency == null)
            {
                return HttpNotFound();
            }
            return View(valuesandcompetency);
        }

        // GET: valuesandcompetencies/Create
        public ActionResult Create()
        {
            ViewBag.staffList = new SelectList(GetStaffList(), "PFNumber", "FullName");

            return View();
        }

        // POST: valuesandcompetencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PFNumber,FullName,FinancialYear,TeamSpirit,Integrity,InitiativeandSelfdrive,InterpersonalRelations,PunctualityandAttendance,TechnicalCompetencies,DependabilityandResourcefulness,ResourceManagement,DeliveryandPromptness,AttitudetoWorkandColleagues,TotalScore,DateofSubmission")] valuesandcompetency valuesandcompetency)
        {
            if (ModelState.IsValid)
            {
                valuesandcompetency.DateofSubmission = DateTime.Now.ToUniversalTime();

                db.valuesandcompetencyDbset.Add(valuesandcompetency);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(valuesandcompetency);
        }

        // GET: valuesandcompetencies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valuesandcompetency valuesandcompetency = await db.valuesandcompetencyDbset.FindAsync(id);
            if (valuesandcompetency == null)
            {
                return HttpNotFound();
            }
            return View(valuesandcompetency);
        }

        // POST: valuesandcompetencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PFNumber,FullName,FinancialYear,TeamSpirit,Integrity,InitiativeandSelfdrive,InterpersonalRelations,PunctualityandAttendance,TechnicalCompetencies,DependabilityandResourcefulness,ResourceManagement,DeliveryandPromptness,AttitudetoWorkandColleagues,TotalScore,DateofSubmission")] valuesandcompetency valuesandcompetency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valuesandcompetency).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(valuesandcompetency);
        }

        // GET: valuesandcompetencies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valuesandcompetency valuesandcompetency = await db.valuesandcompetencyDbset.FindAsync(id);
            if (valuesandcompetency == null)
            {
                return HttpNotFound();
            }
            return View(valuesandcompetency);
        }

        // POST: valuesandcompetencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            valuesandcompetency valuesandcompetency = await db.valuesandcompetencyDbset.FindAsync(id);
            db.valuesandcompetencyDbset.Remove(valuesandcompetency);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public List<personaldetails> GetStaffList()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thecurrentFullname = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);
            var fullname = thecurrentFullname.FullName;

            List<personaldetails> staffList = db.personaldetailsDbset.Where(s => s.SupervisorName.Equals(fullname)).ToList();

            return staffList;
        }
    }
}
