namespace CoreRSS.Concrete
{
    using System.IO;
    using CoreRSS.Interfaces;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public class RemoteFeedStreamRetriever : IFeedStreamRetriever, IDisposable
    {
        private Stream stream = null;

        public void Dispose()
        {
            stream?.Dispose();
        }

        public async Task<Stream> GetStreamForUrlAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                using (var response = await client.SendAsync(request))
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    return stream;
                }
            }
        }
    }
}
