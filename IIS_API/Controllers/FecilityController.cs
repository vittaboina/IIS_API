﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FecilityController : ControllerBase
    {
        // GET: api/<FecilityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value3" };
        }

        // GET api/<FecilityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FecilityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FecilityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FecilityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
