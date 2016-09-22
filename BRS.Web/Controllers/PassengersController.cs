using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BRS.Data.Context;
using BRS.Models;
using BRS.Data.Repository;
using System.Threading.Tasks;

namespace BRS.Web.Controllers
{
    public class PassengersController : Controller
    {
        #region Fields

        private PassengerRepository repository { get; set; }

        #endregion

        #region Ctor

        public PassengersController()
        {
            this.repository = new PassengerRepository();
        }

        #endregion

        // GET: Passengers
        public async Task<ActionResult> Index()
        {
            return View(await repository.GetAllAsync());
        }

        // GET: Passengers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Passenger passenger = await this.repository.FindByIdAsync(id.Value);

            if (passenger == null)
                return HttpNotFound();

            return View(passenger);
        }

        // GET: Passengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passengers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                await this.repository.CreateAsync(passenger);
                return RedirectToAction("Index");
            }

            return View(passenger);
        }

        // GET: Passengers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Passenger passenger = await this.repository.FindByIdAsync(id.Value);

            if (passenger == null)
                return HttpNotFound();

            return View(passenger);
        }

        // POST: Passengers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                await this.repository.UpdateAsync(passenger);
                return RedirectToAction("Index");
            }
            return View(passenger);
        }

        // GET: Passengers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Passenger passenger = await this.repository.FindByIdAsync(id.Value);

            if (passenger == null)
                return HttpNotFound();

            return View(passenger);
        }

        // POST: Passengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Passenger passenger = await this.repository.FindByIdAsync(id);
            await this.repository.DeleteAsync(passenger);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
