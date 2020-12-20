﻿using System.Drawing;
using System.Drawing.Text;
using System.NET.CSharp.General;
using System.NET.CSharp.Graphics;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	public class Button : Control
	{
		private TextRenderingHint textClarity = TextRenderingHint.ClearTypeGridFit;

		public TextRenderingHint TextClarity
		{
			get { return textClarity; }
			set { textClarity = value; Invalidate(); }
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public Button()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(84, 33);
			Font = new Font("Roboto", 14f);
			BackColor = ColorMixer.NiceBlue;
			ForeColor = Color.White;
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
