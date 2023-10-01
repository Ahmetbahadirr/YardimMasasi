using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.AltkonuViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class AltKonuController : Controller
    {
        // GET: AltKonuController
        public ActionResult Index()
        {
            var liste = new List<AltKonuListItemViewModel>();
            liste.Add(new AltKonuListItemViewModel
            {   Id=1,
                AnaKonuAdi = "Mail Sorunları",
                Adi ="Login Olamıyorum"
                
                
            });
            liste.Add(new AltKonuListItemViewModel
            {
                Id = 2,
                AnaKonuAdi = "Mail Sorunları",
                Adi = "Kota Arttırımı"
                

            });
            liste.Add(new AltKonuListItemViewModel
            {
                Id = 3,
                AnaKonuAdi = "Mail Sorunları",
                Adi = "Grup Talebi"
                

            });


            return View(liste);
        }


        // GET: AltKonuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AltKonuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AltKonuController/Create
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

        // GET: AltKonuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AltKonuController/Edit/5
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

        // GET: AltKonuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AltKonuController/Delete/5
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
