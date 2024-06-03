using Newtonsoft.Json;
using RestSharp;

namespace BookStore.BLL.Extensions
{
    public static class HttpClientExt
    {
        public static T Get<T>(string baseUrl, string subPath, long timeout = 300) where T : new()
        {
            long timeOutInSecound = timeout * 10000000;
            TimeSpan maxTimeOut = new(timeOutInSecound);
            var options = new RestClientOptions(baseUrl)
            {
                Timeout = maxTimeOut
            };
            var client = new RestClient(options);
            //client.UserAgent = GetUserAgent();
            var request = new RestRequest(subPath, Method.Get);

            var response = client.Execute(request);
            if (response.IsSuccessful)
                return JsonConvert.DeserializeObject<T>(response.Content);
            return default(T);
        }
    }
}
