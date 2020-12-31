
namespace System.NET.CSharp.WinForms
{
	partial class LoginForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.showPassword = new System.Windows.Forms.CheckBox();
			this.register = new System.Windows.Forms.Button();
			this.login = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 16F);
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// username
			// 
			this.username.Font = new System.Drawing.Font("Calibri", 16F);
			this.username.Location = new System.Drawing.Point(130, 14);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(269, 34);
			this.username.TabIndex = 1;
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Calibri", 16F);
			this.password.Location = new System.Drawing.Point(130, 54);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(269, 34);
			this.password.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 16F);
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:";
			// 
			// showPassword
			// 
			this.showPassword.AutoSize = true;
			this.showPassword.Font = new System.Drawing.Font("Calibri", 14F);
			this.showPassword.Location = new System.Drawing.Point(247, 94);
			this.showPassword.Name = "showPassword";
			this.showPassword.Size = new System.Drawing.Size(152, 27);
			this.showPassword.TabIndex = 4;
			this.showPassword.Text = "Show Password";
			this.showPassword.UseVisualStyleBackColor = true;
			// 
			// register
			// 
			this.register.Font = new System.Drawing.Font("Calibri", 16F);
			this.register.Location = new System.Drawing.Point(247, 127);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(152, 41);
			this.register.TabIndex = 5;
			this.register.Text = "Register";
			this.register.UseVisualStyleBackColor = true;
			this.register.Click += new System.EventHandler(this.register_Click);
			// 
			// login
			// 
			this.login.Font = new System.Drawing.Font("Calibri", 16F);
			this.login.Location = new System.Drawing.Point(89, 127);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(152, 41);
			this.login.TabIndex = 6;
			this.login.Text = "Login";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.login_Click);
			// 
			// exit
			// 
			this.exit.AutoSize = true;
			this.exit.Font = new System.Drawing.Font("Calibri", 14F);
			this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
			this.exit.Location = new System.Drawing.Point(27, 137);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(37, 23);
			this.exit.TabIndex = 7;
			this.exit.Text = "Exit";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
			this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 180);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.login);
			this.Controls.Add(this.register);
			this.Controls.Add(this.showPassword);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox showPassword;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Label exit;
		public System.Windows.Forms.TextBox username;
		public System.Windows.Forms.TextBox password;
	}
}