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
    public class AppraiseeandSupervisorCommentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: apraiseeandsupervisorcomments
        public async Task<ActionResult> Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);

            string myuserName = user.UserName;

            return View(await db.apraiseeandsupervisorcommentsDbset.Where(s => s.UserName.Equals(myuserName)).ToListAsync());
        }

        public async Task<ActionResult> Supervisor()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

            string mysupervisorName = thesupervisorName.FullName;

            return View(await db.apraiseeandsupervisorcommentsDbset.Where(s => s.SupervisorName.Equals(mysupervisorName)).ToListAsync());
        }

        // GET: apraiseeandsupervisorcomments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            apraiseeandsupervisorcomments apraiseeandsupervisorcomments = await db.apraiseeandsupervisorcommentsDbset.FindAsync(id);
            if (apraiseeandsupervisorcomments == null)
            {
                return HttpNotFound();
            }
            return View(apraiseeandsupervisorcomments);
        }

        // GET: apraiseeandsupervisorcomments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: apraiseeandsupervisorcomments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PFNumber,UserName,FullName,FinancialYear,DiscussionConfirmation,AppraiseeComments,AppraiseeDate,EmployeeStrengths,EmployeeDifficulties,SupervisorName,SupervisorDate")] apraiseeandsupervisorcomments apraiseeandsupervisorcomments)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();
                string currentUserName = User.Identity.GetUserName();
                var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);
                var thesupervisorName = db.personaldetailsDbset.SingleOrDefault(s => s.UserName == currentUserName);

                apraiseeandsupervisorcomments.UserName = user.UserName;
                apraiseeandsupervisorcomments.PFNumber = user.PFNumber.ToString();
                apraiseeandsupervisorcomments.SupervisorName = thesupervisorName.SupervisorName;
                apraiseeandsupervisorcomments.FullName = thesupervisorName.FullName;

                db.apraiseeandsupervisorcommentsDbset.Add(apraiseeandsupervisorcomments);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(apraiseeandsupervisorcomments);
        }

        // GET: apraiseeandsupervisorcomments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            apraiseeandsupervisorcomments apraiseeandsupervisorcomments = await db.apraiseeandsupervisorcommentsDbset.FindAsync(id);
            if (apraiseeandsupervisorcomments == null)
            {
                return HttpNotFound();
            }
            return View(apraiseeandsupervisorcomments);
        }

        // POST: apraiseeandsupervisorcomments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PFNumber,UserName,FullName,FinancialYear,DiscussionConfirmation,AppraiseeComments,AppraiseeDate,UserName,EmployeeStrengths,EmployeeDifficulties,SupervisorName,SupervisorDate")] apraiseeandsupervisorcomments apraiseeandsupervisorcomments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apraiseeandsupervisorcomments).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(apraiseeandsupervisorcomments);
        }

        // GET: apraiseeandsupervisorcomments/Edit/5
        public async Task<ActionResult> SuperEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            apraiseeandsupervisorcomments apraiseeandsupervisorcomments = await db.apraiseeandsupervisorcommentsDbset.FindAsync(id);
            if (apraiseeandsupervisorcomments == null)
            {
                return HttpNotFound();
            }
            return View(apraiseeandsupervisorcomments);
        }

        // POST: apraiseeandsupervisorcomments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SuperEdit([Bind(Include = "Id,PFNumber,UserName,FullName,FinancialYear,DiscussionConfirmation,AppraiseeComments,AppraiseeDate,UserName,EmployeeStrengths,EmployeeDifficulties,SupervisorName,SupervisorDate")] apraiseeandsupervisorcomments apraiseeandsupervisorcomments)
        {
            if (ModelState.IsValid)
            {
                apraiseeandsupervisorcomments.SupervisorDate = DateTime.Now.ToUniversalTime();

                db.Entry(apraiseeandsupervisorcomments).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(apraiseeandsupervisorcomments);
        }

        // GET: apraiseeandsupervisorcomments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            apraiseeandsupervisorcomments apraiseeandsupervisorcomments = await db.apraiseeandsupervisorcommentsDbset.FindAsync(id);
            if (apraiseeandsupervisorcomments == null)
            {
                return HttpNotFound();
            }
            return View(apraiseeandsupervisorcomments);
        }

        // POST: apraiseeandsupervisorcomments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            apraiseeandsupervisorcomments apraiseeandsupervisorcomments = await db.apraiseeandsupervisorcommentsDbset.FindAsync(id);
            db.apraiseeandsupervisorcommentsDbset.Remove(apraiseeandsupervisorcomments);
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
