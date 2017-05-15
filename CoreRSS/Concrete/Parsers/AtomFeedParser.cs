namespace CoreRSS.Concrete.Parsers
{
    using System.Collections.Generic;
    using global::CoreRSS.Domain;
    using global::CoreRSS.Concrete;
    using System.Threading.Tasks;
    using System.Linq;
    using System;

    public class AtomFeedParser : IFeedParser
    {
        public AtomFeedParser(string url)
        {
            URL = url;
        }

        public string URL { get; private set; }

        public FeedType Parses => FeedType.Atom;

        public async Task<IEnumerable<Item>> ItemsAsync()
        {
            var doc = await CoreRSSCommon.RetrieveFeedAsync(URL);

            var entries = doc.Root?.ElementsByName("entry");

            return entries.Select(e =>
            {
                var date = DateTime.Parse(e.ElementValueByName("published"));
                var content = e.ElementValueByName("content");
                var title = e.ElementValueByName("title");
                var link = e.ElementByName("link")?.Attribute("href")?.Value;

                return Item.CreateItem(title, content, date, link);
            });
        }

        public async Task<string> GetIdAsync() => await RetrieveRootElementValueAsync("id");

        public async Task<string> GetLinkAsync() => await RetrieveRootElementValueAsync("link");

        public async Task<string> GetTitleAsync() => await RetrieveRootElementValueAsync("title");

        public async Task<string> GetSubtitleAsync() => await RetrieveRootElementValueAsync("subtitle");

        private async Task<string> RetrieveRootElementValueAsync(string name)
        {
            var doc = await CoreRSSCommon.RetrieveFeedAsync(URL);
            return doc.Root.ElementByName(name.ToLower())?.Value;
        }
    }
}
