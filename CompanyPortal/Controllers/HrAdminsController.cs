using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompanyPortal.Models;

namespace CompanyPortal.Controllers
{
    public class HrAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HrAdmins
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Index()
        {
            return View(db.HrAdmins.ToList());
        }

        // GET: HrAdmins
        [Authorize(Roles = RoleName.CanViewGlobalHRLink)]
        public ActionResult IndexViewOnly()
        {
            return View(db.HrAdmins.ToList());
        }

        // GET: HrAdmins/Details/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HrAdmin hrAdmin = db.HrAdmins.Find(id);
            if (hrAdmin == null)
            {
                return HttpNotFound();
            }
            return View(hrAdmin);
        }

        // GET: HrAdmins/Create
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: HrAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create([Bind(Include = "Id,LinkFunction,LinkAddress")] HrAdmin hrAdmin)
        {
            if (ModelState.IsValid)
            {
                db.HrAdmins.Add(hrAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hrAdmin);
        }

        // GET: HrAdmins/Edit/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HrAdmin hrAdmin = db.HrAdmins.Find(id);
            if (hrAdmin == null)
            {
                return HttpNotFound();
            }
            return View(hrAdmin);
        }

        // POST: HrAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit([Bind(Include = "Id,LinkFunction,LinkAddress")] HrAdmin hrAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hrAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hrAdmin);
        }

        // GET: HrAdmins/Delete/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HrAdmin hrAdmin = db.HrAdmins.Find(id);
            if (hrAdmin == null)
            {
                return HttpNotFound();
            }
            return View(hrAdmin);
        }

        // POST: HrAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult DeleteConfirmed(int id)
        {
            HrAdmin hrAdmin = db.HrAdmins.Find(id);
            db.HrAdmins.Remove(hrAdmin);
            db.SaveChanges();
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
