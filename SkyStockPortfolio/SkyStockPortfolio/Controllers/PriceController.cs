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
    public class PriceController : Controller
    {
        private PriceDBContext db = new PriceDBContext();

        //
        // GET: /Price/

        public ActionResult Index()
        {
            return View(db.Price.ToList());
        }

        //
        // GET: /Price/Details/5

        public ActionResult Details(int id = 0)
        {
            Price price = db.Price.Find(id);
            if (price == null)
            {
                return HttpNotFound();
            }
            return View(price);
        }

        //
        // GET: /Price/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Price/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Price price)
        {
            if (ModelState.IsValid)
            {
                db.Price.Add(price);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(price);
        }

        //
        // GET: /Price/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Price price = db.Price.Find(id);
            if (price == null)
            {
                return HttpNotFound();
            }
            return View(price);
        }

        //
        // POST: /Price/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Price price)
        {
            if (ModelState.IsValid)
            {
                db.Entry(price).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(price);
        }

        //
        // GET: /Price/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Price price = db.Price.Find(id);
            if (price == null)
            {
                return HttpNotFound();
            }
            return View(price);
        }

        //
        // POST: /Price/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Price price = db.Price.Find(id);
            db.Price.Remove(price);
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