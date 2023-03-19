using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RESTFulSense.Clients;
using Tarteeb.School.Models.Configurations;

namespace Tarteeb.School.Brokers.ApiBrokers
{
    public partial class ApiBroker : IApiBroker
    {
        private HttpClient httpClient;
        private readonly IConfiguration conifguration;
        private readonly IRESTFulApiFactoryClient apiClient;

        public ApiBroker(HttpClient httpClient,
            IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.conifguration = configuration;
            this.apiClient = GetApiClient(configuration);
        }

        private async ValueTask<T> GetAsync<T>(string relativeUrl) =>
            await this.apiClient.GetContentAsync<T>(relativeUrl);

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PostContentAsync<T>(relativeUrl, content);

        private IRESTFulApiFactoryClient GetApiClient(IConfiguration configuration)
        {
            LocalConfigurations localConfigurations =
                configuration.Get<LocalConfigurations>();

            string apiBaseUrl = localConfigurations.ApiConfiguration.Url;
            this.httpClient.BaseAddress = new Uri(apiBaseUrl);
            string accessToken = GetToken();

            this.httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);

            return new RESTFulApiFactoryClient(this.httpClient);
        }

        private string GetToken() =>
            "";
    }
}
