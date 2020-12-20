using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.NET.CSharp.Graphics;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.Label))]
	public class LinkLabel : System.Windows.Forms.Label
	{
		private TextRenderingHint textClarity = TextRenderingHint.ClearTypeGridFit;
		private string link = "https://www.google.com/";

		public TextRenderingHint TextClarity
		{
			get { return textClarity; }
			set { textClarity = value; Invalidate(); }
		}
		public string Link
		{
			get { return link; }
			set { link = value; Invalidate(); }
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);

			Process.Start(link);
		}
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public LinkLabel()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			AutoSize = false;
			Size = new Size(84, 33);
			Font = new Font("Roboto", 14f, FontStyle.Underline);
			BackColor = Parent != null ? Parent.BackColor : SystemColors.Control;
			ForeColor = Parent != null ? Parent.ForeColor : SystemColors.ControlText;

			Cursor = Cursors.Hand;
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
