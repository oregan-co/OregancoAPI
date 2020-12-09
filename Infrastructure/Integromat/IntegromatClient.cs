using System;
using System.Net;
using RestSharp;

namespace OreganCoAPI.Infrastructure.Integromat
{
    public class IntegromatClient : IIntegromatClient
    {
        private readonly string _integromatBaseUrl;

        public IntegromatClient()
        {
            _integromatBaseUrl = "https://hook.integromat.com/";
        }

        public HttpStatusCode SendIntegromatWebhook<T>(string requestUrl, T requestBody, RestSharp.Method method)
        {
            var client = new RestClient(_integromatBaseUrl);

            var request = new RestRequest(requestUrl, method);

            if (!(requestBody is null))
            {
                request.AddJsonBody(requestBody);
            }

            var response = client.Execute(request);

            //var content = response.Content;

            //var deserializedContent = JsonConvert.DeserializeObject<string>(response.Content);

            var statusCode = response.StatusCode;

            return statusCode;
        }
    }
}
