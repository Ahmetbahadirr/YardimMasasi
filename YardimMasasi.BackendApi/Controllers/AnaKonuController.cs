using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YardimMasasi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnaKonuController : ControllerBase
    {
        private readonly IAnaKonuService _service;

        public AnaKonuController(IAnaKonuService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<AnaKonuListeElemaniDto> Get()
        {
            return _service.GetirAnaKonuListe();
        }

        [HttpGet("{id}")]
        public AnaKonuGuncelleDto Get(int id)
        {
            return _service.GetirAnaKonu(id);
        }

        // POST api/<AnaKonuController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AnaKonuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnaKonuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
