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
    public class PerformanceSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: performancesummaries
        public async Task<ActionResult> Index()
        {
            return View(await db.performancesummaryDbset.ToListAsync());
        }

        // GET: performancesummaries/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancesummary performancesummary = await db.performancesummaryDbset.FindAsync(id);
            if (performancesummary == null)
            {
                return HttpNotFound();
            }
            return View(performancesummary);
        }

        // GET: performancesummaries/Create
        public ActionResult Create()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            ViewBag.Message = thesupervisorName.FullName;
            return View();
        }

        // POST: performancesummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserName,PFNumber,FullName,SupervisorName,FinancialYear,PerformanceTargetScore,ValuesandCompetenciesScore,TotalScore,SubmissionDate")] performancesummary performancesummary)
        {
            if (ModelState.IsValid)
            {
                db.performancesummaryDbset.Add(performancesummary);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(performancesummary);
        }

        // GET: performancesummaries/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancesummary performancesummary = await db.performancesummaryDbset.FindAsync(id);
            if (performancesummary == null)
            {
                return HttpNotFound();
            }
            return View(performancesummary);
        }

        // POST: performancesummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserName,PFNumber,FullName,SupervisorName,FinancialYear,PerformanceTargetScore,ValuesandCompetenciesScore,TotalScore,SubmissionDate")] performancesummary performancesummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(performancesummary).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(performancesummary);
        }

        // GET: performancesummaries/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancesummary performancesummary = await db.performancesummaryDbset.FindAsync(id);
            if (performancesummary == null)
            {
                return HttpNotFound();
            }
            return View(performancesummary);
        }

        // POST: performancesummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            performancesummary performancesummary = await db.performancesummaryDbset.FindAsync(id);
            db.performancesummaryDbset.Remove(performancesummary);
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
    }
}
