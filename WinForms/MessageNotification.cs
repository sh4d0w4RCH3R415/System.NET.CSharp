using System.Drawing;
using System.NET.CSharp.General;
using System.NET.CSharp.Graphics;
using System.NET.CSharp.Transitions;
using System.NET.CSharp.Windows;
using System.Windows.Forms;

namespace System.NET.CSharp.WinForms
{
	public partial class MessageNotification : Form
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			user32.AddFormAnimation(this, pictureBox2, pictureBox3);
			user32.AddFormAnimation(this, choice1);
			user32.AddFormAnimation(this, choice2);
			user32.AddFormAnimation(this, choice3);
			user32.AllowFormDrag(this, panel1);
			user32.AllowFormDrag(this, titlestuffs);
			user32.AllowFormDrag(this, iconstuffs);
		}

		public MessageNotification(string message)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = "Message";
			iconstuffs.Image = SystemIcons.Information.ToBitmap();
			choice1.Visible = choice2.Visible = false;
			choice3.Text = "OK";

			ShowDialog();
		}
		public MessageNotification(string message, string title)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = title;
			iconstuffs.Image = SystemIcons.Information.ToBitmap();
			choice1.Visible = choice2.Visible = false;
			choice3.Text = "OK";

			ShowDialog();
		}
		public MessageNotification(string message, MessageBoxButtons buttons)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = "Message";
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					choice1.Visible = false;
					choice2.Visible = false;
					choice3.Text = "OK";
					break;
				case MessageBoxButtons.OKCancel:
					choice1.Visible = false;
					choice2.Text = "OK";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.RetryCancel:
					choice1.Visible = false;
					choice2.Text = "Retry";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.AbortRetryIgnore:
					choice1.Text = "Abort";
					choice2.Text = "Retry";
					choice3.Text = "Ignore";
					break;
				case MessageBoxButtons.YesNo:
					choice1.Visible = false;
					choice2.Text = "Yes";
					choice3.Text = "No";
					break;
				case MessageBoxButtons.YesNoCancel:
					choice1.Text = "Yes";
					choice2.Text = "No";
					choice3.Text = "Cancel";
					break;
			}

			ShowDialog();
		}
		public MessageNotification(string message, MessageBoxIcon icon)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = "Message";
			switch (icon)
			{
				case MessageBoxIcon.Error:
					iconstuffs.Image = SystemIcons.Error.ToBitmap();
					break;
				case MessageBoxIcon.Information:
					iconstuffs.Image = SystemIcons.Information.ToBitmap();
					break;
				case MessageBoxIcon.Warning:
					iconstuffs.Image = SystemIcons.Warning.ToBitmap();
					break;
				case MessageBoxIcon.Question:
					iconstuffs.Image = SystemIcons.Question.ToBitmap();
					break;
				default:
					iconstuffs.Image = SystemIcons.Application.ToBitmap();
					break;
			}
			choice1.Visible = choice2.Visible = false;
			choice3.Text = "OK";

			ShowDialog();
		}
		public MessageNotification(string message, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					choice1.Visible = false;
					choice2.Visible = false;
					choice3.Text = "OK";
					break;
				case MessageBoxButtons.OKCancel:
					choice1.Visible = false;
					choice2.Text = "OK";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.RetryCancel:
					choice1.Visible = false;
					choice2.Text = "Retry";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.AbortRetryIgnore:
					choice1.Text = "Abort";
					choice2.Text = "Retry";
					choice3.Text = "Ignore";
					break;
				case MessageBoxButtons.YesNo:
					choice1.Visible = false;
					choice2.Text = "Yes";
					choice3.Text = "No";
					break;
				case MessageBoxButtons.YesNoCancel:
					choice1.Text = "Yes";
					choice2.Text = "No";
					choice3.Text = "Cancel";
					break;
			}
			switch (icon)
			{
				case MessageBoxIcon.Error:
					iconstuffs.Image = SystemIcons.Error.ToBitmap();
					break;
				case MessageBoxIcon.Information:
					iconstuffs.Image = SystemIcons.Information.ToBitmap();
					break;
				case MessageBoxIcon.Warning:
					iconstuffs.Image = SystemIcons.Warning.ToBitmap();
					break;
				case MessageBoxIcon.Question:
					iconstuffs.Image = SystemIcons.Question.ToBitmap();
					break;
				default:
					iconstuffs.Image = SystemIcons.Application.ToBitmap();
					break;
			}

			ShowDialog();
		}
		public MessageNotification(string message, string title, MessageBoxButtons buttons)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = title;
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					choice1.Visible = false;
					choice2.Visible = false;
					choice3.Text = "OK";
					break;
				case MessageBoxButtons.OKCancel:
					choice1.Visible = false;
					choice2.Text = "OK";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.RetryCancel:
					choice1.Visible = false;
					choice2.Text = "Retry";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.AbortRetryIgnore:
					choice1.Text = "Abort";
					choice2.Text = "Retry";
					choice3.Text = "Ignore";
					break;
				case MessageBoxButtons.YesNo:
					choice1.Visible = false;
					choice2.Text = "Yes";
					choice3.Text = "No";
					break;
				case MessageBoxButtons.YesNoCancel:
					choice1.Text = "Yes";
					choice2.Text = "No";
					choice3.Text = "Cancel";
					break;
			}

			ShowDialog();
		}
		public MessageNotification(string message, string title, MessageBoxIcon icon)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = title;
			switch (icon)
			{
				case MessageBoxIcon.Error:
					iconstuffs.Image = SystemIcons.Error.ToBitmap();
					break;
				case MessageBoxIcon.Information:
					iconstuffs.Image = SystemIcons.Information.ToBitmap();
					break;
				case MessageBoxIcon.Warning:
					iconstuffs.Image = SystemIcons.Warning.ToBitmap();
					break;
				case MessageBoxIcon.Question:
					iconstuffs.Image = SystemIcons.Question.ToBitmap();
					break;
				default:
					iconstuffs.Image = SystemIcons.Application.ToBitmap();
					break;
			}
			choice1.Visible = choice2.Visible = false;
			choice3.Text = "OK";

			ShowDialog();
		}
		public MessageNotification(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			InitializeComponent();

			messagestuffs.Text = message;
			titlestuffs.Text = title;
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					choice1.Visible = false;
					choice2.Visible = false;
					choice3.Text = "OK";
					break;
				case MessageBoxButtons.OKCancel:
					choice1.Visible = false;
					choice2.Text = "OK";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.RetryCancel:
					choice1.Visible = false;
					choice2.Text = "Retry";
					choice3.Text = "Cancel";
					break;
				case MessageBoxButtons.AbortRetryIgnore:
					choice1.Text = "Abort";
					choice2.Text = "Retry";
					choice3.Text = "Ignore";
					break;
				case MessageBoxButtons.YesNo:
					choice1.Visible = false;
					choice2.Text = "Yes";
					choice3.Text = "No";
					break;
				case MessageBoxButtons.YesNoCancel:
					choice1.Text = "Yes";
					choice2.Text = "No";
					choice3.Text = "Cancel";
					break;
			}
			switch (icon)
			{
				case MessageBoxIcon.Error:
					iconstuffs.Image = SystemIcons.Error.ToBitmap();
					break;
				case MessageBoxIcon.Information:
					iconstuffs.Image = SystemIcons.Information.ToBitmap();
					break;
				case MessageBoxIcon.Warning:
					iconstuffs.Image = SystemIcons.Warning.ToBitmap();
					break;
				case MessageBoxIcon.Question:
					iconstuffs.Image = SystemIcons.Question.ToBitmap();
					break;
				default:
					iconstuffs.Image = SystemIcons.Application.ToBitmap();
					break;
			}

			ShowDialog();
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(pictureBox2, "BackColor", pictureBox2.BackColor.Brighten(20), new TransitionType_Linear(75));
		}
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(pictureBox2, "BackColor", pictureBox2.BackColor.Darken(20), new TransitionType_Linear(75));
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			Transition.run(pictureBox3, "BackColor", pictureBox3.BackColor.Brighten(20), new TransitionType_Linear(75));
		}
		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			Transition.run(pictureBox3, "BackColor", pictureBox3.BackColor.Darken(20), new TransitionType_Linear(75));
		}

		private void SendUserResult(object sender, EventArgs e)
		{
			var button = (Control)sender;

			if (button.Name.CheckString("choice1"))
			{
				if (button.Text.CheckString("Abort"))
				{
					DialogResult = DialogResult.Abort;
				}
				else if (button.Text.CheckString("Yes"))
				{
					DialogResult = DialogResult.Yes;
				}
			}
			else if (button.Name.CheckString("choice2"))
			{
				if (button.Text.CheckString("OK"))
				{
					DialogResult = DialogResult.OK;
				}
				else if (button.Text.CheckString("Retry"))
				{
					DialogResult = DialogResult.Retry;
				}
				else if (button.Text.CheckString("Yes"))
				{
					DialogResult = DialogResult.Yes;
				}
				else if (button.Text.CheckString("No"))
				{
					DialogResult = DialogResult.No;
				}
			}
			else if (button.Name.CheckString("choice3"))
			{
				if (button.Text.CheckString("Ignore"))
				{
					DialogResult = DialogResult.Ignore;
				}
				else if (button.Text.CheckString("Cancel"))
				{
					DialogResult = DialogResult.Cancel;
				}
				else if (button.Text.CheckString("OK"))
				{
					DialogResult = DialogResult.OK;
				}
			}
		}
	}
}
