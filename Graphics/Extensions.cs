using System.Drawing;

namespace System.NET.CSharp.Graphics
{
	public static class Extensions
	{
		public static SolidBrush ToBrush(this Color color)
		{
			return new SolidBrush(color);
		}
		public static Color ToColor(this SolidBrush solidBrush)
		{
			return solidBrush.Color;
		}
		public static Color ToColor(this Pen pen)
		{
			return pen.Color;
		}
		public static float GetWidth(this Pen pen)
		{
			return pen.Width;
		}
		public static Color Darken(this Color color, int rgbAmount)
		{
			return Color.FromArgb(
				color.R - rgbAmount >= 0 ? color.R - rgbAmount : color.R,
				color.G - rgbAmount >= 0 ? color.G - rgbAmount : color.G,
				color.B - rgbAmount >= 0 ? color.B - rgbAmount : color.B
				);
		}
		public static Color Brighten(this Color color, int rgbAmount)
		{
			return Color.FromArgb(
				color.R + rgbAmount <= 255 ? color.R + rgbAmount : color.R,
				color.G + rgbAmount <= 255 ? color.G + rgbAmount : color.G,
				color.B + rgbAmount <= 255 ? color.B + rgbAmount : color.B
				);
		}
	}
}
