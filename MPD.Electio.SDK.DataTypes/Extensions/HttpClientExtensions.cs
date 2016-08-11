using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MPD.Electio.SDK.DataTypes.Extensions
{
    public static class HttpClientExtensions
    {

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri)
        {
            return await PatchAsync(client, requestUri, null);
        }

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri,
            HttpContent iContent)
        {
            var buildUri = new UriBuilder(client.BaseAddress);
            buildUri.Path = CombinePaths(buildUri.Path, requestUri);
            return await PatchAsync(client, buildUri.Uri, iContent);
        }

        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri,
            HttpContent iContent)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = iContent
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException e)
            {
                Debug.WriteLine("Error: " + e.ToString());
            }

            return response;
        }

        public static string CombinePaths(string path1, string path2)
        {
            if (path1.Length == 0)
            {
                return path2;
            }

            if (path2.Length == 0)
            {
                return path1;
            }

            path1 = path1.TrimEnd('/', '\\');
            path2 = path2.TrimStart('/', '\\');

            return $"{path1}/{path2}";

        }
    }
}
