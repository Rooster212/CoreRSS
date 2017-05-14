namespace CoreRSS.Tests
{
    using CoreRSS.Concrete.Parsers;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public class AtomFeedParserTests
    {
        private string testUrl = "http://feeds.bbci.co.uk/news/uk/rss.xml?edition=uk";

        private AtomFeedParser CreateSubject()
        {
            return new AtomFeedParser(testUrl);
        }
    }
}
