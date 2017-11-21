namespace CoreRSS.Concrete.Parsers
{
    using System;
    using System.Collections.Generic;
    using global::CoreRSS.Domain;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Xml.Linq;

    public class RSSFeedParser : IFeedParser
    {
        public RSSFeedParser(string url)
        {
            URL = url;
        }

        public string URL { get; private set; }

        public async Task<IEnumerable<Item>> ItemsAsync()
        {
            using (var streamRetriever = new RemoteFeedStreamRetriever())
            {
                var stream = await streamRetriever.GetStreamForUrlAsync(URL);

                var doc = XDocument.Load(stream);

                var channel = doc.Root.ElementByName("channel");

                var entries = channel.ElementsByName("item");

                return entries.Select(e =>
                {
                    var date = DateTime.Parse(e.ElementValueByName("pubDate"));
                    var content = e.ElementValueByName("description");
                    var title = e.ElementValueByName("title");
                    var link = e.ElementValueByName("link");

                    return Item.CreateItem(title, content, date, link);
                });
            }
        }

        public FeedType Parses => FeedType.RSS;
    }
}
