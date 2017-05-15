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
        [TestCase("http://feeds.bbci.co.uk/news/world/rss.xml")]
        [TestCase("http://www1.cbn.com/app_feeds/rss/news/rss.php?section=us")]
        [TestCase("http://feeds.bbci.co.uk/news/technology/rss.xml")]
        [TestCase("http://feeds.reuters.com/reuters/businessNews?format=xml")]
        [TestCase("http://www.techradar.com/rss")]
        public async Task CanRetrieveRSSFeed(string feedUrl)
        {
            var feed = new RSSFeed(feedUrl);

            var items = await feed.ItemsAsync();

            Assert.That(items.Count(), Is.Not.Zero);
        }
    }
}
