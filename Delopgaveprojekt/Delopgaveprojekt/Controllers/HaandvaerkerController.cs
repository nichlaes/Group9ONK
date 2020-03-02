using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delopgaveprojekt.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Delopgaveprojekt.Controllers
{
    [Route("api/[controller]")]
    public class HaandvaerkerController : ControllerBase
    {

        private IHaandvaerkerRepository _haandvaerkerRepository;
        private readonly ILogger<HaandvaerkerController> _logger;

        public HaandvaerkerController(ILogger<HaandvaerkerController> logger, IHaandvaerkerRepository haandvaerkerRepository)
        {
            _logger = logger;
            _haandvaerkerRepository = haandvaerkerRepository; 
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Models.Haandvaerker> Get()
        {
            return _haandvaerkerRepository.GetHaandvaerkers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Models.Haandvaerker Get(int id)
        {
            return _haandvaerkerRepository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Models.Haandvaerker hv)
        {
            _haandvaerkerRepository.AddHaandvaerker(hv);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Models.Haandvaerker hv)//Hvad præcis skal der ske her???
        {
            _haandvaerkerRepository.UpdateHaandvaerker(hv);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _haandvaerkerRepository.DeleteHaandvaerker(id);
        }
    }
}
