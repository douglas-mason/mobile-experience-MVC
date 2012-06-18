using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mobile_experience_MVC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string description { get; set; }
        public string relationships { get; set; }
        public string avatarImagePath { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}