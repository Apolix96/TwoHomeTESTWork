using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dbsamicro.Models;

namespace dbsamicro.srpDjihad
{
    public class MicroesController : Controller
    {
        private Context db = new Context();

        // GET: Microes
        public async Task<ActionResult> Index()
        {
            return View(await db.micros.ToListAsync());
        }

        // GET: Microes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Micro micro = await db.micros.FindAsync(id);
            if (micro == null)
            {
                return HttpNotFound();
            }
            return View(micro);
        }

        // GET: Microes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Microes/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,nameMicro,priceMicro,Seria")] Micro micro)
        {
            if (ModelState.IsValid)
            {
                db.micros.Add(micro);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(micro);
        }

        // GET: Microes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Micro micro = await db.micros.FindAsync(id);
            if (micro == null)
            {
                return HttpNotFound();
            }
            return View(micro);
        }

        // POST: Microes/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,nameMicro,priceMicro,Seria")] Micro micro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(micro).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(micro);
        }

        // GET: Microes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Micro micro = await db.micros.FindAsync(id);
            if (micro == null)
            {
                return HttpNotFound();
            }
            return View(micro);
        }

        // POST: Microes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Micro micro = await db.micros.FindAsync(id);
            db.micros.Remove(micro);
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
