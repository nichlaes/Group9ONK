using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delopgaveprojekt.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Delopgaveprojekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaerktoejController : ControllerBase
    {

        private readonly ILogger<VaerktoejController> _logger;
        private IVaerktoejRepository _vaerktoejRepository;

        public VaerktoejController(ILogger<VaerktoejController> logger, IVaerktoejRepository vaerktoejRepository)
        {
            _vaerktoejRepository = vaerktoejRepository;
            _logger = logger;
        }

        // GET: api/Vaerktoej
        [HttpGet]
        public List<Models.Vaerktoej> Get()
        {
            //return _vaerktoejRepository.GetVaerktoejs();
            return new List<Models.Vaerktoej>{ new Models.Vaerktoej {
            VTAnskaffet = DateTime.Now,
            VTFabrikat = "Apollo Productions",
            VTId = 42,
            VTModel = "Ja",
            } };
        }

        // GET: api/Vaerktoej/5
        [HttpGet("{id}")]
        public Models.Vaerktoej Get(int id)
        {
            return _vaerktoejRepository.GetById(id);
        }

        // POST: api/Vaerktoej
        [HttpPost]
        public void Post([FromBody] Models.Vaerktoej vt)
        {
            _vaerktoejRepository.AddVaerktoej(vt);
        }

        // PUT: api/Vaerktoej/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Vaerktoej vt)//Hvad skal der helt præcis  ske her???
        {
            _vaerktoejRepository.UpdateVaerktoej(vt);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Models.Vaerktoej vt)
        {
            _vaerktoejRepository.DeleteVaerktoej(vt);
        }
    }
}
