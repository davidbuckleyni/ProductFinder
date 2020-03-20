using System;
using System.Net.Http;

namespace ProductFinderCore
{
    public class ProductFinderClient
    {

        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public ProductFinderClient()
        {
            _httpClient = new HttpClient();

        }

    }
}
