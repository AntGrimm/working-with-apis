using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace working_with_apis.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ExplosionController : ControllerBase
  {
    [HttpGet("{number}")]
    public ActionResult<string> ExplosionKata(string number)
    {
      return string.Join("", number.Select(c => new String(c, int.Parse(c.ToString()))));
    }
  }
}