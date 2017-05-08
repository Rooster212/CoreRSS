namespace CoreRSS
{
    using global::CoreRSS.Domain;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    public class CoreRSS
    {
        private readonly IList<FeedDefinition> Feeds;

        public CoreRSS()
        {
            Feeds = new List<FeedDefinition>();
        }

        public void AddFeed(string name, string url)
        {
            var newFeed = FeedDefinition.Create(name, url);
            Feeds.Add(newFeed);
        }

        public void Init()
        {
            AddFeed("Dota 2 Blog", "http://blog.dota2.com/feed/");
        }
    }
}
