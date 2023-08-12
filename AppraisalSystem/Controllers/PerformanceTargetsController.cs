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
    public class PerformanceTargetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: performancetargets
        public async Task<ActionResult> Index()
        {
            return View(await db.performancetargetsDbset.ToListAsync());
        }

        public async Task<ActionResult> MyAppraisalSummary()
        {
            return View(await db.performancetargetsDbset.ToListAsync());
        }

        public async Task<ActionResult> SupervisorIndex()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            string mysupervisorName = thesupervisorName.FullName;

            return View(await db.performancetargetsDbset.Where(s => s.SupervisorName.Equals(mysupervisorName)).ToListAsync());
        }

        public async Task<ActionResult> AppraisalSummary()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            string mysupervisorName = thesupervisorName.FullName;

            return View(await db.performancetargetsDbset.Where(s => s.SupervisorName.Equals(mysupervisorName)).ToListAsync());
        }

        // GET: performancetargets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancetargets performancetargets = await db.performancetargetsDbset.FindAsync(id);
            if (performancetargets == null)
            {
                return HttpNotFound();
            }
            return View(performancetargets);
        }

        // GET: performancetargets/Create
        public ActionResult Create()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            ViewBag.Message = thesupervisorName.FullName;
            return View();
        }

        // POST: performancetargets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserName,PFNumber,FullName,SupervisorName,FinancialYear,Objective_1,Target_1,ResultAchieved_1,IndividualRating_1,SupervisorRating_1,Objective_2,Target_2,ResultAchieved_2,IndividualRating_2,SupervisorRating_2,Objective_3,Target_3,ResultAchieved_3,IndividualRating_3,SupervisorRating_3,Objective_4,Target_4,ResultAchieved_4,IndividualRating_4,SupervisorRating_4,Objective_5,Target_5,ResultAchieved_5,IndividualRating_5,SupervisorRating_5,Objective_6,Target_6,ResultAchieved_6,IndividualRating_6,SupervisorRating_6,Objective_7,Target_7,ResultAchieved_7,IndividualRating_7,SupervisorRating_7,Objective_8,Target_8,ResultAchieved_8,IndividualRating_8,SupervisorRating_8,Objective_9,Target_9,ResultAchieved_9,IndividualRating_9,SupervisorRating_9,Objective_10,Target_10,ResultAchieved_10,IndividualRating_10,SupervisorRating_10,PTSettingDate,PTAppraisalDate,NumberofTargets,PTTotalScore,VCTotalScore,OverallScore")] performancetargets performancetargets)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();
                string currentUserName = User.Identity.GetUserName();
                var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);
                var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

                performancetargets.UserName = user.UserName;
                performancetargets.PFNumber = user.PFNumber.ToString();
                performancetargets.SupervisorName = thesupervisorName.SupervisorName;
                performancetargets.FullName = thesupervisorName.FullName;
                performancetargets.PTSettingDate = DateTime.Now.ToUniversalTime();

                db.performancetargetsDbset.Add(performancetargets);
                await db.SaveChangesAsync();
                return RedirectToAction("AppraiseeIndex");
            }

            return View(performancetargets);
        }

        // GET: performancetargets/Edit/5
        public async Task<ActionResult> AppraiseeEdit(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancetargets performancetargets = await db.performancetargetsDbset.FindAsync(id);
            if (performancetargets == null)
            {
                return HttpNotFound();
            }

            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            ViewBag.Message = thesupervisorName.FullName;

            return View(performancetargets);
        }

        // POST: performancetargets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AppraiseeEdit([Bind(Include = "Id,UserName,PFNumber,FullName,SupervisorName,FinancialYear,Objective_1,Target_1,ResultAchieved_1,IndividualRating_1,SupervisorRating_1,Objective_2,Target_2,ResultAchieved_2,IndividualRating_2,SupervisorRating_2,Objective_3,Target_3,ResultAchieved_3,IndividualRating_3,SupervisorRating_3,Objective_4,Target_4,ResultAchieved_4,IndividualRating_4,SupervisorRating_4,Objective_5,Target_5,ResultAchieved_5,IndividualRating_5,SupervisorRating_5,Objective_6,Target_6,ResultAchieved_6,IndividualRating_6,SupervisorRating_6,Objective_7,Target_7,ResultAchieved_7,IndividualRating_7,SupervisorRating_7,Objective_8,Target_8,ResultAchieved_8,IndividualRating_8,SupervisorRating_8,Objective_9,Target_9,ResultAchieved_9,IndividualRating_9,SupervisorRating_9,Objective_10,Target_10,ResultAchieved_10,IndividualRating_10,SupervisorRating_10,PTSettingDate,PTAppraisalDate,NumberofTargets,PTTotalScore,VCTotalScore,OverallScore")] performancetargets performancetargets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(performancetargets).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("AppraiseeIndex");
            }
            return View(performancetargets);
        }

        // GET: performancetargets/Edit/5
        public async Task<ActionResult> SuperEdit(int? id, string fullname)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancetargets performancetargets = await db.performancetargetsDbset.FindAsync(id);
            if (performancetargets == null)
            {
                return HttpNotFound();
            }

            var apraiseefullname = fullname;
            var VCscore = db.valuesandcompetencyDbset.SingleOrDefault(s => s.FullName == apraiseefullname);

            var theVCscore = VCscore.TotalScore.ToString();
            ViewBag.VCScore = theVCscore;

            return View(performancetargets);
        }

        // POST: performancetargets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SuperEdit([Bind(Include = "Id,UserName,PFNumber,FullName,SupervisorName,FinancialYear,Objective_1,Target_1,ResultAchieved_1,IndividualRating_1,SupervisorRating_1,Objective_2,Target_2,ResultAchieved_2,IndividualRating_2,SupervisorRating_2,Objective_3,Target_3,ResultAchieved_3,IndividualRating_3,SupervisorRating_3,Objective_4,Target_4,ResultAchieved_4,IndividualRating_4,SupervisorRating_4,Objective_5,Target_5,ResultAchieved_5,IndividualRating_5,SupervisorRating_5,Objective_6,Target_6,ResultAchieved_6,IndividualRating_6,SupervisorRating_6,Objective_7,Target_7,ResultAchieved_7,IndividualRating_7,SupervisorRating_7,Objective_8,Target_8,ResultAchieved_8,IndividualRating_8,SupervisorRating_8,Objective_9,Target_9,ResultAchieved_9,IndividualRating_9,SupervisorRating_9,Objective_10,Target_10,ResultAchieved_10,IndividualRating_10,SupervisorRating_10,PTSettingDate,PTAppraisalDate,NumberofTargets,PTTotalScore,VCTotalScore,OverallScore")] performancetargets performancetargets)
        {
            if (ModelState.IsValid)
            {
                performancetargets.PTAppraisalDate = DateTime.Now.ToUniversalTime();

                db.Entry(performancetargets).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("SupervisorIndex");
            }
            return View(performancetargets);
        }

        // GET: performancetargets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            performancetargets performancetargets = await db.performancetargetsDbset.FindAsync(id);
            if (performancetargets == null)
            {
                return HttpNotFound();
            }
            return View(performancetargets);
        }

        // POST: performancetargets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            performancetargets performancetargets = await db.performancetargetsDbset.FindAsync(id);
            db.performancetargetsDbset.Remove(performancetargets);
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
