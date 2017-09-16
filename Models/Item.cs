using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTrackingServer.Models
{
    public class Item
    {
        public long id { get; set; }
        public string description { get; set; }
        public float hours { get; set; }
        public DateTime date { get; set; }
        public long projectId { get; set; }
        
        [ForeignKey("projectId")]
        public Project project { get; set; }
        public long userId { get; set; }
        
        [ForeignKey("userId")]
        public User user { get; set; }
        public string workingPlace { get; set; }

    }
}