using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteOfTheDay.Models
{
    public class Quote
    {
        public int QuoteID { get; set; }
        public string QuoteText { get; set; }
        public string AuthorName { get; set; }
    }
}