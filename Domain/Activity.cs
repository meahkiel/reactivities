using System;

namespace Domain
{
    public class Activity : BaseDomain
    {
        

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Category { get; set; }
        
        public string City { get; set; }

        public string Venue { get; set; }
        

    }
}