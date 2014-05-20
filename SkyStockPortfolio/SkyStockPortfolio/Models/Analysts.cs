using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkyStockPortfolio.Models
{
    public class Analyst
    {
        [Key]
        public int analyst_id { get; set; }

        public int stock_id { get; set; }
        public DateTime analyst_datetime { get; set; }
        public int analyst_5 { get; set; }
        public int analyst_4 { get; set; }
        public int analyst_3 { get; set; }
        public int analyst_2 { get; set; }
        public int analyst_1 { get; set; }
    }

    public class AnalystDBContext : DbContext
    {
        public DbSet<Analyst> Analyst { get; set; }
    }

}