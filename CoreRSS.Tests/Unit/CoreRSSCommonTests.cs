namespace CoreRSS.Tests.Unit
{
    using CoreRSS.Concrete;
    using NUnit.Framework;
    using System.Threading.Tasks;

    public class CoreRSSCommonTests
    {
        private string testUrl = "http://feeds.bbci.co.uk/news/uk/rss.xml?edition=uk";

        [Test]
        public async Task CanRetrieveFeedFromUrl()
        {
            var feed = await CoreRSSCommon.RetrieveFeedAsync(testUrl);

            Assert.That(feed, Is.Not.Null);
        }
    }
}
