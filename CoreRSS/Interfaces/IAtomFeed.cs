using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRSS.Interfaces
{
    interface IAtomFeed
    {
        string Title { get; }

        string Subtitle { get; }

        string Id { get; }

        DateTime LastUpdated { get; }

        IFeedItem Entry { get; }
    }
}
