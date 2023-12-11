using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
    public class DTO_FoodCategory
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
        public DTO_FoodCategory()
        {
				
        }
        public DTO_FoodCategory(int id, string name, DateTime expdate)
        {
			this.id	= id;
            this.name = name;
			this.expdate = expdate;
        }


    }
}
