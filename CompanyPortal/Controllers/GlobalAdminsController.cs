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
    public class GlobalAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GlobalAdmins
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Index()
        {
            return View(db.GlobalAdmins.ToList());
        }

        // GET: GlobalAdmins
        [Authorize(Roles = RoleName.CanViewGlobalLink)]
        public ActionResult IndexViewOnly()
        {
            return View(db.GlobalAdmins.ToList());
        }

        // GET: GlobalAdmins/Details/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlobalAdmin globalAdmin = db.GlobalAdmins.Find(id);
            if (globalAdmin == null)
            {
                return HttpNotFound();
            }
            return View(globalAdmin);
        }

        // GET: GlobalAdmins/Create
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: GlobalAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create([Bind(Include = "Id,LinkFunction,LinkAddress")] GlobalAdmin globalAdmin)
        {
            if (ModelState.IsValid)
            {
                db.GlobalAdmins.Add(globalAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(globalAdmin);
        }

        // GET: GlobalAdmins/Edit/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlobalAdmin globalAdmin = db.GlobalAdmins.Find(id);
            if (globalAdmin == null)
            {
                return HttpNotFound();
            }
            return View(globalAdmin);
        }

        // POST: GlobalAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit([Bind(Include = "Id,LinkFunction,LinkAddress")] GlobalAdmin globalAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(globalAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(globalAdmin);
        }

        // GET: GlobalAdmins/Delete/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlobalAdmin globalAdmin = db.GlobalAdmins.Find(id);
            if (globalAdmin == null)
            {
                return HttpNotFound();
            }
            return View(globalAdmin);
        }

        // POST: GlobalAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult DeleteConfirmed(int id)
        {
            GlobalAdmin globalAdmin = db.GlobalAdmins.Find(id);
            db.GlobalAdmins.Remove(globalAdmin);
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
