namespace StudentManagementBasic
{
	partial class FormLogin
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.grbLogin = new System.Windows.Forms.GroupBox();
			this.chebShowpassword = new System.Windows.Forms.CheckBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grbLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(269, 298);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(388, 31);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(162, 53);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "LOG IN";
			// 
			// grbLogin
			// 
			this.grbLogin.Controls.Add(this.chebShowpassword);
			this.grbLogin.Controls.Add(this.btnLogin);
			this.grbLogin.Controls.Add(this.txtPassword);
			this.grbLogin.Controls.Add(this.txtUsername);
			this.grbLogin.Controls.Add(this.lblPassword);
			this.grbLogin.Controls.Add(this.lblUsername);
			this.grbLogin.Location = new System.Drawing.Point(288, 88);
			this.grbLogin.Name = "grbLogin";
			this.grbLogin.Size = new System.Drawing.Size(371, 241);
			this.grbLogin.TabIndex = 2;
			this.grbLogin.TabStop = false;
			// 
			// chebShowpassword
			// 
			this.chebShowpassword.AutoSize = true;
			this.chebShowpassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chebShowpassword.Location = new System.Drawing.Point(224, 121);
			this.chebShowpassword.Name = "chebShowpassword";
			this.chebShowpassword.Size = new System.Drawing.Size(121, 21);
			this.chebShowpassword.TabIndex = 3;
			this.chebShowpassword.Text = "Show Password";
			this.chebShowpassword.UseVisualStyleBackColor = true;
			this.chebShowpassword.CheckedChanged += new System.EventHandler(this.chebShowpassword_CheckedChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(203, 148);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(142, 43);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(132, 88);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(213, 27);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(132, 41);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(213, 27);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(17, 92);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(85, 23);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(17, 41);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(92, 23);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "UserName";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 340);
			this.Controls.Add(this.grbLogin);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOG IN";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grbLogin.ResumeLayout(false);
			this.grbLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grbLogin;
		private System.Windows.Forms.CheckBox chebShowpassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
	}
}

