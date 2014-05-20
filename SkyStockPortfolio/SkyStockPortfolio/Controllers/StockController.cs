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
    public class StockController : Controller
    {
        private StockDBContext db = new StockDBContext();

        //
        // GET: /Stock/

        public ActionResult Index()
        {
            return View(db.Stock.ToList());
        }

        //
        // GET: /Stock/Details/5

        public ActionResult Details(int id = 0)
        {
            Stock stock = db.Stock.Find(id);
            if (stock == null)
            {
                return HttpNotFound();
            }
            return View(stock);
        }

        //
        // GET: /Stock/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Stock/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock stock)
        {
            if (ModelState.IsValid)
            {
                db.Stock.Add(stock);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stock);
        }

        //
        // GET: /Stock/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Stock stock = db.Stock.Find(id);
            if (stock == null)
            {
                return HttpNotFound();
            }
            return View(stock);
        }

        //
        // POST: /Stock/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stock stock)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stock).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stock);
        }

        //
        // GET: /Stock/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Stock stock = db.Stock.Find(id);
            if (stock == null)
            {
                return HttpNotFound();
            }
            return View(stock);
        }

        //
        // POST: /Stock/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stock stock = db.Stock.Find(id);
            db.Stock.Remove(stock);
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