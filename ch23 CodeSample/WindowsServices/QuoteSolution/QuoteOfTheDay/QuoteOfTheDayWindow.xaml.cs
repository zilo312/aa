using System;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Input;


namespace QuoteOfTheDay
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class QuoteOfTheDayWindow : System.Windows.Window
    {

        public QuoteOfTheDayWindow()
        {
            InitializeComponent();
            this.buttonGetQuote.Click += new RoutedEventHandler(OnGetQuote);
        }

        void OnGetQuote(object sender, RoutedEventArgs e)
        {
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.Wait;

            string serverName = Properties.Settings.Default.ServerName;
            int port = Properties.Settings.Default.PortNumber;

            TcpClient client = new TcpClient();
            NetworkStream stream = null;
            try
            {
                client.Connect(serverName, port);
                stream = client.GetStream();
                byte[] buffer = new Byte[1024];
                int received = stream.Read(buffer, 0, 1024);
                if (received <= 0)
                {
                    return;
                }
                textQuote.Text = Encoding.Unicode.GetString(buffer).Trim('\0');
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error Quote of the day", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                
                if (client.Connected)
                    client.Close();
            }

            this.Cursor = currentCursor;
            
        }

    }
}