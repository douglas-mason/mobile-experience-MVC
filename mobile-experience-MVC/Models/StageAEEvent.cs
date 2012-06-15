using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mobile_experience_MVC.Models
{
    public class StageAEEvent
    {
        [Key]
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
    }
}