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

        public DTO_Gender GetById(int id)
        {
            DTO_Gender gender = new DTO_Gender();
            return gender;
        }
        public List<DTO_Gender> Search(string key)
        {
            // fuConvertToUnSign convert key to key unsign
            string sql = string.Format("select * from genders where dbo.fuConvertToUnsign(name) like N'%' + dbo.fuConvertToUnsign(N'{0}') + '%'", key);
            List<DTO_Gender> listGender = new List<DTO_Gender>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DTO_Gender gender = new DTO_Gender(dr);
                listGender.Add(gender);
            }
            return listGender;
        }
        public bool Insert(DTO_Gender gender)
        {
            string qry = @"";
            try
            {
                int count = DataProvider.Instance.ExecuteNonQuery(qry);
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Update(DTO_Gender gender)
        {
            string qry = @"";
            try
            {
                int count = DataProvider.Instance.ExecuteNonQuery(qry);
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            string qry = @"";
            try
            {
                int count = DataProvider.Instance.ExecuteNonQuery(qry);
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool HardDelete(int id)
        {
            string qry = @"";
            try
            {
                int count = DataProvider.Instance.ExecuteNonQuery(qry);
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }




    }
}
