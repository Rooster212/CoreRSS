namespace CoreRSS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class RSSFeed : Feed
    {
        public RSSFeed(string url)
        {
            URL = url;
        }

        public string URL { get; private set; }
        
        public async Task<IEnumerable<Item>> Items()
        {
            throw new NotImplementedException();
        }
    }
}
