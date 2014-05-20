using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SkyStockPortfolio.Models
{
    public class Stock
    {
        [Key]
        public int stock_id { get; set; }

        public string stock_name { get; set; }
        public float stock_last_price { get; set; }
    }
    public class StockDBContext: DbContext
    {
        public DbSet<Stock> Stock { get; set; } 
    }
}