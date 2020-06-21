using System;
using System.Globalization;
using System.Threading.Tasks;
using Chatterer_server.Models;
using Grpc.Core;

namespace Chatterer_server
{
    public class MessagesService : Messages.MessagesBase
    {
        private readonly MongoDbService _mongoDbService;

        public MessagesService(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public override Task<OutgoingMessage> AddMessage(IncomingMessage request, ServerCallContext context)
        {
            var message = new Message(request.Content, DateTime.Now);
            this._mongoDbService.Message.InsertOne(message);
            return Task.FromResult(
                new OutgoingMessage()
                {
                    ObjectId = message.Id,
                    Content = message.Content,
                    Date = message.SendDate.ToString(CultureInfo.CurrentCulture)                    
                }
                );
        }
    }
}