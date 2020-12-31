using System;
using System.Drawing;
using System.NET.CSharp.General;
using System.NET.CSharp.Transitions;
using System.NET.CSharp.Windows;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tester
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			int left = 1;
			int right = 1;
			int bottom = 1;
			int top = 1;
			gdi32.DropShadow.ApplyShadows(this, left, right, bottom, top);

			System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
			Timer t = new Timer { Interval = 1 };
			s.Start();
			t.Tick += (sender, e) =>
			{
				label1.Text = string.Format("Testing Form - {0:D2}:{1:D2}:{2:D2}.{3:D3}",
					s.Elapsed.Hours,
					s.Elapsed.Minutes,
					s.Elapsed.Seconds,
					s.Elapsed.Milliseconds);
			};
			t.Start();
		}

		[DllImport("user32")]
		private static extern bool ReleaseCapture();

		[DllImport("user32")]
		private static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(pictureBox2, "BackColor", Color.FromArgb(55, 57, 59), new TransitionType_Linear(100));
		}
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(pictureBox2, "BackColor", Color.FromArgb(45, 47, 49), new TransitionType_Linear(100));
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(pictureBox3, "BackColor", Color.FromArgb(55, 57, 59), new TransitionType_Linear(100));
		}
		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(pictureBox3, "BackColor", Color.FromArgb(45, 47, 49), new TransitionType_Linear(100));
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void DragForm(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 161, 2, 0);
		}
	}
}
