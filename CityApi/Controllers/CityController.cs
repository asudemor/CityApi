using CityApi.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private static List<CityEntity> cityEntities = new List<CityEntity>
        {
            new CityEntity(),
            new CityEntity{Id=1, Name="Trabzon"}
        };
        
        [HttpGet]
        public ActionResult<List<CityEntity>> Get()
        {
            return Ok(cityEntities);
        }
        [HttpGet("{id}")]
        public ActionResult<CityEntity> GetSingle(int id)
        {
            var city =  cityEntities.Find(a=>a.Id==id);
            return Ok(city);
        }
    }
}
