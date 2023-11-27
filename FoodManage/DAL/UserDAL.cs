using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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


        public DTO_Users login(string email, string password)
        {
            string qry = "USP_Login @email , @password";

            DataTable result= DataProvider.Instance.ExecuteQuery(qry, new object[]
            {
                email,
                password,
            });
            DTO_Users dt= new DTO_Users();
            foreach (DataRow dr in result.Rows)
            {
                //dt.id = dr["fullname"].ToString();
                dt.FullName = dr["fullname"].ToString();
                dt.Password = dr["password"].ToString();
                dt.Email = dr["email"].ToString();
                dt.Phonenumber = dr["phonenumber"].ToString();
                dt.Gender = Convert.ToBoolean(dr["gender"]);
                dt.Address = dr["address"].ToString();
                dt.Dateofbird = (dr["dateofbird"]==DBNull.Value) ? DateTime.MinValue.AddDays(1): Convert.ToDateTime(dr["dateofbird"]);
                dt.Role = (int)dr["role"];
                dt.Avatar = (dr["avatar"]== DBNull.Value) ? null : (byte[])(dr["avatar"]);

            }
            return dt;

        }

        public void insert(DTO_Users users)
        {
            string sql = @"USP_INSERT 
            @fullname ,
            @password ,
            @email ,
            @phonenumber ,
            @avatar ,
            @address ,
            @gender ,
            @role ,
            @dateofbird ";

            DataProvider.Instance.ExecuteNonQuery(sql,new object[]
            {
                users.FullName,
                users.Password,
                users.Email,
                users.Phonenumber,
                users.Avatar, 
                users.Address,
                users.Gender,
                users.Role,
                users.Dateofbird,
            });
        }
    }
}
