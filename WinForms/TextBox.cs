using System.ComponentModel;
using System.Drawing;
using System.NET.CSharp.Graphics;
using System.NET.CSharp.Transitions;
using System.Windows.Forms;

using Rectangle = System.Drawing.Rectangle;

namespace System.NET.CSharp.WinForms
{
	[ToolboxBitmap(typeof(System.Windows.Forms.TextBox))]
	public class TextBox : Control
	{
		private System.Windows.Forms.TextBox tb;
		private Color underlineNormal = Color.FromArgb(70, 0, 0, 0);
		private Color underlineFocused = Color.FromArgb(0, 117, 243);
		private Color underlineCurrent = Color.FromArgb(70, 0, 0, 0);

		public override string Text
		{
			get { return tb.Text; }
			set { tb.Text = value; Invalidate(); }
		}
		public override Color BackColor
		{
			get { return tb.BackColor; }
			set { tb.BackColor = value; Invalidate(); }
		}
		public override Color ForeColor
		{
			get { return tb.ForeColor; }
			set { tb.ForeColor = value; Invalidate(); }
		}

		public bool UsePasswordChar
		{
			get { return tb.UseSystemPasswordChar; }
			set { tb.UseSystemPasswordChar = value; Invalidate(); }
		}
		public int MaxChars
		{
			get { return tb.MaxLength; }
			set { tb.MaxLength = value; Invalidate(); }
		}
		public bool ReadOnly
		{
			get { return tb.ReadOnly; }
			set { tb.ReadOnly = value; Invalidate(); }
		}
		public CharacterCasing CharCasing
		{
			get { return tb.CharacterCasing; }
			set { tb.CharacterCasing = value; Invalidate(); }
		}
		public Color UnderlineNormal
		{
			get { return underlineNormal; }
			set { underlineNormal = value; underlineCurrent = value; Invalidate(); }
		}
		public Color UnderlineFocused
		{
			get { return underlineFocused; }
			set { underlineFocused = value; Invalidate(); }
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public Color UnderlineCurrent
		{
			get { return underlineCurrent; }
			private set { underlineCurrent = value; Invalidate(); }
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			Height = 35;
		}
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			base.OnResize(e);
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			Transition.run(this, "UnderlineCurrent", underlineFocused, new TransitionType_Linear(500));
			tb.Focus();
		}
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			Transition.run(this, "UnderlineCurrent", underlineNormal, new TransitionType_Linear(500));
		}

		public TextBox()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(254, 35);

			AddTextBox();
		}
		public void AddTextBox()
		{
			tb = new System.Windows.Forms.TextBox();
			tb.Location = new Point(7, 8);
			tb.Width = 240;
			tb.BorderStyle = BorderStyle.None;
			tb.Font = new Font("Roboto", 13f);
			tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tb.BackColor = SystemColors.Window;
			tb.ForeColor = SystemColors.WindowText;

			Controls.Add(tb);

			tb.Text = "";
			Text = "";

			tb.GotFocus += delegate (object sender, EventArgs e)
			{
				OnGotFocus(e);
			};
			tb.LostFocus += delegate (object sender, EventArgs e)
			{
				OnLostFocus(e);
			};
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var gfx = e.Graphics;

			Rectangle boxRect = new Rectangle(0, 0, Width, Height - 2);

			gfx.FillRectangle(BackColor.ToBrush(), boxRect);
			gfx.FillRectangle(underlineCurrent.ToBrush(), new Rectangle(0, Height - 2, Width, 2));
		}
	}
}
