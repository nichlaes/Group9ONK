using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Delopgaveprojekt.Repositories;
using Microsoft.Extensions.Logging;

namespace Delopgaveprojekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VearktoejskasseController : ControllerBase
    {
        private VaerktoejskasseRepository vaerktoejskasseRepository;
        private readonly ILogger<VearktoejskasseController> _logger;

        public VearktoejskasseController(ILogger<VearktoejskasseController> logger)
        {
            _logger = logger;
        }

        // GET: api/Vearktoejskasse
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Vearktoejskasse/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vearktoejskasse
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Vearktoejskasse/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
