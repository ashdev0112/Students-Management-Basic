using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentManagementBasic
{
	public class ForLoginForm
	{
		private string constr = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

		public bool checkInformation(string Username, string Password)
		{
			SqlConnection con = new SqlConnection(constr);
			string query = "select * from M_User where UserName = @user and UserPassword = @password";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@user", Username);
			cmd.Parameters.AddWithValue("@password", Password);

			con.Open();
			SqlDataReader reder = cmd.ExecuteReader();
			if(reder.HasRows == true )
			{
				return true;
			}
			else return false; 
			con.Close();
		}
	}
}
