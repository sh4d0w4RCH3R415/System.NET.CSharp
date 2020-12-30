using System.Windows.Forms;

namespace System.NET.CSharp.WinForms
{
	public static class Extensions
	{
		#region Readable Exceptions
		public static DialogResult ToMessage(this Exception exception, string Title)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static DialogResult ToMessage(this Exception exception, MessageBoxButtons buttons)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", "Error Found", buttons, MessageBoxIcon.Error);
		}
		public static DialogResult ToMessage(this Exception exception, MessageBoxIcon icon)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", "Error Found", MessageBoxButtons.OK, icon);
		}
		public static DialogResult ToMessage(this Exception exception, string Title, MessageBoxButtons buttons)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", Title, buttons, MessageBoxIcon.Error);
		}
		public static DialogResult ToMessage(this Exception exception, string Title, MessageBoxIcon icon)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", Title, MessageBoxButtons.OK, icon);
		}
		public static DialogResult ToMessage(this Exception exception, string Title, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			return MessageBox.Show($"Error Detected:\n\n{exception.Message}", Title, buttons, icon);
		}
		#endregion
	}
}
