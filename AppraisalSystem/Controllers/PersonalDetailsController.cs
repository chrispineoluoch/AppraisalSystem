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
    public class PersonalDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: personaldetails
        public async Task<ActionResult> Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string currentUserName = User.Identity.GetUserName();
            var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);
            var username = user.UserName;

            return View(await db.personaldetailsDbset.Where(s => s.UserName.Equals(username)).ToListAsync());
        }

        // GET: personaldetails/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personaldetails personaldetails = await db.personaldetailsDbset.FindAsync(id);
            if (personaldetails == null)
            {
                return HttpNotFound();
            }
            return View(personaldetails);
        }

        // GET: personaldetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: personaldetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FullName,PFNumber,Designation,Department,NatureofEmployment,StaffCategory,AcademicQualifications,ProfessionalCertifications,JobGroup,SupervisorName,SupervisorPFNumber,UserName")] personaldetails personaldetails)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();
                string currentUserName = User.Identity.GetUserName();
                var user = db.Users.SingleOrDefault(u => u.UserName == currentUserName);

                personaldetails.UserName = user.UserName;

                db.personaldetailsDbset.Add(personaldetails);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(personaldetails);
        }

        // GET: personaldetails/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personaldetails personaldetails = await db.personaldetailsDbset.FindAsync(id);
            if (personaldetails == null)
            {
                return HttpNotFound();
            }
            return View(personaldetails);
        }

        // POST: personaldetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FullName,PFNumber,Designation,Department,NatureofEmployment,StaffCategory,AcademicQualifications,ProfessionalCertifications,JobGroup,SupervisorName,SupervisorPFNumber,UserName")] personaldetails personaldetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personaldetails).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(personaldetails);
        }

        // GET: personaldetails/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personaldetails personaldetails = await db.personaldetailsDbset.FindAsync(id);
            if (personaldetails == null)
            {
                return HttpNotFound();
            }
            return View(personaldetails);
        }

        // POST: personaldetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            personaldetails personaldetails = await db.personaldetailsDbset.FindAsync(id);
            db.personaldetailsDbset.Remove(personaldetails);
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
