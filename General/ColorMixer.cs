using System.Drawing;

namespace System.NET.CSharp.General
{
	public static class ColorMixer
	{
		/// <summary>
		/// 255, 75, 75
		/// </summary>
		public static Color OrangePink
		{
			get { return Color.FromArgb(255, 75, 75); }
		}

		/// <summary>
		/// 0, 117, 243
		/// </summary>
		public static Color NiceBlue
		{
			get { return Color.FromArgb(0, 117, 243); }
		}

		/// <summary>
		/// 243, 180, 65
		/// </summary>
		public static Color CoolGold
		{
			get { return Color.FromArgb(243, 180, 65); }
		}

		/// <summary>
		/// 243, 45, 65
		/// </summary>
		public static Color CoolRed
		{
			get { return Color.FromArgb(243, 45, 65); }
		}

		/// <summary>
		/// 45, 47, 49
		/// </summary>
		public static Color CoolBlack
		{
			get { return Color.FromArgb(45, 47, 49); }
		}

		/// <summary>
		/// 95, 97, 99
		/// </summary>
		public static Color CoolGray
		{
			get { return Color.FromArgb(95, 97, 99); }
		}

		/// <summary>
		/// 75, 77, 79
		/// </summary>
		public static Color NiceGray
		{
			get { return Color.FromArgb(75, 77, 79); }
		}

		/// <summary>
		/// 30, 30, 30
		/// </summary>
		public static Color NiceBlack
		{
			get { return Color.FromArgb(30, 30, 30); }
		}

		public static Color BlendColors(Color color1, Color color2)
		{
			return Color.FromArgb(
				(color1.R + color2.R) / 2,
				(color1.G + color2.G) / 2,
				(color1.B + color2.B) / 2
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R) / 3,
				(color1.G + color2.G + color3.G) / 3,
				(color1.B + color2.B + color3.B) / 3
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R) / 4,
				(color1.G + color2.G + color3.G + color4.G) / 4,
				(color1.B + color2.B + color3.B + color4.B) / 4
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R) / 5,
				(color1.G + color2.G + color3.G + color4.G + color5.G) / 5,
				(color1.B + color2.B + color3.B + color4.B + color5.B) / 5
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5, Color color6)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R + color6.R) / 6,
				(color1.G + color2.G + color3.G + color4.G + color5.G + color6.G) / 6,
				(color1.B + color2.B + color3.B + color4.B + color5.B + color6.B) / 6
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5, Color color6, Color color7)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R + color6.R + color7.R) / 7,
				(color1.G + color2.G + color3.G + color4.G + color5.G + color6.G + color7.G) / 7,
				(color1.B + color2.B + color3.B + color4.B + color5.B + color6.B + color7.B) / 7
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5, Color color6, Color color7, Color color8)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R + color6.R + color7.R + color8.R) / 8,
				(color1.G + color2.G + color3.G + color4.G + color5.G + color6.G + color7.G + color8.G) / 8,
				(color1.B + color2.B + color3.B + color4.B + color5.B + color6.B + color7.B + color8.B) / 8
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5, Color color6, Color color7, Color color8, Color color9)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R + color6.R + color7.R + color8.R + color9.R) / 9,
				(color1.G + color2.G + color3.G + color4.G + color5.G + color6.G + color7.G + color8.G + color9.G) / 9,
				(color1.B + color2.B + color3.B + color4.B + color5.B + color6.B + color7.B + color8.B + color9.B) / 9
				);
		}
		public static Color BlendColors(Color color1, Color color2, Color color3, Color color4, Color color5, Color color6, Color color7, Color color8, Color color9, Color color10)
		{
			return Color.FromArgb(
				(color1.R + color2.R + color3.R + color4.R + color5.R + color6.R + color7.R + color8.R + color9.R + color10.R) / 10,
				(color1.G + color2.G + color3.G + color4.G + color5.G + color6.G + color7.G + color8.G + color9.G + color10.G) / 10,
				(color1.B + color2.B + color3.B + color4.B + color5.B + color6.B + color7.B + color8.B + color9.B + color10.B) / 10
				);
		}
	}
}
