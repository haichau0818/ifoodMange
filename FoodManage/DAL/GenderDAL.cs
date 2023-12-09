using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DAL
{
    public class GenderDAL
    {
        #region singleton pattern
        private static GenderDAL instance;
        public static GenderDAL Instance
        {
            get
            {
                if (instance == null) instance = new GenderDAL();
                return instance;
            }
            private set => instance = value;
        }

        private GenderDAL() { }

        #endregion

        public List<DTO_Gender> GetAll() {

            string qry = @"Select * from genders";

            List<DTO_Gender> listGender = new List<DTO_Gender>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(qry);

            foreach (DataRow r in dt.Rows)
            {
                DTO_Gender gender = new DTO_Gender();
                gender.Id= Convert.ToInt32(r["id"]);
                gender.Name = Convert.ToString(r["name"]);
                gender.ExpDate = (r["expDate"] == DBNull.Value) ? DateTime.MinValue.AddDays(1) : Convert.ToDateTime(r["expDate"]);
                listGender.Add(gender);
            }
            return listGender;
        }


    }
}
