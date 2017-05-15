namespace CoreRSS.Tests
{
    using CoreRSS.Concrete.Parsers;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public class AtomFeedParserTests
    {
        private string testUrl = "";

        private AtomFeedParser CreateSubject()
        {
            return new AtomFeedParser(testUrl);
        }

        //[Test]
        //public async Task CanRetrieveAtomFeed()
        //{
        //    var subject = CreateSubject();

        //    var items = await subject.ItemsAsync();

        //    Assert.That(items, Is.Not.Empty);
        //}
    }
}
