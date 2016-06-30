#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

#endregion

namespace ResourceDemo
{
	partial class ResourceDemoForm : Form
	{
		// private System.Resources.ResourceManager rm;

		public ResourceDemoForm()
		{
			InitializeComponent();

//			Assembly assembly = Assembly.GetExecutingAssembly();
//
//			rm = new ResourceManager("ResourceDemo.Demo", assembly);
//
//			pictureLogo.Image = (Image)rm.GetObject("WroxLogo");
//			textTitle.Text = rm.GetString("Title");
//			textChapter.Text = rm.GetString("Chapter");
//			textAuthor.Text = rm.GetString("Author");
//			textPublisher.Text = rm.GetString("Publisher");

			pictureLogo.Image = Demo.WroxLogo;
			textTitle.Text = Demo.Title;
			textChapter.Text = Demo.Chapter;
			textAuthor.Text = Demo.Author;
			textPublisher.Text = Demo.Publisher;

		}
	}
}