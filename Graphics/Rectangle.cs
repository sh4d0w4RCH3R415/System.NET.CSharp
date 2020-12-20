using System.Drawing;

using gfx = System.Drawing.Graphics;
using rect = System.Drawing.Rectangle;

namespace System.NET.CSharp.Graphics
{
	public class Rectangle
	{
		private int width, height;
		private int xpos, ypos;
		private Point location;
		private Size size;

		public int Width
		{
			get { return width; }
			set { width = value; }
		}
		public int Height
		{
			get { return height; }
			set { height = value; }
		}
		public Point Location
		{
			get { return new Point(xpos, ypos); }
			set { location = value; xpos = value.X; ypos = value.Y; }
		}
		public Size Size
		{
			get { return new Size(width, height); }
			set { size = value; width = value.Width; height = value.Height; }
		}

		public Rectangle(int xpos, int ypos, int width, int height)
		{
			this.width = width;
			this.height = height;
			this.xpos = xpos;
			this.ypos = ypos;
		}

		public static rect ToRect(Rectangle rect)
		{
			return new rect(rect.Location.X, rect.Location.Y, rect.Size.Width, rect.Size.Height);
		}
		public rect ToRect()
		{
			return new rect(xpos, ypos, width, height);
		}

		public void Draw(gfx graphics, Pen pen)
		{
			graphics.FillRectangle(pen.Color.ToBrush(), xpos, ypos, width, (int)pen.Width);
			graphics.FillRectangle(pen.Color.ToBrush(), xpos, ypos, (int)pen.Width, height);
			graphics.FillRectangle(pen.Color.ToBrush(), xpos, height - (int)pen.Width, width, (int)pen.Width);
			graphics.FillRectangle(pen.Color.ToBrush(), width - (int)pen.Width, ypos, (int)pen.Width, height);
		}
		public void Draw(gfx graphics, Color color)
		{
			graphics.FillRectangle(color.ToBrush(), xpos, ypos, width, 1);
			graphics.FillRectangle(color.ToBrush(), xpos, ypos, 1, height);
			graphics.FillRectangle(color.ToBrush(), xpos, height - 1, width, 1);
			graphics.FillRectangle(color.ToBrush(), width - 1, ypos, 1, height);
		}
		public void Draw(gfx graphics, Color color, int penWidth)
		{
			graphics.FillRectangle(color.ToBrush(), xpos, ypos, width, penWidth);
			graphics.FillRectangle(color.ToBrush(), xpos, ypos, penWidth, height);
			graphics.FillRectangle(color.ToBrush(), xpos, height - penWidth, width, penWidth);
			graphics.FillRectangle(color.ToBrush(), width - penWidth, ypos, penWidth, height);
		}
		public void Draw(gfx graphics, Brush brush)
		{
			graphics.FillRectangle(brush, xpos, ypos, width, 1);
			graphics.FillRectangle(brush, xpos, ypos, 1, height);
			graphics.FillRectangle(brush, xpos, height - 1, width, 1);
			graphics.FillRectangle(brush, width - 1, ypos, 1, height);
		}
		public void Draw(gfx graphics, Brush brush, int penWidth)
		{
			graphics.FillRectangle(brush, xpos, ypos, width, penWidth);
			graphics.FillRectangle(brush, xpos, ypos, penWidth, height);
			graphics.FillRectangle(brush, xpos, height - penWidth, width, penWidth);
			graphics.FillRectangle(brush, width - penWidth, ypos, penWidth, height);
		}

		public void Fill(gfx graphics, Color color)
		{
			graphics.FillRectangle(color.ToBrush(), xpos, ypos, width, height);
		}
		public void Fill(gfx graphics, Brush brush)
		{
			graphics.FillRectangle(brush, xpos, ypos, width, height);
		}
	}
}
