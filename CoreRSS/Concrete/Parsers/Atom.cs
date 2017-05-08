using System;
using System.Collections.Generic;
using CoreRSS.Domain;
using CoreRSS.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreRSS.Concrete.Parsers
{
    public class Atom : IFeedParser
    {
        public async Task<IEnumerable<IFeedItem>> GetItems(FeedDefinition feed)
        {
            using (var client = new HttpClient())
            {
                var req = new HttpRequestMessage(HttpMethod.Get, feed.URL);

                using (var response = await client.SendAsync(req))
                using(var stream = await response.Content.ReadAsStreamAsync())
                {
                    var xmlSerialiser = new XmlSerializer(typeof(IAtomFeed));
                }
            }

            throw new NotImplementedException();
        }

        public FeedType Parses => FeedType.Atom;
    }
}
