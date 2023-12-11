using FoodManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DAL
{
    public class FoodDAL
    {
        #region singleton pattern
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return instance;
            }
            private set => instance = value;
        }

        private FoodDAL() { }

        #endregion


        public List<DTO_Foods> GetAll() {
        
            List<DTO_Foods> listTableFood= new List<DTO_Foods>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM foods");


            foreach (DataRow row in data.Rows) {

                DTO_Foods dt = new DTO_Foods(row);

                listTableFood.Add(dt);

            }
            return listTableFood;
        }
        public DTO_Foods GetById(int id)
        {
            DTO_Foods food = new DTO_Foods();
            return food;
        }
        public DTO_Foods Search(string key)
        {
            DTO_Foods food = new DTO_Foods();
            return food;
        }

        public bool Insert(DTO_Foods food) {
            return true;
        }
        public bool Update(DTO_Foods food)
        {
            return true;
        }
        public bool Delete(int id)
        {
            return true;
        }
    }

}
