using System.Drawing;

namespace System.NET.CSharp.Graphics
{
	public class IcoToPng
	{
		public static Image ConvertToImg(string file)
		{
			return Image.FromFile(file);
		}
		public static Bitmap ConvertToBmp(string file)
		{
			return (Bitmap)Image.FromFile(file);
		}
	}
}
