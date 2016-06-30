using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace DemandingPermissions
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			try
			{
				FileIOPermission fileIOPermission = new
				   FileIOPermission(FileIOPermissionAccess.AllAccess, @"c:\");
				fileIOPermission.Demand();
			}
			catch (SecurityException)
			{
				button1.Enabled = false;
			}

		}
	}
}