using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Demo.Models;

namespace CRUD_Demo.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            New_Movie objBLMovie = new New_Movie();
            Movies movies = new Movies()
            { 
                movies = objBLMovie.listMovies() };
            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Add
        public ActionResult Add()
        {
            return View();
        }

=        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
=
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

=        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
=
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    internal class Movies
    {
        public Movies()
        {
        }

        public object movies { get; set; }
    }

    internal class New_Movie
    {
        public New_Movie()
        {
        }
    }
}
