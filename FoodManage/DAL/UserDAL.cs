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


        public List<DTO_Users> GetAll()
        {

            List<DTO_Users> listUser = new List<DTO_Users>();

            string qry = @"USP_GetAll";

            DataTable result = DataProvider.Instance.ExecuteQuery(qry);
            foreach (DataRow dr in result.Rows)
            {
                DTO_Users dt = new DTO_Users(dr);
                listUser.Add(dt);
            }
            return listUser;

        }

        public bool CheckEmail(string email)
        {
            string qry = @"Select email from users where email = '" + email + "'";
            var value = DataProvider.Instance.ExecuteScalar(qry);
            if (value!=null)
                return true;
            else
                return false;
        }
        public DTO_Users Login(string email, string password)
        {
            string qry = "USP_Login @email , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(qry, new object[]
            {
                email,
                password,
            });
            DTO_Users dt = new DTO_Users();
            foreach (DataRow dr in result.Rows)
            {
                dt = new DTO_Users(dr);
            }
            return dt;

        }

        public bool Insert(DTO_Users users)
        {
            string sql = @"USP_INSERT 
                            @fullName ,
                            @password ,
                            @email ,
                            @phoneNumber ,
                            @avatar ,
                            @address ,
                            @gender ,
                            @role ,
                            @dateOfBird ,
                            @isDelete , 
                            @isActive ";
            try
            {
                //insert user with paramater
                DataProvider.Instance.ExecuteNonQuery(sql, new object[]
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
                                                                            users.IsDelete,
                                                                            users.IsActive
                                                                        });

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool Delete(int id)
        {
            string qry = @"Update users set isDelete = true where id = '" + id + "' ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(qry);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public bool HardDelete(int id)
        {
            string qry = @"Delete from users where id = " + id + "";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(qry);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DTO_Users GetById(int id)
        {
            string qry = @"select * from users where id = " + id + "";
            DTO_Users user = new DTO_Users();
            DataTable dt = DataProvider.Instance.ExecuteQuery(qry);
            foreach (DataRow dr in dt.Rows)
            {
                user = new DTO_Users(dr);
            }
            return user;
        }
    }
}
