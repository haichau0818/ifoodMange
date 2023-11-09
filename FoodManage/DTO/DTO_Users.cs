using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
    public class DTO_Users
    {
		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private byte[] avatar;

		public byte[] Avatar
		{
			get { return avatar; }
			set { avatar = value; }
		}

		public DTO_Users(string username, string password,string email, string name, byte[] avatar)
		{
			this.username = username;
			this.password= password;
			this.email = email;	
			this.name = name;
			this.avatar= avatar;

		}
		public DTO_Users()
		{
        }
        public DTO_Users(DataRow dr)
		{
			this.username = dr["username"].ToString();
			this.password = dr["password"].ToString();
			this.email = dr["email"].ToString();
			this.name = dr["name"].ToString();
			this.avatar = (byte[])dr["avatar"];

        }


    }
}
