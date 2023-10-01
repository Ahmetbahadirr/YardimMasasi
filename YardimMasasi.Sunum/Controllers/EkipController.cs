using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.EkipViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class EkipController : Controller
    {
        // GET: EkipController
        public ActionResult Index()
        {
            var liste = new List<EkipListItemViewModel>();
            liste.Add(new EkipListItemViewModel
            {
                Id = 1,
                Adi = "Network",
                BirimAdi = "SistemYonetimiMd."
            });
            liste.Add(new EkipListItemViewModel
            {
                Id = 2,
                Adi = "Donanim",
                BirimAdi = "SistemYonetimiMd."
            });
            liste.Add(new EkipListItemViewModel
            {
                Id = 3,
                Adi = "Sistem",
                BirimAdi = "SistemYonetimiMd."
            });
            liste.Add(new EkipListItemViewModel
            {
                Id = 4,
                Adi = "Guvenlik",
                BirimAdi = "SistemYonetimiMd."
            });
            liste.Add(new EkipListItemViewModel
            {
                Id = 5,
                Adi = "Mail",
                BirimAdi = "SistemYonetimiMd."
            });

            return View(liste);
        }

        // GET: EkipController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EkipController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EkipController/Create
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

        // GET: EkipController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EkipController/Edit/5
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

        // GET: EkipController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EkipController/Delete/5
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
