namespace Chatterer_server.Interfaces
{
    public interface IChattererDbSettings
    {
        string UserCollectionsName { get; set; }
        string MessagesCollectionsName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string DatabaseLogin { get; set; }
        string DatabasePassword { get; set; }
    }
}