using System.Runtime.InteropServices;

namespace System.NET.CSharp.Windows
{
	public class Audio
	{
		private AudioFile audioFile;

		public AudioFile AudioFile => audioFile;

		[DllImport("winmm", EntryPoint = "mciSendStringA")]
		private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int handleCallBack);

		private void record(string lpstrCommand)
		{
			record(lpstrCommand, "", 0, 0);
		}

		public Audio(string resultFile)
		{
			audioFile = new AudioFile(resultFile);
		}
		
		public void RecordMicrophone()
		{
			record("open new Type waveaudio Alias recsound");
			record("record recsound");
		}
		public void StopRecording()
		{
			record($"save recsound {audioFile.Path}");
			record("close recsound");
		}
		public void CancelRecording()
		{
			try
			{
				StopRecording();
				audioFile.Delete();
			} catch {}
		}
		public void Delete()
		{
			CancelRecording();
			audioFile = new AudioFile();
		}
	}
}
