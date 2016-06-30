#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Globalization;

#endregion

namespace Wrox.ProCSharp.Localization
{
	public class DatabaseResourceSet : ResourceSet
	{
		internal DatabaseResourceSet(string connectionString, CultureInfo culture)
			: base(new DatabaseResourceReader(connectionString, culture))
		{
		}

		public override Type GetDefaultReader()
		{
			return typeof(DatabaseResourceReader);
		}
	}
}
