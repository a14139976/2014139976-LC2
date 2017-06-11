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
    public class LugaresViajesController : Controller
    {
        //private MovieStoreContext db = new MovieStoreContext();

        private readonly IUnityOfWork _UnityOfWork;

        public LugaresViajesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public LugaresViajesController()
        {

        }

      
        public ActionResult Index()
        {
            //return View(db.Genres.ToList());
            return View(_UnityOfWork.LugaresViajes.GetAll());
        }

        // GET: Genres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            //Genre genre = db.Genres.Find(id);
            LugarViaje lugarviaje = _UnityOfWork.LugaresViajes.Get(id);
            if (lugarviaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarviaje);
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
        public ActionResult Create([Bind(Include = "LugarViajeId,Description")] LugarViaje lugarviaje)
        {
            if (ModelState.IsValid)
            {
                //db.Genres.Add(bus);
                _UnityOfWork.LugaresViajes.Add(lugarviaje);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lugarviaje);
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            LugarViaje lugarviaje = _UnityOfWork.LugaresViajes.Get(id);
            if (lugarviaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarviaje);
        }

        // POST: Genres/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LugarViajeId,Description")] LugarViaje lugarviaje)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(genre).State = EntityState.Modified;
                _UnityOfWork.StateModified(lugarviaje);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(lugarviaje);
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            LugarViaje lugarviaje = _UnityOfWork.LugaresViajes.Get(id);
            if (lugarviaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarviaje);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Genre genre = db.Genres.Find(id);
            LugarViaje lugarviaje = _UnityOfWork.LugaresViajes.Get(id);

            //db.Genres.Remove(genre);
            _UnityOfWork.LugaresViajes.Remove(lugarviaje);

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
