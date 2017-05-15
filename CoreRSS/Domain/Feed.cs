namespace CoreRSS.Domain
{
    using System;

    public class Feed
    {
        public string Name { get; private set; }

        public FeedType Type { get; private set; }

        public string Title { get; private set; }

        public DateTime Updated { get; private set; }

        public string Author { get; private set; }
    }
}
