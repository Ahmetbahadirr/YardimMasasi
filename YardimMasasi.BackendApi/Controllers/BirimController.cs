using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.BirimNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YardimMasasi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirimController : ControllerBase
    {
        private readonly IBirimService _service;

        public BirimController(IBirimService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<BirimListeElemaniDto> Get()
        {
            return _service.GetirBirimListe();
        }

        [HttpGet("{id}")]
        public BirimGuncelleDto Get(int id)
        {
            return _service.BirimGuncelle(id);
        }

        // POST api/<BirimController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BirimController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BirimController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
