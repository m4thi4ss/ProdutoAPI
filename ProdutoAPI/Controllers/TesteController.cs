using Microsoft.AspNetCore.Mvc;

namespace ProdutoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API está funcionando corretamente!");
        }
    }
}
