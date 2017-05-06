using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Liquid.Library.Domain.Inventory;

namespace Liquid.Library.Commands
{
    interface ICommand
    {
        Task Execute();
    }

    public class Command
    {
        private const string _address = "http://enterprise.dverheijen.com/";
        private const string _mediaType = "application/json";

        private HttpClient Client()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_address);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_mediaType));
            return client;
        }

        protected async Task<T> Get<T>(string path)
        {
            var response = await Client().GetAsync(path);
            if (!response.IsSuccessStatusCode)
                throw new Exception();

            return await response.Content.ReadAsAsync<T>();
        }

        protected async Task<T> Post<T>(string path, object obj)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, _mediaType);
            var response = await Client().PostAsync(path, stringContent);
            if (!response.IsSuccessStatusCode)
                throw new Exception();

            return await response.Content.ReadAsAsync<T>();
        }

        protected async Task Patch(string path, object obj)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, _mediaType);
            var response = await Client().PatchAsync(path, stringContent);
            if (!response.IsSuccessStatusCode)
                throw new Exception();
        }

        protected async Task Delete(string path)
        {
            var response = await Client().DeleteAsync(path);
            if (!response.IsSuccessStatusCode)
                throw new Exception();
        }
    }

    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent iContent)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri);
            request.Content = iContent;

            return await client.SendAsync(request);
        }
    }
}
