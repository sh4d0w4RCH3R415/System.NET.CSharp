using System.IO;

namespace System.NET.CSharp.Windows
{
	public struct AudioFile
	{
		private string path;

		public string Path => path;

		public AudioFile(string path)
		{
			this.path = path;
		}

		public void Play()
		{
			new Microsoft.VisualBasic.Devices.Audio().Play(path);
		}
		public void Delete()
		{
			File.Delete(path);
		}
	}
}
