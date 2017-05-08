namespace CoreRSS.Domain
{
    public class FeedDefinition
    {
        public string URL { get; private set; }

        public string Name { get; private set; }

        public static FeedDefinition Create(string name, string link)
        {
            return new FeedDefinition
            {
                URL = link,
                Name = name
            };
        }
    }
}
