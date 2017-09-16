using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace TimeTrackingServer.Models
{
    public class CalculationConfig
    {
        public long Id { get; set; }
        public float monthlyIncome { get; set; }
        public float investmentTax { get; set; }
        public float employerDuties { get; set; }

        public long userId { get; set; }
        
        [ForeignKey("userId")]
        public User user { get; set; }
    }
}