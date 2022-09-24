using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_Dashboard.Controllers
{
    public class ProductApnaController : Controller
    {
        // GET: ProductApnaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductApnaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductApnaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductApnaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductApnaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductApnaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductApnaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductApnaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
