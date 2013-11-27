namespace Blogger_Manager
{
	partial class frmMain
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.lbInfo = new System.Windows.Forms.ListBox();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.lbBlogs = new System.Windows.Forms.ListBox();
			this.lbPosts = new System.Windows.Forms.ListBox();
			this.lbPages = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(12, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(116, 53);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lbInfo
			// 
			this.lbInfo.FormattingEnabled = true;
			this.lbInfo.HorizontalScrollbar = true;
			this.lbInfo.Location = new System.Drawing.Point(12, 417);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(415, 95);
			this.lbInfo.TabIndex = 1;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(134, 12);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(116, 53);
			this.btnLogOut.TabIndex = 2;
			this.btnLogOut.Text = "Logout";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// lbBlogs
			// 
			this.lbBlogs.FormattingEnabled = true;
			this.lbBlogs.HorizontalScrollbar = true;
			this.lbBlogs.Location = new System.Drawing.Point(12, 299);
			this.lbBlogs.Name = "lbBlogs";
			this.lbBlogs.Size = new System.Drawing.Size(415, 108);
			this.lbBlogs.TabIndex = 3;
			this.lbBlogs.Click += new System.EventHandler(this.lbBlogs_Click);
			// 
			// lbPosts
			// 
			this.lbPosts.FormattingEnabled = true;
			this.lbPosts.Location = new System.Drawing.Point(12, 71);
			this.lbPosts.Name = "lbPosts";
			this.lbPosts.Size = new System.Drawing.Size(415, 108);
			this.lbPosts.TabIndex = 4;
			// 
			// lbPages
			// 
			this.lbPages.FormattingEnabled = true;
			this.lbPages.Location = new System.Drawing.Point(12, 185);
			this.lbPages.Name = "lbPages";
			this.lbPages.Size = new System.Drawing.Size(415, 108);
			this.lbPages.TabIndex = 5;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 524);
			this.Controls.Add(this.lbPages);
			this.Controls.Add(this.lbPosts);
			this.Controls.Add(this.lbBlogs);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.lbInfo);
			this.Controls.Add(this.btnLogin);
			this.Name = "frmMain";
			this.Text = "Blogger Manager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ListBox lbInfo;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.ListBox lbBlogs;
		private System.Windows.Forms.ListBox lbPosts;
		private System.Windows.Forms.ListBox lbPages;
	}
}

