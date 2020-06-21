using System;
using Chatterer_server.Interfaces;
using Chatterer_server.Models;
using MongoDB.Driver;

namespace Chatterer_server
{
    public class MongoDbService
    {
        public IMongoCollection<Message> Message { get; }

        public MongoDbService(IChattererDbSettings settings)
        {
            var credential = MongoCredential.CreateCredential(settings.DatabaseName, settings.DatabaseLogin,
                settings.DatabasePassword);
            var dbSettings = new MongoClientSettings()
            {
                Credentials = new [] {credential},
               Server = new MongoServerAddress(settings.ConnectionString)
            };
            var client = new MongoClient(dbSettings);
            var database = client.GetDatabase(settings.DatabaseName);
            this.Message = database.GetCollection<Message>(settings.MessagesCollectionsName);
        }
    }
}