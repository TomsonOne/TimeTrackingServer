using System;

namespace TimeTrackingServer.Models
{
    public class Project
    {
        public long Id { get; set; }
        public Costumer Costumer { get; set; }
        public string Name { get; set; }
        public float hourlyRate { get; set; }
    }
}