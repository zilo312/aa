using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;

namespace Wrox.ProCSharp.Syndication
{
   [ServiceContract]
   [ServiceKnownType(typeof(Atom10FeedFormatter))]
   [ServiceKnownType(typeof(Rss20FeedFormatter))]
   public interface IFormula1Feed
   {

      [OperationContract]
      [WebGet(UriTemplate = "*", BodyStyle = WebMessageBodyStyle.Bare)]
      SyndicationFeedFormatter CreateFeed();
   }
}
