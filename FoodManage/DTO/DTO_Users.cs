using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
    public class DTO_Users
    {

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string fullname;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
     
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
		private int gender;

		public int Gender
		{
			get { return gender; }
			set { gender = value; }
		}
		private string phonenumber;

		public string Phonenumber
		{
			get { return phonenumber; }
			set { phonenumber = value; }
		}

		private DateTime dateofbird;

        public DateTime Dateofbird
        {
            get { return dateofbird; }
            set { dateofbird = value; }
        }

        private byte[] avatar;

		public byte[] Avatar
		{
			get { return avatar; }
			set { avatar = value; }
		}

		private int role;

		public int Role
		{
			get { return role; }
			set { role = value; }
		}


		public DTO_Users(
			int id,
			string fullname,
			string email,
			string password,
			string address,
			int gender,
			string phonenumber,
			DateTime dateofbird,
			byte[] avatar,
			int role
			)
		{
			this.id = id;
			this.fullname = fullname;
			this.email = email;
			this.password = password;
			this.address=address;
			this.gender=gender;
			this.phonenumber=phonenumber;
			this.dateofbird = dateofbird;
			this.avatar = avatar;
			this.role=role;

        }
		public DTO_Users()
		{
        }
        public DTO_Users(DataRow dr)
		{
			this.id = (int)dr["id"];
			this.fullname = dr["fullname"].ToString();
            this.email = dr["email"].ToString();
            this.password =dr["password"].ToString();
            this.address = dr["address"].ToString();
            this.gender = Convert.ToInt32(dr["gender"]);
            this.phonenumber=dr["phonenumber"].ToString();
            this.dateofbird=(DateTime)dr["dateofbird"];
            this.avatar = (byte[])dr["avatar"];
            this.role = (int)dr["role"];

        }


    }
}
