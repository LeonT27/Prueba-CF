using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TODO.Data.Data;

namespace TODO.Web.Controllers
{
    public class ListsController : Controller
    {
        private Data.Data.TODO db = new Data.Data.TODO();

        // POST: Lists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ListID,Nombre,Descripcion,CategoriasID,Estado")] List list)
        {
            if (ModelState.IsValid)
            {
                db.Lists.Add(list);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.CategoriasID = new SelectList(db.Categorias, "CategoriasID", "Nombre", list.CategoriasID);
            return RedirectToAction("Index", "Home");
        }

        // POST: Lists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            List list = db.Lists.Find(id);
            db.Lists.Remove(list);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
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
