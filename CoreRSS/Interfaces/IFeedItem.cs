using System;

namespace CoreRSS.Interfaces
{
    public interface IFeedItem
    {
        string Title { get; }

        string Content { get; }

        DateTime PublishDate { get; }
    }
}
