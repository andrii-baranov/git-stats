using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using GitStats.Domain.Models;
using MongoDB.Bson;

namespace GitStats.Data
{
    public class MongoDbRepository
    {
        IMongoDatabase _database;
        MongoClient _client;
        public MongoDbRepository(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("test");
        }

        public List<Repository> Get()
        {
            //List<Repository> items = new List<Repository>();

            var collection = _database.GetCollection<Repository>("repo");

            var filter = new BsonDocument();
            var result = collection.Find(filter).ToList();

            return result;
        }

        public void AddRepo(Repository repo)
        {
            var collection = _database.GetCollection<Repository>("repo");
            collection.InsertOne(repo);
        }

    }
}
