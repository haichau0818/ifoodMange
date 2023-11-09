using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodManage.DTO
{
    public class DTO_Foods
    {
        private int iD;
        private string name;
        private double price;
        private int quantity;
        private DateTime dateImport;
        private DateTime dateExport;
        private DateTime expDate;
        private byte[] image;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public DateTime DateImport { get => dateImport; set => dateImport = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime DateExport { get => dateExport; set => dateExport = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }
        //public byte[] Image { get => image; set => image = value; }
     

        public DTO_Foods(int id, string name, double price,int quantity,DateTime dateImport,DateTime dateExport,DateTime expDate /*byte[] image*/)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.DateImport = dateImport;
            this.DateExport = dateExport;
            this.ExpDate = expDate; 
            //this.Image = image;
            
        }


        public DTO_Foods(DataRow row) {

            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = Convert.ToDouble(row["price"]);
            this.Quantity = (int)row["quantity"];
            this.DateImport = Convert.ToDateTime(row["dateImport"]);
            this.DateExport = Convert.ToDateTime(row["dateExport"]);
            this.ExpDate = Convert.ToDateTime(row["expDate"]);
            //this.Image = (byte[])row["img"];
        }
    }
}
