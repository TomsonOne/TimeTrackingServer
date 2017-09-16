using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeTrackingServer.Models;
using Microsoft.EntityFrameworkCore;

namespace TimeTrackingServer.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<List<Item>> Get(int id)
        {
            using (TimeTrackingDBContext context = new TimeTrackingDBContext())
            {
            return await context.Items.Where(a => a.user.Id == id).Include("project").OrderByDescending(a => a.date).AsNoTracking().ToListAsync();
            }
        }

        // POST api/values
        [HttpPost]
        public async Task<long> Post([FromBody]Item item)
        {
            using (TimeTrackingDBContext context = new TimeTrackingDBContext())
            {

                item.userId = 1;
                context.Items.Add(item);
                await context.SaveChangesAsync();
                return item.id;
            }
            //Mapping 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            using (TimeTrackingDBContext context = new TimeTrackingDBContext())
            {

                var item = await context.Items.SingleOrDefaultAsync(i => i.id == id);
                if (item != null)
                {
                    context.Items.Remove(item);
                    await context.SaveChangesAsync();
                }

            }

        }
    }
}
