using System.Windows.Forms;

namespace System.NET.CSharp.Windows
{
	public class ThreadManipulator
	{
		public static void Wait(Action action, int millisecondInterval)
		{
			Timer t = new Timer { Interval = millisecondInterval };
			t.Tick += (sender, e) =>
			{
				action.Invoke();
				t.Enabled = false;
				t.Dispose();
			};
			t.Start();
		}
		public static void Wait(CustomAction action, int millisecondInterval, params object[] args)
		{
			Timer t = new Timer { Interval = millisecondInterval };
			t.Tick += (sender, e) =>
			{
				action.Invoke(args);
				t.Enabled = false;
				t.Dispose();
			};
			t.Start();
		}
	}
}
