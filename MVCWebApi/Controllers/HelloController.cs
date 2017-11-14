using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.Services;
using MVCWebApi.Models;

namespace MVCWebApi.Controllers
{
    [Route("[controller]")]
    public class HelloController : Controller
    {
        HelloService _helloService;

        public HelloController()
        {
            _helloService = new HelloService();
            Adress adress = new Adress();
           
        }

        // GET api/values/6
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _helloService.helloWorld();
        }
    }
}
