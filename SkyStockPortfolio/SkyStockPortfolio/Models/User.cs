using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkyStockPortfolio.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public string user_pseudo { get; set; }
        public string user_password { get; set; }
        public string user_stocks { get; set; }
    }
    public class UserDBContext: DbContext
    {
        public DbSet<User> User { get; set; } 
    }
}