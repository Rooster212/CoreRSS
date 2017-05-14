namespace CoreRSS.Tests
{
    using global::CoreRSS.Domain;
    using NUnit.Framework;
    using System.Linq;
    using System.Threading.Tasks;

    public class RSSFeedParserTests
    {
        [TestCase("http://blog.dota2.com/feed/")]
        [TestCase("http://feeds.reuters.com/Reuters/worldNews")]
        public async Task CanRetrieveRSSFeed(string feedUrl)
        {
            var feed = new RSSFeed(feedUrl);

            var items = await feed.Items();

            Assert.That(items.Count(), Is.Not.Zero);
        }
    }
}
