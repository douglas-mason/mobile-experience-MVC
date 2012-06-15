using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mobile_experience_MVC.Models
{
    public class UserEvent
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public int eventId { get; set; }
    }
}