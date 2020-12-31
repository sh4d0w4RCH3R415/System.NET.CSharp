using System.Windows.Forms;

namespace System.NET.CSharp.General
{
	public class Stopwatch
	{
		private string hours;
		private string minutes;
		private string seconds;
		private string milliseconds;

		private int hourLimit;
		private int minuteLimit;
		private int secondLimit;
		private int millisecondLimit;

		private Diagnostics.Stopwatch stopwatch;
		private Timer timer;

		public string Hours => hours;
		public string Minutes => minutes;
		public string Seconds => seconds;
		public string Milliseconds => milliseconds;

		public Stopwatch(int hourLimit, int minuteLimit, int secondLimit, int millisecondLimit)
		{
			stopwatch = new Diagnostics.Stopwatch();
			timer = new Timer { Interval = 1 };

			this.hourLimit = hourLimit;
			this.minuteLimit = minuteLimit;
			this.secondLimit = secondLimit;
			this.millisecondLimit = millisecondLimit;
		}

		public void Start()
		{
			stopwatch.Start();
			timer.Start();

			timer.Tick += (sender, e) =>
			{
				hours = string.Format("{0:D2}", stopwatch.Elapsed.Hours);
				minutes = string.Format("{0:D2}", stopwatch.Elapsed.Minutes);
				seconds = string.Format("{0:D2}", stopwatch.Elapsed.Seconds);
				milliseconds = string.Format("{0:D3}", stopwatch.Elapsed.Milliseconds);

				int h = stopwatch.Elapsed.Hours;
				int m = stopwatch.Elapsed.Minutes;
				int s = stopwatch.Elapsed.Seconds;
				int ms = stopwatch.Elapsed.Milliseconds;

				if (h == hourLimit && m == minuteLimit && s == secondLimit && ms == millisecondLimit)
				{
					MessageBox.Show("Time limit exceeded. Please reset the Stopwatch to continue.", "Time Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Application.DoEvents();
			};
		}
		public void Stop()
		{
			stopwatch.Stop();
			timer.Enabled = false;
		}
		public void Resume()
		{
			stopwatch.Start();
			timer.Start();
		}
		public void Reset()
		{
			Stop();
			stopwatch.Reset();
		}
	}
}
