namespace CoreRSS
{
    using global::CoreRSS.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    internal interface IFeedParser
    {
        FeedType Parses { get; }

        Task<IEnumerable<Item>> ItemsAsync();
    }
}
