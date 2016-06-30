using System;

namespace AppSupport
{
	/// <summary>
	/// Summary description for Support.
	/// </summary>
	public class Support
	{
		private Support()
		{
		}

    public static string GetDateTimeInfo()
    {
      DateTime dt = DateTime.Now;
      return string.Concat("This is the current date and time: ", dt.ToLongDateString(), " ", dt.ToLongTimeString());
    }
	}
}
