namespace CoreRSS.Domain
{
    using System;

    public class Item
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string Link { get; set; }

        public static Item CreateItem(string title, string content, DateTime publishDate, string link)
        {
            return new Item
            {
                Content = content,
                Title = title,
                PublishDate = publishDate,
                Link = link
            };
        }
    }
}
