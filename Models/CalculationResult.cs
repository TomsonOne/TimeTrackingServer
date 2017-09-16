using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace TimeTrackingServer.Models
{
    public class CalculationResult
    {
        public string type { get; set; }
        public float inVoicedDays { get; set; }
        public float averageHourlyRate { get; set; }
        public float income { get; set; }
        public float investmentExpenses { get; set; }
        public float adjustedIncome { get; set; }
        public float employerExpenses { get; set; }
        public float travelingExpenses { get; set; }
        public float otherExpenses { get; set; }
        public float grossSalary { get; set; }
        public float bonus{ get; set; }
    }
}