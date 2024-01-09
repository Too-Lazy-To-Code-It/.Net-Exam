using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class Equipement : Controller
    {
        // GET: Equipement
        public ActionResult Index()
        {
            return View();
        }

        // GET: Equipement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipement/Create
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

        // GET: Equipement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Equipement/Edit/5
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

        // GET: Equipement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipement/Delete/5
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
