using Microsoft.Data.SqlClient;
using System;
using Microsoft.Data.Sql;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Reflection.Metadata;

namespace FoodManage.DAL
{
    public class DataProvider
    {

        private static DataProvider instance;


        public static DataProvider Instance{
            get
            {
                if (instance==null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value; 
        }

        private DataProvider() { }


        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FoodManage;Integrated Security=True;TrustServerCertificate=true";
        public DataTable ExecuteQuery(string qry, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection  conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(qry, conn);

                if (parameter != null)
                {
                    string[] listPara = qry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);

                conn.Close();
            }

            return data;

        }

        public int ExecuteNonQuery(string qry, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(qry, conn);

                if (parameter != null)
                {
                    string[] listPara = qry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();

                conn.Close();
            }

            return data;

        }

        public object ExecuteScalar(string qry, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(qry, conn);

                if (parameter != null)
                {
                    string[] listPara = qry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data =cmd.ExecuteScalar();

                conn.Close();
            }

            return data;

        }
    }
}
