
namespace System.NET.CSharp.WinForms
{
	partial class MessageNotification
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageNotification));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.titlestuffs = new System.NET.CSharp.WinForms.Label();
			this.iconstuffs = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.choice1 = new System.NET.CSharp.WinForms.Button();
			this.choice2 = new System.NET.CSharp.WinForms.Button();
			this.choice3 = new System.NET.CSharp.WinForms.Button();
			this.messagestuffs = new System.NET.CSharp.WinForms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconstuffs)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.titlestuffs);
			this.panel1.Controls.Add(this.iconstuffs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 37);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(349, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(30, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
			this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(383, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
			this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
			// 
			// titlestuffs
			// 
			this.titlestuffs.AutoSize = true;
			this.titlestuffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.titlestuffs.Font = new System.Drawing.Font("Roboto", 14F);
			this.titlestuffs.ForeColor = System.Drawing.SystemColors.Control;
			this.titlestuffs.Location = new System.Drawing.Point(33, 8);
			this.titlestuffs.Name = "titlestuffs";
			this.titlestuffs.Size = new System.Drawing.Size(192, 23);
			this.titlestuffs.TabIndex = 1;
			this.titlestuffs.Text = "Message Notification";
			this.titlestuffs.TextClarity = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// iconstuffs
			// 
			this.iconstuffs.Location = new System.Drawing.Point(3, 3);
			this.iconstuffs.Name = "iconstuffs";
			this.iconstuffs.Size = new System.Drawing.Size(30, 30);
			this.iconstuffs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconstuffs.TabIndex = 0;
			this.iconstuffs.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
			this.panel2.Controls.Add(this.choice1);
			this.panel2.Controls.Add(this.choice2);
			this.panel2.Controls.Add(this.choice3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 270);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(416, 41);
			this.panel2.TabIndex = 1;
			// 
			// choice1
			// 
			this.choice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.choice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
			this.choice1.Font = new System.Drawing.Font("Roboto", 14F);
			this.choice1.ForeColor = System.Drawing.Color.White;
			this.choice1.Location = new System.Drawing.Point(145, 8);
			this.choice1.Name = "choice1";
			this.choice1.Size = new System.Drawing.Size(84, 25);
			this.choice1.TabIndex = 4;
			this.choice1.Text = "choice1";
			this.choice1.TextClarity = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.choice1.Click += new System.EventHandler(this.SendUserResult);
			// 
			// choice2
			// 
			this.choice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.choice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
			this.choice2.Font = new System.Drawing.Font("Roboto", 14F);
			this.choice2.ForeColor = System.Drawing.Color.White;
			this.choice2.Location = new System.Drawing.Point(235, 8);
			this.choice2.Name = "choice2";
			this.choice2.Size = new System.Drawing.Size(84, 25);
			this.choice2.TabIndex = 3;
			this.choice2.Text = "choice2";
			this.choice2.TextClarity = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.choice2.Click += new System.EventHandler(this.SendUserResult);
			// 
			// choice3
			// 
			this.choice3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.choice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
			this.choice3.Font = new System.Drawing.Font("Roboto", 14F);
			this.choice3.ForeColor = System.Drawing.Color.White;
			this.choice3.Location = new System.Drawing.Point(325, 8);
			this.choice3.Name = "choice3";
			this.choice3.Size = new System.Drawing.Size(84, 25);
			this.choice3.TabIndex = 2;
			this.choice3.Text = "choice3";
			this.choice3.TextClarity = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.choice3.Click += new System.EventHandler(this.SendUserResult);
			// 
			// messagestuffs
			// 
			this.messagestuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messagestuffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.messagestuffs.Font = new System.Drawing.Font("Roboto", 14F);
			this.messagestuffs.ForeColor = System.Drawing.SystemColors.Control;
			this.messagestuffs.Location = new System.Drawing.Point(0, 37);
			this.messagestuffs.Name = "messagestuffs";
			this.messagestuffs.Size = new System.Drawing.Size(416, 233);
			this.messagestuffs.TabIndex = 2;
			this.messagestuffs.Text = "Message";
			this.messagestuffs.TextClarity = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// MessageNotification
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(416, 311);
			this.Controls.Add(this.messagestuffs);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Roboto", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MessageNotification";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message Notification";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconstuffs)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox iconstuffs;
		private Label titlestuffs;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel2;
		private Button choice1;
		private Button choice2;
		private Button choice3;
		private Label messagestuffs;
	}
}