using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.Nesneler.KullaniciNesneler.Db;
using YardimMasasi.Nesneler.KullaniciNesneler.Dto;
using YardimMasasi.Sunum.Models.DuyuruViewModels;
using YardimMasasi.Sunum.Models.Logon;

namespace YardimMasasi.Sunum.Controllers
{
    public class LogonController : Controller
    {
        private readonly IHttpContextAccessor _context;

        public LogonController(IHttpContextAccessor context)
        {
            _context = context;
        }

        public IActionResult Logon()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Logon([FromForm]LoginViewModel login)
        {
            if(!ModelState.IsValid) { return View(login); }

            using (var c = new HttpClient())
            {
                var sonuc = c.GetAsync("https://localhost:7007/api/kullanici/1").Result.Content.ReadAsStringAsync();

                var kullanici = JsonConvert.DeserializeObject<KullaniciDto>(sonuc.Result);

                var menu = kullanici.Roller.SelectMany(r=>r.Menuler).Select(m=>new KeyValuePair<string, string>(m.HtmlClass, m.Url)).ToList();

                var menuJson = JsonConvert.SerializeObject(menu);

                _context.HttpContext.Session.SetString("userMenu", menuJson);

                return RedirectToAction("index", "home");
            }
        }
    }
}