using NewsSucker.Models;
using NewsSucker.ViewModels;
using NewsSucker.Views;
using System.Collections.ObjectModel;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;

namespace NewsSucker.Services
{
    public class RssReader
    {
        readonly WebService webService;
        public RssReader()
        {
            webService = new WebService();
        }

        public async Task<ObservableCollection<Story>> LoadRssFeed(string feed)
        {
           var client = new HttpClient();
            var response = await client.GetAsync(feed);
            var xml = await response.Content.ReadAsStringAsync();

            var doc = XDocument.Parse(xml);
            var items = from item in doc.Descendants("item")
                        select new Story
                        {
                            Title = item.Element("title")?.Value,
                            StoryURL = item.Element("link")?.Value,
                            Description = item.Element("description")?.Value,
                            PublishedDate = DateTime.Parse(item.Element("pubDate")?.Value),
                            ImageURL = ""
                        };

            return new ObservableCollection<Story>(items);
        }

    }
}
