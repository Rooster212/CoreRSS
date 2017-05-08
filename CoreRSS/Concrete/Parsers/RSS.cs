using System;
using System.Collections.Generic;
using CoreRSS.Domain;
using CoreRSS.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace CoreRSS.Concrete.Parsers
{
    public class RSS : IFeedParser
    {
        public Task<IEnumerable<IFeedItem>> GetItems(FeedDefinition feed)
        {
            throw new NotImplementedException();
        }

        public FeedType Parses => FeedType.RSS;
    }
}
