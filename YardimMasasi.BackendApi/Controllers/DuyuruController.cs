using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YardimMasasi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuyuruController : ControllerBase
    {
        private readonly IDuyuruService _service;

        public DuyuruController(IDuyuruService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public List<DuyuruListeElemaniDto> Get()
        {
            return _service.GetirDuyuruListe();
        }

        [HttpGet("{id}")]
        public DuyuruGuncelleDto Get(int id)
        {
            return _service.GetirDuyuruGuncelle(id);
        }

        // POST api/<DuyuruController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DuyuruController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DuyuruController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
