using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.NET.CSharp.Windows
{
	public static class Power
	{
		[DllImport("user32")]
		private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

		[DllImport("user32")]
		private static extern void LockWorkStation();

		[DllImport("powrprof", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

		public static void Shutdown()
		{
			Process.Start("shutdown", "/s /t 0");
		}
		public static void Shutdown(int timeBeforeShutdown)
		{
			Process.Start("shutdown", $"/s /t {timeBeforeShutdown}");
		}

		public static void Restart()
		{
			Process.Start("shutdown", "/r /t 0");
		}
		public static void Restart(int timeBeforeRestart)
		{
			Process.Start("shutdown", $"/r /t {timeBeforeRestart}");
		}

		public static void LogOff()
		{
			ExitWindowsEx(0, 0);
		}
		public static void Lock()
		{
			LockWorkStation();
		}

		public static void Hibernate()
		{
			SetSuspendState(true, true, true);
		}
		public static void Sleep()
		{
			SetSuspendState(false, true, true);
		}
	}
}
