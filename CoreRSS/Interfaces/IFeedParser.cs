using System.Collections.Generic;
using CoreRSS.Domain;
using CoreRSS.Interfaces;
using System.Threading.Tasks;

namespace CoreRSS
{
    interface IFeedParser
    {
        FeedType Parses { get; }

        Task<IEnumerable<IFeedItem>> GetItems(FeedDefinition feed);
    }
}
