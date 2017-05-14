namespace CoreRSS.Concrete.Parsers
{
    using System.Collections.Generic;
    using global::CoreRSS.Domain;
    using global::CoreRSS.Concrete;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Xml.Linq;
    using System;

    public class AtomFeedParser : IFeedParser
    {
        public AtomFeedParser(string url)
        {
            URL = url;
        }

        public string URL { get; private set; }

        public FeedType Parses => FeedType.Atom;

        public async Task<IEnumerable<Item>> GetItems()
        {
            var doc = await CoreRSSCommon.RetrieveFeed(URL);

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

        public async Task<string> Id() => await RetrieveRootElementValue("id");

        public async Task<string> Link() => await RetrieveRootElementValue("link");

        public async Task<string> Title() => await RetrieveRootElementValue("title");

        public async Task<string> Subtitle() => await RetrieveRootElementValue("subtitle");

        private async Task<string> RetrieveRootElementValue(string name)
        {
            var doc = await CoreRSSCommon.RetrieveFeed(URL);
            return doc.Root.ElementByName(name.ToLower())?.Value;
        }

        public Task<IEnumerable<Item>> Items()
        {
            throw new NotImplementedException();
        }
    }
}
