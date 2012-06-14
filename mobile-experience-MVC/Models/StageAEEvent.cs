using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobile_experience_MVC.Models
{
    public class StageAEEvent
    {
        public string Id { get; set; }
        public string Artist { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }

        public StageAEEvent()
        {
            Artist = "Rihanna";
            Date = "July 15th";
            Time = "8:00 PM";
            Venue = "North Shore";
        }
    }
}