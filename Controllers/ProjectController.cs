using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeTrackingServer.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TimeTrackingServer.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<List<Project>> Get()
        {

            using (TimeTrackingDBContext context = new TimeTrackingDBContext())
            {
                return await context.Projects.Include(p => p.Costumer).ToListAsync();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
