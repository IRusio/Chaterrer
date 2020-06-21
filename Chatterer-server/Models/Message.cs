using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Chatterer_server.Models
{
    public class Message
    {
        public Message(string content, DateTime sendDate)
        {
            Content = content;
            SendDate = sendDate;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
    }
}