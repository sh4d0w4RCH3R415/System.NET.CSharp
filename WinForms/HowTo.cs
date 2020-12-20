using System.ComponentModel;
using System.Drawing;
using System.NET.CSharp.Graphics;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(ListBox))]
	public class HowTo : Control
	{
		private string[] steps =
		{
			"Navigate to the properties panel of this control.",
			"Navigate to the 'Steps' property.",
			"Open the String Collection Editor to modify each step.",
			"Note: Each line is its own individiual step, so type in order.",
		};

		public string[] Steps
		{
			get { return steps; }
			set { steps = value; Width++;  Invalidate(); }
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public override string Text => string.Empty;

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			string stepsJoined = string.Empty;
			for (int i = 0; i < steps.Length; i++)
			{
				if (i != steps.Length - 1)
					stepsJoined += $"{i + 1}. {steps[i]}\n";
				else if (i == steps.Length - 1)
					stepsJoined += $"{i + 1}. {steps[i]}";
			}
			var textSize = TextRenderer.MeasureText(stepsJoined, Font);

			Size = new Size(textSize.Width + 12, textSize.Height);
		}
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			base.OnResize(e);
		}

		public HowTo()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Font = new Font("Roboto", 12f);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var gfx = e.Graphics;

			string stepsJoined = string.Empty;
			for (int i = 0; i < steps.Length; i++)
			{
				if (i != steps.Length - 1)
					stepsJoined += $"{i + 1}. {steps[i]}\n";
				else if (i == steps.Length - 1)
					stepsJoined += $"{i + 1}. {steps[i]}";
			}
			var textSize = TextRenderer.MeasureText(stepsJoined, Font);

			Rectangle listRect = new Rectangle(0, 0, textSize.Width + 12, textSize.Height);

			gfx.FillRectangle(BackColor.ToBrush(), listRect);
			gfx.DrawString(stepsJoined, Font, ForeColor.ToBrush(), listRect,
				new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
		}
	}
}
