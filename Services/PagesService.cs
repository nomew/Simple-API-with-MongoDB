using System.Collections.Generic;
using MongoDB.Driver;
using sample_api_mongodb.Models;

namespace sample_api_mongodb.Services
{
    
    public class PagesService
    {
        private readonly IMongoCollection<Page> _pages;

        public PagesService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _pages = database.GetCollection<Page>("Pages");
        }

        public void CreatePage(Page page) => _pages.InsertOne(page);

        public List<Page> GetPages() => _pages.Find(p => true).ToList();

        public Page GetPage(string id) => _pages.Find(p => p.Id == id).SingleOrDefault();

        public void UpdatePage(Page page) => _pages.ReplaceOne(p => p.Id == page.Id, page);

        public void DeletePage(string id) => _pages.DeleteOne(p => p.Id == id);
    }
}