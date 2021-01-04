using System.Runtime.InteropServices;

using ping = System.Net.NetworkInformation.Ping;

namespace System.NET.CSharp.Internet
{
	public class Internet
	{
		[DllImport("wininet", EntryPoint = "InternetGetConnectedState")]
		private static extern bool GetInternetState(out int description, int reservedValue);

		public static bool IsInternetAvailable()
		{
			int description;
			return GetInternetState(out description, 0);
		}
		public static string GetPing()
		{
			if (IsInternetAvailable())
			{
				return new ping().Send("www.google.com").RoundtripTime.ToString() + "ms";
			}
			else
			{
				throw new InvalidOperationException("Operation failed to complete because internet is not connected.\n" +
					"Please try connecting to the internet before trying again.");
			}
		}
	}
}
