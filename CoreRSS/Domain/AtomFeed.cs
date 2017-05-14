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

        public string URL {
            get {
                return Reader.URL;
            }
        }

        public async Task<IEnumerable<Item>> Items()
        {
            return await Reader.GetItems();
        }
    }
}
