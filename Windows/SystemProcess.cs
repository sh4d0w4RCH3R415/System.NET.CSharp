using System.Diagnostics;

namespace System.NET.CSharp.Windows
{
	public class SystemProcess
	{
		private const string commandprompt		 =			 "cmd.exe";
		private const string controlpanel		 =			 "control.exe";
		private const string fileexplorer		 =			 "explorer.exe";
		private const string mspaint			 =			 "mspaint.exe";
		private const string notepad			 =			 "notepad.exe";
		private const string registryeditor		 =			 "regedit.exe";
		private const string syspropAdvanced	 = sysprop + "Advanced.exe";
		private const string syspropComputerName = sysprop + "ComputerName.exe";
		private const string syspropHardware	 = sysprop + "Hardware.exe";
		private const string syspropPerformance  = sysprop + "Performance.exe";
		private const string win10calc			 =			 "calc.exe";
		private const string win10settings		 =			 "ms-settings:home";
		private const string win10store			 =			 "ms-windows-store:";
		private const string wordpad			 =			 "write.exe";

		private const string sysprop			 =			 "SystemProperties";

		public static Process Start(SystemProcesses sysProc)
		{
			switch (sysProc)
			{
				case SystemProcesses.Notepad:
					return Process.Start(notepad);
				case SystemProcesses.FileExplorer:
					return Process.Start(fileexplorer);
				case SystemProcesses.RegistryEditor:
					return Process.Start(registryeditor);
				case SystemProcesses.CommandPrompt:
					return Process.Start(commandprompt);
				case SystemProcesses.Win10Calc:
					return Process.Start(win10calc);
				case SystemProcesses.WordPad:
					return Process.Start(wordpad);
				case SystemProcesses.ControlPanel:
					return Process.Start(controlpanel);
				case SystemProcesses.Win10Store:
					return Process.Start(win10store);
				case SystemProcesses.Win10Settings:
					return Process.Start(win10settings);
				case SystemProcesses.MSPaint:
					return Process.Start(mspaint);
				case SystemProcesses.SysProp_Advanced:
					return Process.Start(syspropAdvanced);
				case SystemProcesses.SysProp_ComputerName:
					return Process.Start(syspropComputerName);
				case SystemProcesses.SysProp_Hardware:
					return Process.Start(syspropHardware);
				case SystemProcesses.SysProp_Performance:
					return Process.Start(syspropPerformance);
			}

			return null;
		}
	}
}
