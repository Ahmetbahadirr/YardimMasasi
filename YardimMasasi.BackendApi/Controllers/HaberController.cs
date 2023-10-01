using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.Nesneler.HaberNesneler.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YardimMasasi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaberController : ControllerBase
    {
        private readonly IHaberService _service;

        public HaberController(IHaberService service)
        {
            _service = service;
        }
        [HttpGet]

        public List<HaberListeElemaniDto> Get()
        {
            return _service.GetirHaberListe();
        }

        // GET api/<HaberController>/5
        [HttpGet("{id}")]
        
        public HaberGuncelleDto Get(int id)
        {
            return _service.HaberGetir(id);
        }

        // POST api/<HaberController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HaberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HaberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
