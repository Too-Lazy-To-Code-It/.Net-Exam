   using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class AuditController : Controller
    {

        // GET: AuditController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuditController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuditController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuditController/Create
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

        // GET: AuditController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuditController/Edit/5
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

        // GET: AuditController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuditController/Delete/5
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
