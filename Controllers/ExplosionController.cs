using Microsoft.AspNetCore.Mvc;

namespace working_with_apis.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ExplosionController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get()
    {
      return "Hello World";
    }
  }
}