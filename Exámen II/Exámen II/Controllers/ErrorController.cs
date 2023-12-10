using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exámen_II.Controllers
{
    public class ErrorHandler_cs : Controller
    {
        // GET: ErrorHandler_cs
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View("Error");
        }

        // GET: ErrorHandler_cs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ErrorHandler_cs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ErrorHandler_cs/Create
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

        // GET: ErrorHandler_cs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ErrorHandler_cs/Edit/5
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

        // GET: ErrorHandler_cs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ErrorHandler_cs/Delete/5
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
