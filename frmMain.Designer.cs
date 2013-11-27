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
			this.lbInfo.Location = new System.Drawing.Point(12, 122);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(447, 303);
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
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 446);
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
	}
}

