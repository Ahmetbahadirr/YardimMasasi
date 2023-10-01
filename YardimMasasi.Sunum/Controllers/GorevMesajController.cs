using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.GorevMesajViewModels;
using YardimMasasi.Sunum.Models.GorevViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class GorevMesajController : Controller
    {
        // GET: GorevMesajController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GorevMesajController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GorevMesajController/Create
        public ActionResult Create()
        {
            var gorevmesaj = new GorevMesajCreateViewModel();
            gorevmesaj.HedefKullanicilar = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            gorevmesaj.HedefKullanicilar.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("Elif Dağcı", "1"));
            gorevmesaj.HedefKullanicilar.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("Sarp Kazanoğlu", "2"));
            gorevmesaj.HedefKullanicilar.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("Melike Kurtlu", "3"));
            gorevmesaj.HedefKullanicilar.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("Bora Şahiner", "4"));
            
            
            return View(gorevmesaj);
        }

        // POST: GorevMesajController/Create
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

        // GET: GorevMesajController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GorevMesajController/Edit/5
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

        // GET: GorevMesajController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GorevMesajController/Delete/5
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
