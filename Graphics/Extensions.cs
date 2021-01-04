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

		public static int ToWin32(this Color c)
		{
			return ColorTranslator.ToWin32(c);
		}
		public static string ToHtml(this Color c)
		{
			return ColorTranslator.ToHtml(c);
		}
		
		public static Color ToRGB(this int win32)
		{
			return ColorTranslator.FromWin32(win32);
		}
		public static string ToHtml(this int win32)
		{
			return ColorTranslator.ToHtml(ColorTranslator.FromWin32(win32));
		}
		
		public static Color ToRGB(this string html)
		{
			return ColorTranslator.FromHtml(html);
		}
		public static int ToWin32(this string html)
		{
			return ColorTranslator.ToWin32(ColorTranslator.FromHtml(html));
		}

		public static Color ToColor(this int hexCode)
		{
			string hex = hexCode.ToString().Substring(2);
			return hex.ToRGB();
		}
	}
}
