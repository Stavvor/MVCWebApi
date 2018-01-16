using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.Services;
using MVCWebApi.Repositories;

namespace MVCWebApi.Controllers
{
    [Route("[controller]")]
    public class HelloController : Controller
    {
        HelloService _helloService;

        public HelloController()
        {
            _helloService = new HelloService();
           
        }

        // GET api/values/6
        [HttpGet("Hello/{id}")]
        public string Get(int id)
        {
            return _helloService.helloWorld();
        }

        [HttpGet("Hello/Index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("Hello/Create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
