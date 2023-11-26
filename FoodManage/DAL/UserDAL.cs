using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DAL
{
    public class UserDAL
    {
        #region singleton pattern
        private static UserDAL instance;
        public static UserDAL Instance
        {
            get
            {
                if (instance == null) instance = new UserDAL();
                return instance;
            }
            private set => instance = value;
        }

        private UserDAL() { }

        #endregion


        public DTO_Users login(string username, string password)
        {
            string qry = "USP_Login @userName , @password";

            DataTable result= DataProvider.Instance.ExecuteQuery(qry, new object[]
            {
                username,
                password,
            });
            DTO_Users dt= new DTO_Users();
            foreach (DataRow dr in result.Rows)
            {
                dt.Username = dr["username"].ToString();
                dt.Password = dr["password"].ToString();
                dt.Email = dr["email"].ToString();
                dt.Name = dr["name"].ToString();
            }
            return dt;

        }





    }
}
