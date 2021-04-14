using MongoDB.Driver;
using OSSE_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSE_Assignment.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Models.Book> _books;

        public BookService(IBooksDataSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var db = client.GetDatabase(settings.DatabaseName);

            _books = db.GetCollection<Book>(settings.BooksCollectionName);
        }
    }
}
