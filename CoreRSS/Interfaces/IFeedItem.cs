namespace CoreRSS.Interfaces
{
    using System;

    public interface IFeedItem
    {
        string Title { get; }

        string Content { get; }

        DateTime PublishDate { get; }
    }
}
