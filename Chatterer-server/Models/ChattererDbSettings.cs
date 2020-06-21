﻿namespace Chatterer_server.Interfaces
{
    public class ChattererDbSettings : IChattererDbSettings
    {
        public string UserCollectionsName { get; set; }
        public string MessagesCollectionsName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseLogin { get; set; }
        public string DatabasePassword { get; set; }
    }
}