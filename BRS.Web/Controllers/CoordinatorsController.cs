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
using BRS.Data.Repository;

namespace BRS.Web.Controllers
{
    public class CoordinatorsController : Controller
    {
        #region Fields

        private CoordinatorRepository repository { get; set; }

        #endregion

        #region Ctor

        public CoordinatorsController()
        {
            this.repository = new CoordinatorRepository();
        }

        #endregion

        // GET: Coordinators
        public async Task<ActionResult> Index()
        {
            return View(await repository.GetAllAsync());
        }

        // GET: Coordinators/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Coordinator coordinator = await this.repository.FindByIdAsync(id.Value);

            if (coordinator == null)
                return HttpNotFound();

            return View(coordinator);
        }

        // GET: Coordinators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coordinators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Coordinator coordinator)
        {
            if (ModelState.IsValid)
            {
                await this.repository.CreateAsync(coordinator);
                return RedirectToAction("Index");
            }

            return View(coordinator);
        }

        // GET: Coordinators/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Coordinator coordinator = await this.repository.FindByIdAsync(id.Value);

            if (coordinator == null)
                return HttpNotFound();

            return View(coordinator);
        }

        // POST: Coordinators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Coordinator coordinator)
        {
            if (ModelState.IsValid)
            {
                await this.repository.UpdateAsync(coordinator);
                return RedirectToAction("Index");
            }
            return View(coordinator);
        }

        // GET: Coordinators/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Coordinator coordinator = await this.repository.FindByIdAsync(id.Value);

            if (coordinator == null)
                return HttpNotFound();

            return View(coordinator);
        }

        // POST: Coordinators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Coordinator coordinator = await this.repository.FindByIdAsync(id);
            await this.repository.DeleteAsync(coordinator);
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
