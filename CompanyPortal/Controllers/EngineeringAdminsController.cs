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
    public class EngineeringAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EngineeringAdmins

        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Index()
        {
            return View(db.EngineeringAdmins.ToList());
        }

        // GET: EngineeringAdmins
        [Authorize(Roles = RoleName.CanViewGlobalEngLink)]
        public ActionResult IndexViewOnly()
        {
            return View(db.EngineeringAdmins.ToList());
        }



        // GET: EngineeringAdmins/Details/5

        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EngineeringAdmin engineeringAdmin = db.EngineeringAdmins.Find(id);
            if (engineeringAdmin == null)
            {
                return HttpNotFound();
            }
            return View(engineeringAdmin);
        }

        // GET: EngineeringAdmins/Create
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: EngineeringAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create([Bind(Include = "Id,LinkFunction,LinkAddress")] EngineeringAdmin engineeringAdmin)
        {
            if (ModelState.IsValid)
            {
                db.EngineeringAdmins.Add(engineeringAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(engineeringAdmin);
        }

        // GET: EngineeringAdmins/Edit/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EngineeringAdmin engineeringAdmin = db.EngineeringAdmins.Find(id);
            if (engineeringAdmin == null)
            {
                return HttpNotFound();
            }
            return View(engineeringAdmin);
        }

        // POST: EngineeringAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit([Bind(Include = "Id,LinkFunction,LinkAddress")] EngineeringAdmin engineeringAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(engineeringAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(engineeringAdmin);
        }

        // GET: EngineeringAdmins/Delete/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EngineeringAdmin engineeringAdmin = db.EngineeringAdmins.Find(id);
            if (engineeringAdmin == null)
            {
                return HttpNotFound();
            }
            return View(engineeringAdmin);
        }

        // POST: EngineeringAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult DeleteConfirmed(int id)
        {
            EngineeringAdmin engineeringAdmin = db.EngineeringAdmins.Find(id);
            db.EngineeringAdmins.Remove(engineeringAdmin);
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
