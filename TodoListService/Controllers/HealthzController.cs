using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoListService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthzController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Healthy";
        }
    }
}
