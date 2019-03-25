using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mustache.Reports.Example.Web
{
    [Route("api/status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public IActionResult Status()
        {
            return Ok($"Running @ {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
