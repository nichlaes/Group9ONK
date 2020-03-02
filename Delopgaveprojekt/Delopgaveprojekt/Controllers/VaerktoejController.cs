//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;

//namespace Delopgaveprojekt.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VaerktoejController : ControllerBase
//    {

//        private readonly ILogger<VaerktoejController> _logger;

//        public VaerktoejController(ILogger<VaerktoejController> logger)
//        {
//            _logger = logger;
//        }

//        // GET: api/Vaerktoej
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET: api/Vaerktoej/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/Vaerktoej
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT: api/Vaerktoej/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
