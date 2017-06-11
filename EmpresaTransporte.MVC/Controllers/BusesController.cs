using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmpresaTransporte.Entities;
using EmpresaTransporte.Persistence;
using EmpresaTransporte.Entities.IRepositories;

namespace EmpresaTransporte.MVC.Controllers
{
    public class BusesController : Controller
    {
        //private MovieStoreContext db = new MovieStoreContext();

        private readonly IUnityOfWork _UnityOfWork;

        public BusesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public BusesController()
        {

        }

      
        public ActionResult Index()
        {
            //return View(db.Genres.ToList());
            return View(_UnityOfWork.Buses.GetAll());
        }

        // GET: Genres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            //Genre genre = db.Genres.Find(id);
            Bus bus = _UnityOfWork.Buses.Get(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // GET: Genres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusId,Description")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                //db.Genres.Add(bus);
                _UnityOfWork.Buses.Add(bus);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bus);
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            Bus bus = _UnityOfWork.Buses.Get(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: Genres/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusId,Description")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(genre).State = EntityState.Modified;
                _UnityOfWork.StateModified(bus);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(bus);
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            Bus bus = _UnityOfWork.Buses.Get(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Genre genre = db.Genres.Find(id);
            Bus bus = _UnityOfWork.Buses.Get(id);

            //db.Genres.Remove(genre);
            _UnityOfWork.Buses.Remove(bus);

            //db.SaveChanges();
            _UnityOfWork.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
