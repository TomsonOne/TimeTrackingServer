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
    public class CalculationController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<List<Item>> Get(int userid)
        {
            using (TimeTrackingDBContext context = new TimeTrackingDBContext())
            {
                var result = new CalculationResult();
                
                // Get Calculation Config for Current User 
                var config = await context.Calculation.Where(a => a.userId == userid).SingleOrDefaultAsync();
                
                var items = await context.Items.Where(i => i.userId == userid).ToListAsync();

                var fahrtkosten = await context.Items.Where(i => i.userId == userid).ToListAsync();
                
                
                result.inVoicedDays = items.Sum(a=> a.hours) / 8;
                
                result.averageHourlyRate = 65;

                result.income = items.Sum(a=> a.hours) * 65;

                result.investmentExpenses =  result.income * config.investmentTax;

                result.adjustedIncome = result.income - result.investmentExpenses;

                result.employerExpenses = result.income * config.employerDuties;

                return null;
            }
        }

        // POST api/values
        // [HttpPost]
        // public async Task<long> Post([FromBody]Item item)
        // {
        //     using (TimeTrackingDBContext context = new TimeTrackingDBContext())
        //     {

        //         item.userId = 1;
        //         context.Items.Add(item);
        //         await context.SaveChangesAsync();
        //         return item.id;
        //     }
        //     //Mapping 
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public async void Delete(int id)
        // {
        //     using (TimeTrackingDBContext context = new TimeTrackingDBContext())
        //     {

        //         var item = await context.Items.SingleOrDefaultAsync(i => i.id == id);
        //         if (item != null)
        //         {
        //             context.Items.Remove(item);
        //             await context.SaveChangesAsync();
        //         }

        //     }

        // }
    }
}
