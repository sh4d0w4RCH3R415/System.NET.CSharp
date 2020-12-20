using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.NET.CSharp.General;
using System.Windows.Forms;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.PictureBox))]
	public class PictureBox : Control
	{
		private Image image;

		public Image Image
		{
			get { return image; }
			set { image = value; Invalidate(); }
		}
		
		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public override string Text => string.Empty;

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public override Font Font => new Font("Microsoft Sans Serif", 8.25f);

		public PictureBox()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(50, 75);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var gfx = e.Graphics;

			gfx.SmoothingMode = SmoothingMode.HighQuality;

			if (image.Exists()) gfx.DrawImage(image, new Rectangle(3, 4, Width - 6, Height - 6));
			if (!image.Exists()) gfx.DrawImage(Properties.Resources.aero_glass_close_LARGE, new Rectangle(3, 4, Width - 6, Height - 6));
		}
	}
}
