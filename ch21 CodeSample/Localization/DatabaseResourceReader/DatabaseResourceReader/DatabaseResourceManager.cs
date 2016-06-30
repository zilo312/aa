#region Using directives

using System;
using System.Collections;
using System.Text;
using System.Resources;
using System.Globalization;
using System.Diagnostics;

#endregion

namespace Wrox.ProCSharp.Localization
{
	public class DatabaseResourceManager : ResourceManager
	{
		private string dsn;

		public DatabaseResourceManager(string connectionString)
		{
			this.dsn = connectionString;
			ResourceSets = new Hashtable();
		}

		protected override ResourceSet InternalGetResourceSet(
			CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			DatabaseResourceSet rs = null;

			if (ResourceSets.Contains(culture.Name))
			{
                Trace.WriteLine(String.Format("DatabaseResourceManager, resource set {0} already exists", culture.Name));
				rs = ResourceSets[culture.Name] as DatabaseResourceSet;
			}
			else
			{
                Trace.WriteLine(String.Format("DatabaseResourceManager, resource set {0} created", culture.Name));
				rs = new DatabaseResourceSet(dsn, culture);
				ResourceSets.Add(culture.Name, rs);
			}
			return rs;
		}
	}
}
