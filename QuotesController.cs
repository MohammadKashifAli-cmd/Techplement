using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using QuoteOfTheDay.Models;

namespace QuoteOfTheDay.Controllers
{
    public class QuotesController : ApiController
    {
        private QuoteDbContext db = new QuoteDbContext();

        // GET: api/quotes/random
        [HttpGet]
        [Route("api/quotes/random")]
        public IHttpActionResult GetRandomQuote()
        {
            var randomQuote = db.Quotes.OrderBy(r => Guid.NewGuid()).FirstOrDefault();
            if (randomQuote == null)
                return NotFound();

            return Ok(randomQuote);
        }
        // GET: api/quotes/search?author=AuthorName
        [HttpGet]
        [Route("api/quotes/search")]
        public IHttpActionResult SearchQuotesByAuthor(string author)
        {
            var quotes = db.Quotes.Where(q => q.AuthorName.Contains(author)).ToList();
            if (!quotes.Any())
                return NotFound();

            return Ok(quotes);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuoteExists(int id)
        {
            return db.Quotes.Count(e => e.QuoteID == id) > 0;
        }
    }
}