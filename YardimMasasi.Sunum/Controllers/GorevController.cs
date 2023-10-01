using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using YardimMasasi.Sunum.Models.GorevViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class GorevController : Controller
    {
      
        // GET: GorevController
        public ActionResult Index()
        {
            var liste = new List<GorevListItemViewModel>();

            liste.Add(new GorevListItemViewModel
            {
                Id = 1,
                Tanimi = "PC aşırı ısınıyor."
            });

            liste.Add(new GorevListItemViewModel
            {
                Id = 2,
                Tanimi = "Mail kotam doldu."
            });

            liste.Add(new GorevListItemViewModel
            {
                Id = 3,
                Tanimi = "Bilgisayarım açılışta uyarı veriyor."
            });

            return View();
        }

        // GET: GorevController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GorevController/Create
        public ActionResult Create()
        {
            //var gorev = new GorevCreateViewModel();
            //var liste = _anaKonuService.GetirAnaKonuListe();

            //gorev.Konular = liste.Select(x => new SelectListItem(x.Konu, x.Id.ToString())).ToList();
            
         
            return View();
        }

        public JsonResult AltKonuListesi(int konuId)
        {
            //var altKonuListesi = _altKonuService.GetirAltKonuListe(konuId);

            //var liste = altKonuListesi.Select(x => new SelectListItem(x.Adi,x.Id.ToString()));
            
            return Json(new {});
        }


        // POST: GorevController/Create
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

        // GET: GorevController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GorevController/Edit/5
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

        // GET: GorevController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GorevController/Delete/5
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
