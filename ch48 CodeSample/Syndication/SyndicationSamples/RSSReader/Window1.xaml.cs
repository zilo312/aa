using System.ServiceModel.Syndication;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace Wrox.ProCSharp.Syndication
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();
      }

      private void OnGetFeed(object sender, RoutedEventArgs e)
      {
         XmlReader reader = XmlReader.Create(textUrl.Text);

         Rss20FeedFormatter formatter = new Rss20FeedFormatter();
         formatter.ReadFrom(reader);
         reader.Close();

         this.DataContext = formatter.Feed;

         this.feedContent.DataContext = formatter.Feed.Items;

         
      }
   }
}
