using System.NET.CSharp.General;

namespace System.NET.CSharp.FileSystem
{
	public class File
	{
		private string filePath;

		public File(string filePath)
		{
			this.filePath = filePath;
		}

		public void Write(string line)
		{
			IO.File.WriteAllText(filePath, line);
		}
		public void WriteLine(string line)
		{
			IO.File.WriteAllText(filePath, line + "\n");
		}

		public string ReadLines()
		{
			return IO.File.ReadAllText(filePath);
		}
		public int ReadNumbers()
		{
			return IO.File.ReadAllText(filePath).ToInt();
		}

		public void Delete()
		{
			IO.File.Delete(filePath);
		}
	}
}
