using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementBasic
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text) == true)
			{
				txtUsername.Focus();
				errorProvider1.SetError(txtUsername, "Please fill the username!");
			}
			else if (string.IsNullOrEmpty(txtPassword.Text) == true)
			{
				txtUsername.Focus();
				errorProvider1.SetError(txtPassword, "Please fill the password!");
			}
			else
			{
				ForLoginForm myCheck = new ForLoginForm();
				if (myCheck.checkInformation(txtUsername.Text, txtPassword.Text) == true)
				{
					MessageBox.Show("Login Succecfully!!", "Status");
					FormMain frmMain = new FormMain();
					frmMain.ShowDialog();
				}
				else
				{
					MessageBox.Show("Login Fail. Please Try Again!", "Status");
				}
			}
		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtUsername.Text) == true)
			{
				txtUsername.Focus();
				errorProvider1.SetError(txtUsername, "Please fill the username!");
			}
			else
			{
				errorProvider1.Clear();
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPassword.Text) == true)
			{
				txtUsername.Focus();
				errorProvider1.SetError(txtPassword, "Please fill the password!");
			}
			else
			{
				errorProvider1.Clear();
			}
		}

		private void chebShowpassword_CheckedChanged(object sender, EventArgs e)
		{
			bool myCheck = chebShowpassword.Checked;
			switch(myCheck)
			{
				case true:
					txtPassword.UseSystemPasswordChar = false; break;
				default:
					txtPassword.UseSystemPasswordChar = true; break;
			}
		}
	}
}
