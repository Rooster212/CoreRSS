namespace CoreRSS.Concrete
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public static class CoreRSSCommon
    {
        public static async Task<XDocument> RetrieveFeed(string url)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                using (var response = await client.SendAsync(request))
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return XDocument.Load(stream);
                }
            }
        }
    }
}
