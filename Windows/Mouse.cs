using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System.NET.CSharp.Windows
{
	public class Mouse
	{
		[DllImport("user32")]
		private static extern bool SetCursorPos(int x, int y);

		[DllImport("user32", EntryPoint = "mouse_event")]
		private static extern void SetMouseState(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		private const int mouseleft_down = 0x02;
		private const int mouseleft_up = 0x04;

		public static Point GetCenterScreenPoint(int screenIndex)
		{
			for (int i = 0; i < Screen.AllScreens.Length; i++)
			{
				if (screenIndex == i)
				{
					Rectangle screenArea = Screen.AllScreens[i].WorkingArea;
					Point centerLocation = new Point(
						(screenArea.Width / 2) - 2,
						(screenArea.Height / 2) - 2
						);
					return centerLocation;
				}
				else if (screenIndex != i)
				{
					throw new IndexOutOfRangeException("Could not find a Screen of that index within all given Screens.");
				}
			}
			return new Point(0, 0);
		}
		public static int GetHorizontalCenter(int screenIndex)
		{
			var location = GetCenterScreenPoint(screenIndex);
			return location.X;
		}
		public static int GetVerticalCenter(int screenIndex)
		{
			var location = GetCenterScreenPoint(screenIndex);
			return location.Y;
		}

		public static void ResetPos()
		{
			Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
			Point centerLocation = new Point(
				(screenArea.Width / 2) - 2,
				(screenArea.Height / 2) - 2
				);
			SetPos(centerLocation.X, centerLocation.Y);
		}
		public static void SetPos(int x, int y)
		{
			SetCursorPos(x, y);
		}

		public static void InvokeMouseEvent(MouseButtons mouseButton, int x, int y)
		{
			switch (mouseButton)
			{
				case MouseButtons.Left:
					SetMouseState(mouseleft_down, x, y, 0, 0);
					break;
				case MouseButtons.Right:
					SetMouseState(mouseleft_up, x, y, 0, 0);
					break;
			}
		}
	}
}
