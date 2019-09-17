using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace working_with_apis.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class MumblingController : ControllerBase
  {
    [HttpGet("{letters}")]
    public ActionResult<string> MumblingKata(string letters)
    {
      return string.Join("-", letters.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}