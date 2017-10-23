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

        //// GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value2" };
        //}

        // GET api/values/6
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _helloService.helloWorld();
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
