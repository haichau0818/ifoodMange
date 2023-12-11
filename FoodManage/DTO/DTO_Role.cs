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

		private bool isActive;

		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		private bool isDelete;

		public bool IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}

		public DTO_Role()
		{

		}
		public DTO_Role(int id, string name, DateTime expdate,bool isActive, bool isDelete)
		{
			this.id = id;
			this.name = name;
			this.expdate = expdate;
			this.isActive = isActive;
			this.isDelete = isDelete;
		}
		public DTO_Role(DataRow dr)
		{
			this.id = (int)dr["id"];
			this.name = (string)dr["name"];
			this.expdate = (dr["expDate"] == DBNull.Value) ? DateTime.MinValue.AddDays(1) : (DateTime)dr["expDate"];
			this.isActive = (bool)dr["isActive"];
			this.isDelete = (bool)dr["isDelete"];

        }
	} 
}
