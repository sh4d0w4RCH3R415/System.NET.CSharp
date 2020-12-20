using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace System.NET.CSharp.Windows
{
	public static class user32
	{
		[DllImport(nameof(user32))]
		private static extern bool ReleaseCapture();

		[DllImport(nameof(user32))]
		private static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);

		public static void AllowFormDrag(Form window, Control dragControl)
		{
			dragControl.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 2, 0);
			};
		}
		public static void AllowFormResize(Form window, Control topleft, Control top, Control topright, Control left, Control right, Control bottomleft, Control bottom, Control bottomright)
		{
			topleft.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 10, 0);
			};
			top.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			};
			topright.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 12, 0);
			};
			left.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 13, 0);
			};
			right.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 14, 0);
			};
			bottomleft.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 15, 0);
			};
			bottom.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 16, 0);
			};
			bottomright.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 17, 0);
			};
		}
		public static void AllowFormResizeVertical(Form window, Control top, Control bottom)
		{
			top.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			};
			bottom.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 16, 0);
			};
		}
		public static void AllowFormResizeHorizontal(Form window, Control left, Control right)
		{
			left.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 13, 0);
			};
			right.MouseDown += delegate (object sender, MouseEventArgs e)
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 14, 0);
			};
		}

		public static void AllowFormDrag(Form window, Rectangle dragRect, MouseEventArgs e)
		{
			var pos = e.Location;

			if (dragRect.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 2, 0);
			}
		}
		public static void AllowFormResize(Form window, Rectangle topleft, Rectangle top, Rectangle topright, Rectangle left1, Rectangle left2, Rectangle right1, Rectangle right2, Rectangle bottomleft, Rectangle bottom, Rectangle bottomright, MouseEventArgs e)
		{
			var pos = e.Location;

			if (topleft.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 13, 0);
			}
			else if (top.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 12, 0);
			}
			else if (topright.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 14, 0);
			}
			else if (left1.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 10, 0);
			}
			else if (left2.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 10, 0);
			}
			else if (right1.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			}
			else if (right2.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			}
			else if (bottomleft.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 16, 0);
			}
			else if (bottom.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 15, 0);
			}
			else if (bottomright.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 17, 0);
			}
		}
		public static void AllowFormResizeVertical(Form window, Rectangle top, Rectangle bottom, MouseEventArgs e)
		{
			var pos = e.Location;

			if (top.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 12, 0);
			}
			else if (bottom.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 15, 0);
			}
		}
		public static void AllowFormResizeHorizontal(Form window, Rectangle left1, Rectangle left2, Rectangle right1, Rectangle right2, MouseEventArgs e)
		{
			var pos = e.Location;

			if (left1.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 10, 0);
			}
			else if (left2.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 10, 0);
			}
			else if (right1.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			}
			else if (right2.Contains(pos))
			{
				ReleaseCapture();
				SendMessage(window.Handle, 161, 11, 0);
			}
		}

		private static FormWindowState prevState;

		public static void AddFormAnimation(Form window, Control closeControl)
		{
			window.Shown += delegate (object sender, EventArgs e)
			{
				window.Opacity = 0;
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity += .025d;
					if (window.Opacity >= 1)
					{
						t.Enabled = false;
						window.Opacity = 1;
					}
				};
				t.Start();
			};

			closeControl.Click += delegate (object sender, EventArgs e)
			{
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity -= .025d;
					if (window.Opacity <= 0)
					{
						t.Enabled = false;
						window.Close();
					}
				};
				t.Start();
			};
		}
		public static void AddFormAnimation(Form window, Control closeControl, Control minimizeControl)
		{
			window.Shown += delegate (object sender, EventArgs e)
			{
				window.Opacity = 0;
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity += .025d;
					if (window.Opacity >= 1)
					{
						t.Enabled = false;
						window.Opacity = 1;
					}
				};
				t.Start();
			};
			window.Activated += delegate (object sender, EventArgs e)
			{
				if (window.WindowState == FormWindowState.Minimized) window.Opacity = 0;

				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity += .025d;
					if (window.Opacity >= 1)
					{
						t.Enabled = false;
						window.Opacity = 1;
					}
				};
				t.Start();
			};

			closeControl.Click += delegate (object sender, EventArgs e)
			{
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity -= .025d;
					if (window.Opacity <= 0)
					{
						t.Enabled = false;
						window.Close();
					}
				};
				t.Start();
			};
			minimizeControl.Click += delegate (object sender, EventArgs e)
			{
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity -= .025d;
					if (window.Opacity <= 0)
					{
						t.Enabled = false;
						window.WindowState = FormWindowState.Minimized;
						window.Opacity = 0;
					}
				};
				t.Start();
			};
		}
		public static void AddFormAnimation(Form window, Control closeControl, Control minimizeControl, Control maximizeControl)
		{
			window.Shown += delegate (object sender, EventArgs e)
			{
				window.Opacity = 0;
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity += .025d;
					if (window.Opacity >= 1)
					{
						t.Enabled = false;
						window.Opacity = 1;
					}
				};
				t.Start();
			};
			window.Activated += delegate (object sender, EventArgs e)
			{
				if (window.WindowState == FormWindowState.Minimized) window.Opacity = 0;

				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity += .025d;
					if (window.Opacity >= 1)
					{
						t.Enabled = false;
						window.Opacity = 1;
					}
				};
				t.Start();
			};

			closeControl.Click += delegate (object sender, EventArgs e)
			{
				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity -= .025d;
					if (window.Opacity <= 0)
					{
						t.Enabled = false;
						window.Close();
					}
				};
				t.Start();
			};
			minimizeControl.Click += delegate (object sender, EventArgs e)
			{
				prevState = window.WindowState;

				Timer t = new Timer { Interval = 20 };
				t.Tick += delegate (object sender_, EventArgs e_)
				{
					window.Opacity -= .025d;
					if (window.Opacity <= 0)
					{
						t.Enabled = false;
						window.WindowState = FormWindowState.Minimized;
						window.Opacity = 0;
					}
				};
				t.Start();
			};
			maximizeControl.Click += delegate (object sender, EventArgs e)
			{
				if (window.WindowState == FormWindowState.Maximized)
				{
					prevState = FormWindowState.Maximized;
					Timer t = new Timer { Interval = 20 };
					t.Tick += delegate (object sender_, EventArgs e_)
					{
						window.Opacity -= .025d;
						if (window.Opacity <= 0)
						{
							t.Enabled = false;
							window.WindowState = FormWindowState.Normal;
							window.Opacity = 0;

							Timer t_ = new Timer { Interval = 20 };
							t_.Tick += delegate (object sender__, EventArgs e__)
							{
								window.Opacity += .025d;
								if (window.Opacity >= 1)
								{
									t_.Enabled = false;
									window.Opacity = 1;
								}
							};
							t_.Start();
						}
					};
					t.Start();
				}
				else if (window.WindowState == FormWindowState.Normal)
				{
					prevState = FormWindowState.Normal;
					Timer t = new Timer { Interval = 20 };
					t.Tick += delegate (object sender_, EventArgs e_)
					{
						window.Opacity -= .025d;
						if (window.Opacity <= 0)
						{
							t.Enabled = false;
							window.WindowState = FormWindowState.Maximized;
							window.Opacity = 0;

							Timer t_ = new Timer { Interval = 20 };
							t_.Tick += delegate (object sender__, EventArgs e__)
							{
								window.Opacity += .025d;
								if (window.Opacity >= 1)
								{
									t_.Enabled = false;
									window.Opacity = 1;
								}
							};
							t_.Start();
						}
					};
					t.Start();
				}
			};
		}

		public static void DisableFocus(Control focusedControl)
		{
			Label focusRemover = new Label();
			focusedControl.Parent.Controls.Add(focusRemover);
			focusedControl.GotFocus += delegate (object sender, EventArgs e)
			{
				focusRemover.Focus();
			};
		}
	}
}
