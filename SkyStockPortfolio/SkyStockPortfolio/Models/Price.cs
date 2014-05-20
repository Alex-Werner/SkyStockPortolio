using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkyStockPortfolio.Models
{
    public class Price
    {
        [Key]
        public int price_id { get; set; }

        public int stock_id { get; set; }
        public DateTime stock_date { get; set; }
        public float stock_value { get; set; }
    }
    public class PriceDBContext : DbContext
    {
        public DbSet<Price> Price { get; set; } 
    }
}