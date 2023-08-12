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
    public class TrainingandDevelopmentPlansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: traininganddevelopmentplans
        public async Task<ActionResult> Index()
        {
            return View(await db.traininganddevelopmentplanDbset.ToListAsync());
        }

        public async Task<ActionResult> SuperIndex()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            string mysupervisorName = thesupervisorName.FullName;

            return View(await db.traininganddevelopmentplanDbset.Where(s => s.SupervisorName.Equals(mysupervisorName)).ToListAsync());
        }

        // GET: traininganddevelopmentplans/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traininganddevelopmentplan traininganddevelopmentplan = await db.traininganddevelopmentplanDbset.FindAsync(id);
            if (traininganddevelopmentplan == null)
            {
                return HttpNotFound();
            }
            return View(traininganddevelopmentplan);
        }

        // GET: traininganddevelopmentplans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: traininganddevelopmentplans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PFNumber,FullName,FinancialYear,TrainingProgram,TrainingInstitute,TotalCost,NumberofDays,ApraiseeComents,HODComments,DateofSubmission,SupervisorName")] traininganddevelopmentplan traininganddevelopmentplan)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();
                string currentUserName = User.Identity.GetUserName();
                var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);
                var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

                traininganddevelopmentplan.PFNumber = user.PFNumber.ToString();
                traininganddevelopmentplan.DateofSubmission = DateTime.Now.ToUniversalTime();
                traininganddevelopmentplan.SupervisorName = thesupervisorName.SupervisorName;
                traininganddevelopmentplan.FullName = thesupervisorName.FullName;

                db.traininganddevelopmentplanDbset.Add(traininganddevelopmentplan);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(traininganddevelopmentplan);
        }

        // GET: traininganddevelopmentplans/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traininganddevelopmentplan traininganddevelopmentplan = await db.traininganddevelopmentplanDbset.FindAsync(id);
            if (traininganddevelopmentplan == null)
            {
                return HttpNotFound();
            }
            return View(traininganddevelopmentplan);
        }

        // POST: traininganddevelopmentplans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PFNumber,FullName,FinancialYear,TrainingProgram,TrainingInstitute,TotalCost,NumberofDays,ApraiseeComents,HODComments,DateofSubmission,SupervisorName")] traininganddevelopmentplan traininganddevelopmentplan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traininganddevelopmentplan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(traininganddevelopmentplan);
        }

        public async Task<ActionResult> SuperEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traininganddevelopmentplan traininganddevelopmentplan = await db.traininganddevelopmentplanDbset.FindAsync(id);
            if (traininganddevelopmentplan == null)
            {
                return HttpNotFound();
            }
            return View(traininganddevelopmentplan);
        }

        // POST: traininganddevelopmentplans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SuperEdit([Bind(Include = "Id,PFNumber,FullName,FinancialYear,TrainingProgram,TrainingInstitute,TotalCost,NumberofDays,ApraiseeComents,HODComments,DateofSubmission")] traininganddevelopmentplan traininganddevelopmentplan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traininganddevelopmentplan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(traininganddevelopmentplan);
        }

        // GET: traininganddevelopmentplans/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traininganddevelopmentplan traininganddevelopmentplan = await db.traininganddevelopmentplanDbset.FindAsync(id);
            if (traininganddevelopmentplan == null)
            {
                return HttpNotFound();
            }
            return View(traininganddevelopmentplan);
        }

        // POST: traininganddevelopmentplans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            traininganddevelopmentplan traininganddevelopmentplan = await db.traininganddevelopmentplanDbset.FindAsync(id);
            db.traininganddevelopmentplanDbset.Remove(traininganddevelopmentplan);
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
