using System;
using System.IO;
using System.Security;
using System.Windows.Forms;


namespace SimpleExample
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnLoadData(object sender, EventArgs e)
		{
         try
			{
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "animals.txt");


            using (StreamReader stream = File.OpenText(filename))
            {
               string str;
               while ((str = stream.ReadLine()) != null)
               {
                  listAnimals.Items.Add(str);
               }
            }
			}
         catch (SecurityException ex)
         {
            MessageBox.Show(ex.Message);
         }

		}
	}
}