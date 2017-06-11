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
    public class ServiciosController : Controller
    {
        //private MovieStoreContext db = new MovieStoreContext();

        private readonly IUnityOfWork _UnityOfWork;

        public ServiciosController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public ServiciosController()
        {

        }

      
        public ActionResult Index()
        {
            //return View(db.Genres.ToList());
            return View(_UnityOfWork.Servicios.GetAll());
        }

        // GET: Genres/Details/
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            //Genre genre = db.Genres.Find(id);
            Servicio servicio = _UnityOfWork.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
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
        public ActionResult Create([Bind(Include = "ServicioId,Description")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                //db.Genres.Add(bus);
                _UnityOfWork.Servicios.Add(servicio);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicio);
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            Servicio servicio = _UnityOfWork.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Genres/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioId,Description")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(genre).State = EntityState.Modified;
                _UnityOfWork.StateModified(servicio);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(servicio);
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            Servicio servicio = _UnityOfWork.Servicios.Get(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Genre genre = db.Genres.Find(id);
            Servicio servicio = _UnityOfWork.Servicios.Get(id);

            //db.Genres.Remove(genre);
            _UnityOfWork.Servicios.Remove(servicio);

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
