using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Xml.Linq;

namespace Wrox.ProCSharp.Syndication
{
   // NOTE: If you change the class name "Feed1" here, you must also update the reference to "Feed1" in App.config.
   public class Formula1Feed : IFormula1Feed
   {
      public SyndicationFeedFormatter CreateFeed()
      {
         // Create a new Syndication Feed.
         SyndicationFeed feed = new SyndicationFeed();
         feed.Generator = "Pro C# 2008 Sample Feed Generator";
         feed.Language = "en-us";
         feed.LastUpdatedTime = new DateTimeOffset(DateTime.Now);
         feed.Title = SyndicationContent.CreatePlaintextContent("Formula1 results");
         feed.Categories.Add(new SyndicationCategory("Formula1"));

         feed.Authors.Add(new SyndicationPerson("web@christiannagel.com", "Christian Nagel", "http://www.christiannagel.com"));

         feed.Description = SyndicationContent.CreatePlaintextContent("Sample Formula 1");

         Formula1DataContext data = new Formula1DataContext();

         feed.Items = from racer in data.Racers
                      from raceResult in racer.RaceResults
                      where raceResult.Race.Date > new DateTime(2007, 1, 1) && raceResult.Position == 1
                      orderby raceResult.Race.Date
                      select new SyndicationItem()
                      {
                         Title = SyndicationContent.CreatePlaintextContent(String.Format("G.P. {0}", raceResult.Race.Circuit.Country)),
                         Content = SyndicationContent.CreateXhtmlContent(
                         new XElement("p",
                            new XElement("h3", String.Format("{0}, {1}", raceResult.Race.Circuit.Country, raceResult.Race.Date.ToShortDateString())),
                            new XElement("b", String.Format("Winner: {0} {1}", racer.Firstname, racer.Lastname))).ToString())
                      };




         //List<SyndicationItem> items = new List<SyndicationItem>();

         //// Create a new Syndication Item.
         //SyndicationItem item = new SyndicationItem("An item", "Item content", null);
         //items.Add(item);
         //feed.Items = items;

         // Return ATOM or RSS based on query string
         // rss -> http://localhost:8731/Design_Time_Addresses/SyndicationService/Feed1/
         // atom -> http://localhost:8731/Design_Time_Addresses/SyndicationService/Feed1/?format=atom
         string query = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
         SyndicationFeedFormatter formatter = null;
         if (query == "atom")
         {
            formatter = new Atom10FeedFormatter(feed);
         }
         else
         {
            formatter = new Rss20FeedFormatter(feed);
         }

         return formatter;
      }
   }
}
