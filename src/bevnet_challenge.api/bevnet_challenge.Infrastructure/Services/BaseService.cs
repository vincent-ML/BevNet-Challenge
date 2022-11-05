namespace bevnet_challenge.Infrastructure.Services
{
    public class BaseService
    {
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            return response;
        }
    }
}
