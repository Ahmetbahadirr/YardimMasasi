using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.SurecViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class SurecTanimiController : Controller
    {
        
        [Authorize]
        public ActionResult Index()
        {
            //var list = _surecService.GetSurecTanimlari();

            //var list2 = list.Select(x => new SurecTanimiListItemViewModel
            //{
            //    Id= x.Id,
            //    Adi=x.Adi,
            //    AdimSayisi=x.AdimSayisi
            //});

            //HttpContext.Session.SetString("Deneme1", "Değer1");

            return View();
        }

        // GET: SurecTanimiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SurecTanimiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurecTanimiController/Create
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

        // GET: SurecTanimiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SurecTanimiController/Edit/5
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

        // GET: SurecTanimiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SurecTanimiController/Delete/5
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
