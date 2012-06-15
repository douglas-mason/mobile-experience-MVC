using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mobile_experience_MVC.Models
{
    public class StageDB : DbContext
    {
        public DbSet<StageAEEvent> StageAEEvents { get; set; }
    }
}