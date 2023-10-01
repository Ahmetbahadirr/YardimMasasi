using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.Sunum.Models.AnaKonu;
using YardimMasasi.Sunum.Models.BirimViewModels;
using YardimMasasi.Sunum.Models.DuyuruViewModels;
using YardimMasasi.Sunum.Models.GorevMesajViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace YardimMasasi.Sunum.Controllers
{
    public class DuyuruController : Controller
    {
        
        // GET: DuyuruController
        public ActionResult Index()
        {

            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/duyuru").Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<List<DuyuruListeElemaniDto>>(sonuc.Result);

                var liste = x.Select(d => new DuyuruListItemViewModel
                {
                    Id = d.Id,
                    Konu = d.Konu,
                    Baslik = d.Baslik,
                    BaslangicTarihi = d.BaslangicTarihi,
                    BitisTarihi = d.BitisTarihi
                    
                }).ToList();

                return View(liste);
            }
        }

        // GET: DuyuruController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DuyuruController/Create
        public ActionResult Create()
        {
            return PartialView("_Create", new DuyuruEkleViewModel());
        }

        // POST: DuyuruController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([FromForm] DuyuruEkleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //_service.DuyuruEkle(new Nesneler.DuyuruNesneler.Dto.DuyuruEkleDto
            //{
            //    Konu = model.Konu,
            //    Baslik = model.Baslik,
            //    BaslangicTarihi = model.BaslangicTarihi,
            //    BitisTarihi = model.BitisTarihi
            //});

            return Json(new { basarili=true });
        }
        // GET: DuyuruController/Edit/5
        public ActionResult Edit(int id)
        {
            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/duyuru/" + id.ToString()).Result.Content.ReadAsStringAsync();

                var x = JsonConvert.DeserializeObject<DuyuruGuncelleDto>(sonuc.Result);

                var a = new DuyuruGuncelleViewModel
                {
                    Konu = x.Konu,
                    Baslik = x.Baslik,
                    BaslangicTarihi = x.BaslangicTarihi,
                    BitisTarihi = x.BitisTarihi
                };
                
                return View(a);
            }



            //var dyr = _service.GetirDuyuruGuncelle(id);

            //return View(new DuyuruGuncelleViewModel
            //{
            //    Id = dyr.Id,
            //    Konu = dyr.Konu,
            //    Baslik = dyr.Baslik,
            //    BaslangicTarihi = dyr.BaslangicTarihi,
            //    BitisTarihi = dyr.BitisTarihi
            //});
        }

        // POST: DuyuruController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[FromForm] DuyuruGuncelleViewModel dyr)
        {

            if (!ModelState.IsValid)
                return View(dyr);

            //_service.DuyuruGuncelle( id, new  Nesneler.DuyuruNesneler.Dto.DuyuruDto
            //{
                
            //    Konu = dyr.Konu,
            //    Baslik = dyr.Baslik,
            //    BaslangicTarihi = dyr.BaslangicTarihi,
            //    BitisTarihi = dyr.BitisTarihi
            //});
            return RedirectToAction("Index");

        }

        // GET: DuyuruController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DuyuruController/Delete/5
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
