using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

using ping = System.Net.NetworkInformation.Ping;

namespace System.NET.CSharp.Internet
{
	public class Ping
	{
		public static string GetPing(string address, bool separateMS)
		{
			if (address.IndexOf("https://") == 0 || address.IndexOf("http://") == 0)
			{
				throw new ArgumentException($"Cannot send and receive a ping to: {address}");
			}
			else if (!address.Contains("https://") || !address.Contains("http://"))
			{
				string[] path = address.Split('.');
				string prefix = path[0];
				string name = path[1];
				string suffix = path[2];
				string[] path_ = suffix.Split('/');
				suffix = path_[0];
				string addr = $"{prefix}.{name}.{suffix}";
				return string.Format(separateMS ? "{0} {1}" : "{0}{1}", new ping().Send(addr), "ms");
			}

			return string.Empty;
		}
		public static int GetPing(string address)
		{
			if (address.IndexOf("https://") == 0 || address.IndexOf("http://") == 0)
			{
				throw new ArgumentException($"Cannot send and receive a ping to: {address}");
			}
			else if (!address.Contains("https://") || !address.Contains("http://"))
			{
				string[] path = address.Split('.');
				string prefix = path[0];
				string name = path[1];
				string suffix = path[2];
				string[] path_ = suffix.Split('/');
				suffix = path_[0];
				string addr = $"{prefix}.{name}.{suffix}";
				return (int)new ping().Send(string.Format("{0}", addr)).RoundtripTime;
			}

			return 0;
		}

		public static double GetPacketLossPercent(string address, int timesToPing)
		{
			ping pingSender = new ping();
			PingOptions options = new PingOptions();

			options.DontFragment = true;

			string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
			byte[] buffer = Encoding.ASCII.GetBytes(data);
			int timeout = 120;
			int failed = 0;

			for (int i = 0; i < timesToPing; i++)
			{
				PingReply reply = pingSender.Send(address, timeout, buffer, options);
				if (reply.Status != IPStatus.Success)
				{
					failed += 1;
				}

				Application.DoEvents();
			}

			double percent = failed / timesToPing * 100;
			return percent;
		}
		public static string GetPacketLoss(string address, int timestoPing)
		{
			string packetLoss = GetPacketLossPercent(address, timestoPing).ToString();
			string pcketLoss = packetLoss.Split('.')[0];
			return $"{pcketLoss}%";
		}
		public static Stability GetStability(double packetLoss)
		{
			if (packetLoss >= .1 && packetLoss <= 1)
			{
				return Stability.Weak;
			}
			else if (packetLoss >= .05 && packetLoss <= .09)
			{
				return Stability.Moderate;
			}
			else if (packetLoss >= 0 && packetLoss <= .04)
			{
				return Stability.Strong;
			}
			return (Stability)(-1);
		}
	}
}
