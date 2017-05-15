namespace CoreRSS.Domain
{
    using global::CoreRSS.Concrete.Parsers;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AtomFeed : Feed
    {
        public AtomFeed(string url)
        {
            Reader = new AtomFeedParser(url);
        }

        private AtomFeedParser Reader { get; set; }

        public string URL => Reader.URL;

        public async Task<IEnumerable<Item>> ItemsAsync()
        {
            return await Reader.ItemsAsync();
        }
    }
}
