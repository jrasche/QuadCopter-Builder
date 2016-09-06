using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QH.Models;
using QH.ViewModels;

namespace QH.Controllers
{
    public class BatteriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Batteries
        public ActionResult Index(BatteryPage viewModel)
        {
            //var viewModel = new BatteryPage();

            var query = from b in db.Batteries
                where (viewModel.minCapacity == null || viewModel.minCapacity < b.Capacity) &&
                        (viewModel.maxCapacity == null || viewModel.maxCapacity > b.Capacity) &&
                        (viewModel.minWeight == null || viewModel.minWeight < b.Weight) &&
                        (viewModel.maxWeight == null || viewModel.maxWeight > b.Weight) &&
                        (viewModel.minVolume == null || viewModel.minVolume < b.Length * b.Height * b.Width) &&
                        (viewModel.maxVolume == null || viewModel.maxVolume > b.Length * b.Height * b.Width) &&
                        (viewModel.minDischarge == null || viewModel.minDischarge < b.MaxDischarge) &&
                        (viewModel.maxDischarge == null || viewModel.maxDischarge > b.MaxDischarge) &&
                        (viewModel.minCharge == null || viewModel.minCharge < b.MaxCharge) &&
                        (viewModel.maxCharge == null || viewModel.maxCharge > b.MaxCharge) &&
                        (viewModel.minPrice == null || viewModel.minPrice < b.Price) &&
                        (viewModel.maxPrice == null || viewModel.maxPrice > b.Price)
                orderby b.Config
                select b;

            viewModel.Batteries = query.ToList();
            return View(viewModel);
        }

        public ActionResult Chart(BatteryPage viewModel)
        {
            viewModel.Batteries = db.Batteries.ToList();
            return View(viewModel);
        }

        public void LinkToBattery(int idx)
        {
            List<Battery> batteries = db.Batteries.ToList();
            string url = batteries[idx].Url;
            Response.Redirect(url);
        }

        // GET: Batteries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battery battery = db.Batteries.Find(id);
            if (battery == null)
            {
                return HttpNotFound();
            }
            return View(battery);
        }

        // GET: Batteries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Batteries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Url,Capacity,Weight,Length,Height,Width,Price,Config,MaxDischarge,MaxCharge,Name")] Battery battery)
        {
            if (ModelState.IsValid)
            {
                db.Batteries.Add(battery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(battery);
        }

        // GET: Batteries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battery battery = db.Batteries.Find(id);
            if (battery == null)
            {
                return HttpNotFound();
            }
            return View(battery);
        }

        // POST: Batteries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Url,Capacity,Weight,Length,Height,Width,Price,Config,MaxDischarge,MaxCharge,Name")] Battery battery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(battery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(battery);
        }

        // GET: Batteries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battery battery = db.Batteries.Find(id);
            if (battery == null)
            {
                return HttpNotFound();
            }
            return View(battery);
        }

        // POST: Batteries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Battery battery = db.Batteries.Find(id);
            db.Batteries.Remove(battery);
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
