using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace coffeehouse.Models
{
    public class CardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Purchase> Purcahses { get; set; }
    }
}