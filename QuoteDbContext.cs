using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace QuoteOfTheDay.Models
{
    public class QuoteDbContext:DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<User> Users { get; set; }

        public QuoteDbContext() : base("QuoteDbContext") { }
    }
}