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
    public class StateParkController : ControllerBase
    {
        private StateAndNationalParksAPIContext _db;

        public StateParkController(StateAndNationalParksAPIContext db)
        {
        _db = db;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get()
        {
            return _db.StateParks.ToList();
        }
        [HttpGet("search")]
        public ActionResult<IEnumerable<StatePark>> GetSearch(string name)
        {
            var query = _db.StateParks.AsQueryable();
            return query.Where(c => c.Name == name).ToList();
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<StatePark> Get(int id)
        {
            var Result = _db.StateParks.FirstOrDefault(c => c.StateParkId == id);
            return Result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] StatePark value)
        {
            _db.StateParks.Add(value);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StatePark value)
        {
          value.StateParkId = id;
          _db.Entry(value).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var parkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
          _db.StateParks.Remove(parkToDelete);
          _db.SaveChanges();
        }
    }
}
