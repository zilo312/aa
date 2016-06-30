using System.Windows.Forms;
using System.IO;
using System.Net;

namespace BasicWebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Net.WebClient Client = new WebClient();
            Stream strm = Client.OpenRead("http://www.reuters.com");
            StreamReader sr = new StreamReader(strm);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }

            strm.Close();

        }
    }
}