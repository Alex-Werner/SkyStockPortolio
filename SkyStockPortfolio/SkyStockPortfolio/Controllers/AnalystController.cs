using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkyStockPortfolio.Models;

namespace SkyStockPortfolio.Controllers
{
    public class AnalystController : Controller
    {
        private AnalystDBContext db = new AnalystDBContext();

        //
        // GET: /Analyst/

        public ActionResult Index()
        {
            return View(db.Analyst.ToList());
        }

        //
        // GET: /Analyst/Details/5

        public ActionResult Details(int id = 0)
        {
            Analyst analyst = db.Analyst.Find(id);
            if (analyst == null)
            {
                return HttpNotFound();
            }
            return View(analyst);
        }

        //
        // GET: /Analyst/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Analyst/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Analyst analyst)
        {
            if (ModelState.IsValid)
            {
                db.Analyst.Add(analyst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(analyst);
        }

        //
        // GET: /Analyst/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Analyst analyst = db.Analyst.Find(id);
            if (analyst == null)
            {
                return HttpNotFound();
            }
            return View(analyst);
        }

        //
        // POST: /Analyst/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Analyst analyst)
        {
            if (ModelState.IsValid)
            {
                db.Entry(analyst).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(analyst);
        }

        //
        // GET: /Analyst/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Analyst analyst = db.Analyst.Find(id);
            if (analyst == null)
            {
                return HttpNotFound();
            }
            return View(analyst);
        }

        //
        // POST: /Analyst/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Analyst analyst = db.Analyst.Find(id);
            db.Analyst.Remove(analyst);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}