using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DAL
{
    public class RoleDAL
    {
        #region singleton pattern
        private static RoleDAL instance;
        public static RoleDAL Instance
        {
            get
            {
                if (instance == null) instance = new RoleDAL();
                return instance;
            }
            private set => instance = value;
        }

        private RoleDAL() { }

        #endregion



        public List<DTO_Role> GetRole() {

            string qry = @"select * from roles";
            List<DTO_Role> listRole = new List<DTO_Role>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(qry);

            foreach (DataRow dr in dt.Rows)
            {
                DTO_Role dTO_Role = new DTO_Role();
                dTO_Role.Id = (int)dr["id"];
                dTO_Role.Name = dr["name"].ToString();
                dTO_Role.Expdate = (dr["expdate"] == DBNull.Value) ? DateTime.MinValue.AddDays(1) : Convert.ToDateTime(dr["expdate"]);

                listRole.Add(dTO_Role);
            }
            return listRole;
        }
    }
}
