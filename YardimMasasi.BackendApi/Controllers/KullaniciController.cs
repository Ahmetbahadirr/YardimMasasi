using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.Nesneler.KullaniciNesneler.Dto;

namespace YardimMasasi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _service;

        public KullaniciController(IKullaniciService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public KullaniciDto Get(int id)
        {
            return _service.KullaniciGetir(id);
        }
    }
}
