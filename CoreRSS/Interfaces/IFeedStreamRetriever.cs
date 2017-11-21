namespace CoreRSS.Interfaces
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IFeedStreamRetriever
    {
        Task<Stream> GetStreamForUrlAsync(string url);
    }
}
