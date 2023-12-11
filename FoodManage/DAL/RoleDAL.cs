using FoodManage.DTO;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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



        public List<DTO_Role> GetAll() {

            string qry = @"select * from roles";
            List<DTO_Role> listRole = new List<DTO_Role>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(qry);

            foreach (DataRow dr in dt.Rows)
            {
                DTO_Role dTO_Role = new DTO_Role(dr);
                listRole.Add(dTO_Role);
            }
            return listRole;
        }

        public DTO_Role GetById(int id)
        {
            string qry = @"select * from roles where id = " + id + "";
            DTO_Role role = new DTO_Role();
            var getrole = DataProvider.Instance.ExecuteQuery(qry); 
            foreach(DataRow dr in getrole.Rows)
            {
                role = new DTO_Role(dr);
            }
            return role;
        }
        public List<DTO_Role> Search(string key)
        {
            // fuConvertToUnSign convert key to key unsign
            string sql = string.Format("select * from roles where dbo.fuConvertToUnsign(name) like N'%' + dbo.fuConvertToUnsign(N'{0}') + '%'", key);
            List<DTO_Role> listRole = new List<DTO_Role>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DTO_Role role = new DTO_Role( dr );
                listRole.Add(role);
            }
            return listRole;
        }
        public bool Insert(DTO_Role role)
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
        public bool Update(DTO_Role role)
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
