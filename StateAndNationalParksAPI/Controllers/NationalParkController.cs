using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateAndNationalParksAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace StateAndNationalParksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParkController : ControllerBase
    {
        private StateAndNationalParksAPIContext _db;

        public NationalParkController(StateAndNationalParksAPIContext db)
        {
        _db = db;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<NationalPark>> Get()
        {
            return _db.NationalParks.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<NationalPark> Get(int id)
        {
            var Result = _db.NationalParks.FirstOrDefault(c => c.NationalParkId == id);
            return Result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
