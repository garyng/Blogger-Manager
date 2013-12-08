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
			this.btnViewBlogInfo = new System.Windows.Forms.Button();
			this.btnPostInfo = new System.Windows.Forms.Button();
			this.txtHTML = new System.Windows.Forms.TextBox();
			this.lbComments = new System.Windows.Forms.ListBox();
			this.lbCommentsByPost = new System.Windows.Forms.ListBox();
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
			this.lbBlogs.Size = new System.Drawing.Size(334, 108);
			this.lbBlogs.TabIndex = 3;
			// 
			// lbPosts
			// 
			this.lbPosts.FormattingEnabled = true;
			this.lbPosts.Location = new System.Drawing.Point(12, 71);
			this.lbPosts.Name = "lbPosts";
			this.lbPosts.Size = new System.Drawing.Size(334, 108);
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
			// btnViewBlogInfo
			// 
			this.btnViewBlogInfo.Location = new System.Drawing.Point(352, 299);
			this.btnViewBlogInfo.Name = "btnViewBlogInfo";
			this.btnViewBlogInfo.Size = new System.Drawing.Size(75, 108);
			this.btnViewBlogInfo.TabIndex = 6;
			this.btnViewBlogInfo.Text = "View Info";
			this.btnViewBlogInfo.UseVisualStyleBackColor = true;
			this.btnViewBlogInfo.Click += new System.EventHandler(this.btnViewBlogInfo_Click);
			// 
			// btnPostInfo
			// 
			this.btnPostInfo.Location = new System.Drawing.Point(352, 71);
			this.btnPostInfo.Name = "btnPostInfo";
			this.btnPostInfo.Size = new System.Drawing.Size(75, 108);
			this.btnPostInfo.TabIndex = 7;
			this.btnPostInfo.Text = "View Info";
			this.btnPostInfo.UseVisualStyleBackColor = true;
			this.btnPostInfo.Click += new System.EventHandler(this.btnPostInfo_Click);
			// 
			// txtHTML
			// 
			this.txtHTML.Location = new System.Drawing.Point(433, 71);
			this.txtHTML.Multiline = true;
			this.txtHTML.Name = "txtHTML";
			this.txtHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHTML.Size = new System.Drawing.Size(415, 108);
			this.txtHTML.TabIndex = 8;
			// 
			// lbComments
			// 
			this.lbComments.FormattingEnabled = true;
			this.lbComments.Location = new System.Drawing.Point(432, 299);
			this.lbComments.Name = "lbComments";
			this.lbComments.Size = new System.Drawing.Size(202, 108);
			this.lbComments.TabIndex = 9;
			// 
			// lbCommentsByPost
			// 
			this.lbCommentsByPost.FormattingEnabled = true;
			this.lbCommentsByPost.Location = new System.Drawing.Point(646, 299);
			this.lbCommentsByPost.Name = "lbCommentsByPost";
			this.lbCommentsByPost.Size = new System.Drawing.Size(202, 108);
			this.lbCommentsByPost.TabIndex = 10;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 521);
			this.Controls.Add(this.lbCommentsByPost);
			this.Controls.Add(this.lbComments);
			this.Controls.Add(this.txtHTML);
			this.Controls.Add(this.btnPostInfo);
			this.Controls.Add(this.btnViewBlogInfo);
			this.Controls.Add(this.lbPages);
			this.Controls.Add(this.lbPosts);
			this.Controls.Add(this.lbBlogs);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.lbInfo);
			this.Controls.Add(this.btnLogin);
			this.Name = "frmMain";
			this.Text = "Blogger Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ListBox lbInfo;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.ListBox lbBlogs;
		private System.Windows.Forms.ListBox lbPosts;
		private System.Windows.Forms.ListBox lbPages;
		private System.Windows.Forms.Button btnViewBlogInfo;
		private System.Windows.Forms.Button btnPostInfo;
		private System.Windows.Forms.TextBox txtHTML;
		private System.Windows.Forms.ListBox lbComments;
		private System.Windows.Forms.ListBox lbCommentsByPost;
	}
}

