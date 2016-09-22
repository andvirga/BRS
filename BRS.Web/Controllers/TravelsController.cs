using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BRS.Data.Context;
using BRS.Models;

namespace BRS.Web.Controllers
{
    public class TravelsController : Controller
    {
        private BRSContext db = new BRSContext();

        // GET: Travels
        public async Task<ActionResult> Index()
        {
            var travelContext = db.TravelContext.Include(t => t.BusDriver).Include(t => t.Coordinator).Include(t => t.Destination);
            return View(await travelContext.ToListAsync());
        }

        // GET: Travels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = await db.TravelContext.FindAsync(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // GET: Travels/Create
        public ActionResult Create()
        {
            ViewBag.BusDriverId = new SelectList(db.BusDriverContext, "BusDriverId", "BusDriverId");
            ViewBag.CoordinatorId = new SelectList(db.CoordinatorContext, "CoordinatorId", "CoordinatorId");
            ViewBag.DestinationId = new SelectList(db.DestinationContext, "DestinationId", "DestinationName");
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TravelId,DestinationId,CoordinatorId,BusDriverId,DepartureTime,ReturnTime")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                db.TravelContext.Add(travel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BusDriverId = new SelectList(db.BusDriverContext, "BusDriverId", "BusDriverId", travel.BusDriverId);
            ViewBag.CoordinatorId = new SelectList(db.CoordinatorContext, "CoordinatorId", "CoordinatorId", travel.CoordinatorId);
            ViewBag.DestinationId = new SelectList(db.DestinationContext, "DestinationId", "DestinationName", travel.DestinationId);
            return View(travel);
        }

        // GET: Travels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = await db.TravelContext.FindAsync(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusDriverId = new SelectList(db.BusDriverContext, "BusDriverId", "BusDriverId", travel.BusDriverId);
            ViewBag.CoordinatorId = new SelectList(db.CoordinatorContext, "CoordinatorId", "CoordinatorId", travel.CoordinatorId);
            ViewBag.DestinationId = new SelectList(db.DestinationContext, "DestinationId", "DestinationName", travel.DestinationId);
            return View(travel);
        }

        // POST: Travels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TravelId,DestinationId,CoordinatorId,BusDriverId,DepartureTime,ReturnTime")] Travel travel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BusDriverId = new SelectList(db.BusDriverContext, "BusDriverId", "BusDriverId", travel.BusDriverId);
            ViewBag.CoordinatorId = new SelectList(db.CoordinatorContext, "CoordinatorId", "CoordinatorId", travel.CoordinatorId);
            ViewBag.DestinationId = new SelectList(db.DestinationContext, "DestinationId", "DestinationName", travel.DestinationId);
            return View(travel);
        }

        // GET: Travels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Travel travel = await db.TravelContext.FindAsync(id);
            if (travel == null)
            {
                return HttpNotFound();
            }
            return View(travel);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Travel travel = await db.TravelContext.FindAsync(id);
            db.TravelContext.Remove(travel);
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
