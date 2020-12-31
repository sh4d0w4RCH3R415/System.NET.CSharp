using System.Drawing;
using System.NET.CSharp.General;
using System.NET.CSharp.Transitions;
using System.NET.CSharp.Windows;
using System.Windows.Forms;

namespace System.NET.CSharp.WinForms
{
	public partial class LoginForm : Form
	{
		public LoginForm(Form mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;

			mainForm.Visible = false;

			int left = 1;
			int right = 1;
			int bottom = 1;
			int top = 1;
			gdi32.DropShadow.ApplyShadows(this, left, right, bottom, top);
		}

		private ITransitionType linear = new TransitionType_Linear(100);
		private const string forecolor = "ForeColor";
		private Color blue = ColorMixer.NiceBlue;
		private Color red = Color.FromArgb(255, 65, 95);

		private bool exitClicked;
		private Form mainForm;

		private void exit_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(exit, forecolor, blue, linear);
		}
		private void exit_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(exit, forecolor, red, linear);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			exitClicked = true;
		}
		private void login_Click(object sender, EventArgs e)
		{
			if (!exitClicked)
			{
				if (username.Text == LoginHelper.Default.Username)
				{
					if (password.Text == LoginHelper.Default.Password)
					{
						mainForm.Visible = true;
						Close();
					}
					else if (password.Text != LoginHelper.Default.Password)
					{
						new Exception("Password is incorrect. Please try again.").ToMessage("Incorrect Password", MessageBoxIcon.Error);
					}
				}
				else if (username.Text != LoginHelper.Default.Username)
				{
					new Exception("Username and Password are incorrect. Please try again.").ToMessage("Incorrect Username and Password", MessageBoxIcon.Error);
				}
			}
		}
		private void register_Click(object sender, EventArgs e)
		{
			if (!exitClicked)
			{
				LoginHelper.Default.Username = username.Text;
				LoginHelper.Default.Password = password.Text;
				LoginHelper.Default.Save();
			}
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (exitClicked)
			{
				Close();
				mainForm.Close();
			}
		}
	}
}
