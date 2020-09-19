using System;
using System.Net.Http;

namespace Playground
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
