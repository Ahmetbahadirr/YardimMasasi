using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YardimMasasi.Nesneler.BirimNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.Sunum.Models.BirimViewModels;
using YardimMasasi.Sunum.Models.DuyuruViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class BirimController : Controller
    {
        // GET: BirimController
        public ActionResult Index()
        {
            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/birim").Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<List<local>>(sonuc.Result);

                var liste = x.Select(d => new BirimListItemViewModel
                {
                    Id = d.Id,
                    Adi = d.Adi
                    
                }).ToList();

                return View(liste);
            }
        }

        // GET: BirimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BirimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BirimController/Create
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

        // GET: BirimController/Edit/5
        public ActionResult Edit(int id)
        {
            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/birim/" + id.ToString()).Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<BirimGuncelleDto>(sonuc.Result);

                var a = new BirimUpdateViewModel
                {
                    Id = x.Id,
                    Adi = x.Adi
                };

                return View(a);
            }
        }

        // POST: BirimController/Edit/5
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

        // GET: BirimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BirimController/Delete/5
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

    public class local
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }

}


