using System;
using System.Net;
using RestSharp;

namespace OreganCoAPI.Infrastructure.Integromat
{
    public interface IIntegromatClient
    {
        HttpStatusCode SendIntegromatWebhook<T>(string requestUrl, T requestBody, Method method);
    }
}
