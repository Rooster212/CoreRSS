namespace CoreRSS
{
    using global::CoreRSS.Domain;
    using global::CoreRSS.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    internal interface IFeedParser
    {
        FeedType Parses { get; }

        Task<IEnumerable<Item>> Items();
    }
}
