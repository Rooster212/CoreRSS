using CoreRSS.Interfaces;
using System;

namespace CoreRSS.Concrete
{
    public class FeedItem : IFeedItem
    {
        public string Title => throw new NotImplementedException();

        public string Content => throw new NotImplementedException();

        public DateTime PublishDate => throw new NotImplementedException();
    }
}
