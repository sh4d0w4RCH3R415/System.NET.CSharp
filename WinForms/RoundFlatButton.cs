using System.Drawing;
using System.Drawing.Text;
using System.NET.CSharp.General;
using System.NET.CSharp.Graphics;
using System.NET.CSharp.Transitions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	public class RoundFlatButton : Control
	{
		private TextRenderingHint textClarity = TextRenderingHint.ClearTypeGridFit;

		public TextRenderingHint TextClarity
		{
			get { return textClarity; }
			set { textClarity = value; Invalidate(); }
		}

		[DllImport("gdi32", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRgn(
			int left,
			int top,
			int right,
			int bottom,
			int width,
			int height
			);

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			Transition.run(this, "BackColor", BackColor.Darken(20), new TransitionType_Linear(75));
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			Transition.run(this, "BackColor", BackColor.Brighten(20), new TransitionType_Linear(75));
		}
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public RoundFlatButton()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(169, 33);
			Font = new Font("Roboto", 14f);
			BackColor = ColorMixer.NiceBlue;
			ForeColor = Color.White;

			int radius = 5;
			Resize += (sender, e) => Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width + 1, Height + 1, radius, radius));
			SizeChanged += (sender, e) => Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width + 1, Height + 1, radius, radius));
			Paint += (sender, e) => Region = Region.FromHrgn(CreateRoundRgn(0, 0, Width + 1, Height + 1, radius, radius));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var gfx = e.Graphics;

			Rectangle buttonRect = new Rectangle(0, 0, Width, Height);
			Rectangle textRect = new Rectangle(1, 1, Width, Height);

			gfx.TextRenderingHint = textClarity;

			gfx.FillRectangle(BackColor.ToBrush(), buttonRect);
			gfx.DrawString(Text, Font, ForeColor.ToBrush(), textRect,
				new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
		}
	}
}
