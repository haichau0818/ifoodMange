using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
    public class DTO_Gender
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

		public DateTime ExpDate
		{
			get { return expdate; }
			set { expdate = value; }
		}

        public DTO_Gender(int Id, string Name, DateTime Expdate)
        {
            this.id= Id;
			this.Name= Name;
			this.ExpDate = Expdate;
        }
        public DTO_Gender()
        {
            
        }


    }
}
