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
    public class FinanceAdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FinanceAdmins
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Index()
        {
            return View(db.FinanceAdmins.ToList());
        }

        // GET: FinanceAdmins
        [Authorize(Roles = RoleName.CanViewGlobalFinanceLink)]
        public ActionResult IndexViewOnly()
        {
            return View(db.FinanceAdmins.ToList());
        }

        // GET: FinanceAdmins/Details/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinanceAdmin financeAdmin = db.FinanceAdmins.Find(id);
            if (financeAdmin == null)
            {
                return HttpNotFound();
            }
            return View(financeAdmin);
        }

        // GET: FinanceAdmins/Create
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinanceAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Create([Bind(Include = "Id,LinkFunction,LinkAddress")] FinanceAdmin financeAdmin)
        {
            if (ModelState.IsValid)
            {
                db.FinanceAdmins.Add(financeAdmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(financeAdmin);
        }

        // GET: FinanceAdmins/Edit/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinanceAdmin financeAdmin = db.FinanceAdmins.Find(id);
            if (financeAdmin == null)
            {
                return HttpNotFound();
            }
            return View(financeAdmin);
        }

        // POST: FinanceAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Edit([Bind(Include = "Id,LinkFunction,LinkAddress")] FinanceAdmin financeAdmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(financeAdmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(financeAdmin);
        }

        // GET: FinanceAdmins/Delete/5
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinanceAdmin financeAdmin = db.FinanceAdmins.Find(id);
            if (financeAdmin == null)
            {
                return HttpNotFound();
            }
            return View(financeAdmin);
        }

        // POST: FinanceAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageLink)]
        public ActionResult DeleteConfirmed(int id)
        {
            FinanceAdmin financeAdmin = db.FinanceAdmins.Find(id);
            db.FinanceAdmins.Remove(financeAdmin);
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
