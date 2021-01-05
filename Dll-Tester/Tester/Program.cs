using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Tester
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			TesterForm testerApp = new TesterForm();
			testerApp.Run(args);
		}

		private class TesterForm : WindowsFormsApplicationBase
		{
			public TesterForm()
			{
				MainForm = new Form1();
				IsSingleInstance = true;
			}

			protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
			{
				((Form1)MainForm).RefocusWindow();
			}
		}
	}
}
