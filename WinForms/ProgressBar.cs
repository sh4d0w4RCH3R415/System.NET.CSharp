using System.ComponentModel;
using System.Drawing;
using System.NET.CSharp.General;
using System.NET.CSharp.Graphics;
using System.NET.CSharp.Transitions;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;
using RectangleF = System.Drawing.RectangleF;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.ProgressBar))]
	public class ProgressBar : Control
	{
		private double progress;
		private Color progressColor = ColorMixer.NiceBlue;
		private Color backgroundColor = ColorMixer.NiceBlack;
		
		public double Progress
		{
			get { return progress; }
			set { progress = value; Invalidate(); }
		}
		public Color ProgressColor
		{
			get { return progressColor; }
			set { progressColor = value; Invalidate(); }
		}
		public Color BackgroundColor
		{
			get { return backgroundColor; }
			set { backgroundColor = value; Invalidate(); }
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public new Size MinimumSize
		{
			get { return new Size(100, 10); }
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			if (Width < 100) Width = 100;
			if (Height < 10) Height = 10;
		}
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			base.OnResize(e);
		}

		public ProgressBar()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(200, 10);
		}
		public void Increment(double amount)
		{
			Transition.run(this, "Progress", amount, new TransitionType_Linear(1500));
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var gfx = e.Graphics;

			int inside_padding = 2;

			Rectangle containerRect = new Rectangle(0, 0, Width, Height);
			RectangleF progressRect = new RectangleF(inside_padding, inside_padding, (float)(Width * (progress / 100) - (inside_padding * 2)), Height - (inside_padding * 2));

			gfx.FillRectangle(backgroundColor.ToBrush(), containerRect);
			gfx.FillRectangle(progressColor.ToBrush(), progressRect);
		}
	}
}
