using System;

namespace IntercomIoRest
{
	/// <summary>
	/// Default values for library.
	/// </summary>
	public class Defaults
	{
		public static string Host = "https://api.intercom.io";

		public static TimeSpan Timeout = TimeSpan.FromSeconds(5);

		public static int MaxQueueCapacity = 10000;
		
		public static bool Async = true;
	}
}
