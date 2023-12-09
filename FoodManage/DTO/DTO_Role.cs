using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
	public class DTO_Role
	{
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private DateTime expdate;

		public DateTime Expdate
		{
			get { return expdate; }
			set { expdate = value; }
		}
		public DTO_Role()
		{

		}
		public DTO_Role(int id, string name, DateTime expdate)
		{
			this.id = id;
			this.name = name;
			this.expdate = expdate;
		}
		public DTO_Role(DataRow dr)
		{
			this.id = (int)dr["id"];
			this.name = dr["name"].ToString();
			this.expdate = Convert.ToDateTime(dr["expdate"]);

        }
	} 
}
