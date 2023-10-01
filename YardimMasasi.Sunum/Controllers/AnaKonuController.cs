using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;
using YardimMasasi.Sunum.Models.AnaKonu;

namespace YardimMasasi.Sunum.Controllers
{
    public class AnaKonuController : Controller
    {
        // GET: AnaKonularController
        public ActionResult Index()
        {
            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/anakonu").Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<List<AnaKonuListeElemaniDto>>(sonuc.Result);

                var liste = x.Select(l => new AnaKonuListItemViewModel
                {
                    Id = l.Id,
                    Adi = l.Adi
                }).ToList();

                return View(liste);
            }
        }

        // GET: AnaKonularController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnaKonularController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnaKonularController/Create
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

        // GET: AnaKonularController/Edit/5
        public ActionResult Edit(int id)
        {
            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/anakonu/" + id.ToString()).Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<AnaKonuGuncelleDto>(sonuc.Result);

                var a = new AnaKonuEditViewModel
                {
                    Id = x.Id,
                    Adi = x.Adi
                };

                return View(a);
            }
        }

        // POST: AnaKonularController/Edit/5
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

        // GET: AnaKonularController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnaKonularController/Delete/5
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
