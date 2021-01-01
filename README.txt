 --- IMPORTANT INFORMATION ---
 If you are implementing my custom-made LoginForm to your application, you must make sure to
 modify your Program.cs's code for the Main() method to be like this:
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
			static void Main()
			{
				try
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Form1());
				}
				catch { }
			}
		}
	}
otherwise the program will just throw a stupid "ObjectDisposedException" exception. One more
thing, do note that if you DO NOT add this throw/catch statement, your code will ALWAYS have
this stupid error.

--- CREDITS ---
Original Author: sh4d0w4RCH3R415
Author: sh4d0w4RCH3R415

--- GITHUB ---
File: System.NET.CSharp
GitHub Repository: https://github.com/sh4d0w4RCH3R415/System.NET.CSharp/
Releases: https://github.com/sh4d0w4RCH3R415/System.NET.CSharp/releases/
Latest Release: https://github.com/sh4d0w4RCH3R415/System.NET.CSharp/releases/download/1.0.8/System.NET.CSharp.dll
My Profile: https://github.com/sh4d0w4RCH3R415/
