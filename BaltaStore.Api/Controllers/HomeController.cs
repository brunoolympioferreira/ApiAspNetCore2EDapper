using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaltaStore.Api.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("rota/01")]
        public object Get()
        {
            return new { version = "Version 0.0.1" };
        }
    }
}
