namespace CoreRSS.Concrete.Parsers
{
    using System;
    using System.Collections.Generic;
    using global::CoreRSS.Domain;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class RSSFeedParser : IFeedParser
    {
        public RSSFeedParser(string url)
        {
            URL = url;
        }

        public string URL { get; private set; }

        public Task<IEnumerable<Item>> GetItems()
        {
            throw new NotImplementedException();
        }

        public Task<XDocument> RetrieveFeed()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> Items()
        {
            throw new NotImplementedException();
        }

        public FeedType Parses => FeedType.RSS;
    }
}
