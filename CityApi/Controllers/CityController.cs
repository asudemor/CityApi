using CityApi.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private static CityEntity cityEntity = new CityEntity();
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(cityEntity);
        }
    }
}
