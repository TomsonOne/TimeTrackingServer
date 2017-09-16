using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTrackingServer.Models
{
    public class Expenses
    {
        public long Id { get; set; }
        public float value { get; set; }

        public string description { get; set; }
       
        public DateTime date { get; set; }

         public long expenseTypeId { get; set; }
        
        [ForeignKey("expenseTypeId")]
        public ExpenseTypes expenseType { get; set; }

        public long userId { get; set; }
        

        [ForeignKey("userId")]
        public User user { get; set; }
       
    }
}