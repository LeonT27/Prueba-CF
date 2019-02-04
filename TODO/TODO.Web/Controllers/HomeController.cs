using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TODO.Data.Data;
using TODO.Web.Models;

namespace TODO.Web.Controllers
{
    public class HomeController : Controller
    {
        private Data.Data.TODO db = new Data.Data.TODO();

        // GET: Home
        public ActionResult Index(int? ID)
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Categorias = db.Categorias.ToList();
            homeViewModel.Lists = db.Lists.ToList();

            ViewBag.CategoriasID = new SelectList(db.Categorias, "CategoriasID", "Nombre");
            return View(homeViewModel);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriasID,Nombre")] Categorias categorias)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categorias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteConfirmed(int id)
        {
            Categorias categorias = db.Categorias.Find(id);
            db.Categorias.Remove(categorias);
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
