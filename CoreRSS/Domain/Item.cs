using System;

namespace CoreRSS.Domain
{
    public class Item
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public FeedDefinition Feed { get; set; }

        public static Item CreateItem(string link, string title, string content, DateTime publishDate, FeedDefinition feed)
        {
            return new Item
            {
                Content = content,
                Title = title,
                PublishDate = publishDate,
                Feed = feed
            };
        }
    }
}
