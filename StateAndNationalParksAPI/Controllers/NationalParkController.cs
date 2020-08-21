using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateAndNationalParksAPI.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Get([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.NationalParks
                .OrderBy(thing => thing.NationalParkId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }
        [HttpGet("search")]
        public ActionResult<IEnumerable<NationalPark>> GetSearch(string name)
        {
            var query = _db.NationalParks.AsQueryable();
            return query.Where(c => c.Name == name).ToList();
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
        public void Post([FromBody] NationalPark value)
        {
            _db.NationalParks.Add(value);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NationalPark value)
        {
            value.NationalParkId = id;
            _db.Entry(value).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
            _db.NationalParks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
