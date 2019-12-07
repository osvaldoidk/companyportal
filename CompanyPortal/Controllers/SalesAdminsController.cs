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
    public class SalesAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SalesAdmins
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Index()
        {
            return View(db.SalesAdmins.ToList());
        }

        // GET: SalesAdmins
        [Authorize(Roles = RoleName.CanViewGlobalSalesLink)]
        public ActionResult IndexViewOnly()
        {
            return View(db.SalesAdmins.ToList());
        }

        // GET: SalesAdmins/Details/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesAdmin salesAdmin = db.SalesAdmins.Find(id);
            if (salesAdmin == null)
            {
                return HttpNotFound();
            }
            return View(salesAdmin);
        }

        // GET: SalesAdmins/Create
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create([Bind(Include = "Id,LinkFunction,LinkAddress")] SalesAdmin salesAdmin)
        {
            if (ModelState.IsValid)
            {
                db.SalesAdmins.Add(salesAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesAdmin);
        }

        // GET: SalesAdmins/Edit/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesAdmin salesAdmin = db.SalesAdmins.Find(id);
            if (salesAdmin == null)
            {
                return HttpNotFound();
            }
            return View(salesAdmin);
        }

        // POST: SalesAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit([Bind(Include = "Id,LinkFunction,LinkAddress")] SalesAdmin salesAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesAdmin);
        }

        // GET: SalesAdmins/Delete/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesAdmin salesAdmin = db.SalesAdmins.Find(id);
            if (salesAdmin == null)
            {
                return HttpNotFound();
            }
            return View(salesAdmin);
        }

        // POST: SalesAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesAdmin salesAdmin = db.SalesAdmins.Find(id);
            db.SalesAdmins.Remove(salesAdmin);
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
