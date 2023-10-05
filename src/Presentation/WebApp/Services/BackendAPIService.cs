namespace WebApp.Services
{
    public sealed class BackendAPIService : IDisposable
    {
        public HttpClient Client { get; private set; }

        public BackendAPIService(HttpClient httpClient, ILogger<BackendAPIService> logger)
        {
            Client = httpClient;
        }

        public void Dispose() => Client?.Dispose();
    }
}
