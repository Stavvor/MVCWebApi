using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApi.Services;

namespace MVCWebApi.Services
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
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _helloService.helloWorld();
        }
    }
}
