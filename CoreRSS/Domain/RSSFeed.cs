namespace CoreRSS.Domain
{
    using CoreRSS.Concrete.Parsers;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class RSSFeed : Feed
    {
        public RSSFeed(string url)
        {
            Reader = new RSSFeedParser(url);
        }

        private RSSFeedParser Reader { get; set; }

        public string URL => Reader.URL;
        
        public async Task<IEnumerable<Item>> ItemsAsync()
        {
            return await Reader.ItemsAsync();
        }
    }
}
