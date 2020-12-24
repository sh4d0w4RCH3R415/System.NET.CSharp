using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System.NET.CSharp.Windows
{
	public class gdi32
	{
		[DllImport("gdi32", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRgn(
			int left,
			int top,
			int right,
			int bottom,
			int ellipseWidth,
			int ellipseHeight
			);

		public static void SetRoundRegion(Control control)
		{
			control.SizeChanged += (sender, e) => control.Region = Region.FromHrgn(CreateRoundRgn(0, 0, control.Width, control.Height, 5, 5));
			control.Resize += (sender, e) => control.Region = Region.FromHrgn(CreateRoundRgn(0, 0, control.Width, control.Height, 5, 5));
			control.Paint += (sender, e) => control.Region = Region.FromHrgn(CreateRoundRgn(0, 0, control.Width, control.Height, 5, 5));
		}

		/* ---------------------------------------------------------------------------------- */
		/* Original Author: DJ (https://stackoverflow.com/users/10915949/d-j)                 */
		/* Author: sh4d0w4RCH3R415 (https://stackoverflow.com/users/11211458/sh4d0w4rch3r415) */
		/* File: gdi32.DropShadow.cs                                                          */
		/* Modified: TRUE                                                                     */
		/* Description: Will create a drop-shadow behind the specified form with margin       */
		/*              insets specified by the user.                                         */
		/* ---------------------------------------------------------------------------------- */
		public class DropShadow
		{
			private struct MARGINS
			{
				public int leftWidth,
					rightWidth,
					topHeight,
					bottomHeight;
			}

			[DllImport("dwmapi")]
			private static extern int DwmExtendFrameIntoClientArea(IntPtr handle, ref MARGINS pMarInset);

			[DllImport("dwmapi")]
			private static extern int DwmSetWindowAttribute(IntPtr handle, int attr, ref int attrValue, int attrSize);

			public static void ApplyShadows(Form form, int leftInset, int rightInset, int bottomInset, int topInset)
			{
				var v = 2;
				DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

				MARGINS margins = new MARGINS
				{
					bottomHeight = bottomInset,
					leftWidth = leftInset,
					rightWidth = rightInset,
					topHeight = topInset,
				};
				DwmExtendFrameIntoClientArea(form.Handle, ref margins);
			}
		}
	}
}
