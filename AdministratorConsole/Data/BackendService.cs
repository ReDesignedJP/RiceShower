using RestSharp;

namespace AdministratorConsole.Data
{
    public class BackendService
    {
        private readonly string _api;
        private readonly RestClient _client;
        public BackendService(string api = "http://localhost:5000")
        {
            _api = api;
            _client = new(_api);
        }

        public async Task<bool> IsServerAvailable()
        {
            RestRequest req = new("/status");
            RestResponse res = await _client.ExecuteAsync(req);
            return res.IsSuccessful;
        }
    }
}
