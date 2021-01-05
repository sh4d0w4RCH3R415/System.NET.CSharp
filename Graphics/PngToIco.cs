using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.NET.CSharp.General;

namespace System.NET.CSharp.Graphics
{
	public class PngToIco
	{
		public static bool Convert(Stream inputStream, Stream outputStream, int size, bool keepAspectRatio = false)
		{
			Bitmap inputBit = (Bitmap)Image.FromStream(inputStream);
			if (inputBit.Exists())
			{
				int width, height;
				if (keepAspectRatio)
				{
					width = size;
					height = inputBit.Height / inputBit.Width * size;
				}
				else
				{
					width = height = size;
				}
				Bitmap newBit = new Bitmap(inputBit, new Size(width, height));
				if (newBit.Exists())
				{
					MemoryStream memData = new MemoryStream();
					newBit.Save(memData, ImageFormat.Png);

					BinaryWriter iconWriter = new BinaryWriter(outputStream);
					if (outputStream.Exists() && iconWriter.Exists())
					{
						iconWriter.Write(0.ToByte());
						iconWriter.Write(0.ToByte());

						iconWriter.Write(1.ToShort());
						iconWriter.Write(1.ToShort());

						iconWriter.Write(width.ToByte());
						iconWriter.Write(height.ToByte());

						iconWriter.Write(0.ToByte());
						iconWriter.Write(0.ToByte());
						iconWriter.Write(0.ToShort());

						iconWriter.Write(32.ToShort());

						iconWriter.Write(memData.Length.ToInt());
						iconWriter.Write(6 + 16);

						iconWriter.Write(memData.ToArray());

						iconWriter.Flush();

						return true;
					}
				}
				return false;
			}
			return false;
		}
		public static bool Convert(string inputImage, string outputIcon, int size, bool keepAspectRatio = false)
		{
			FileStream inputStream = new FileStream(inputImage, FileMode.Open);
			FileStream outputStream = new FileStream(outputIcon, FileMode.OpenOrCreate);

			bool result = Convert(inputStream, outputStream, size, keepAspectRatio);

			inputStream.Close();
			outputStream.Close();

			return result;
		}
	}
}
