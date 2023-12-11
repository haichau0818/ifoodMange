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
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
		private DateTime dateImport;

		public DateTime DateImport
		{
			get { return dateImport; }
			set { dateImport = value; }
		}
		private DateTime dateExport;

		public DateTime DateExport
		{
			get { return dateExport; }
			set { dateExport = value; }
		}
		private DateTime expDate;

		public DateTime ExpDate
		{
			get { return expDate; }
			set { expDate = value; }
		}
		private byte[] image;

		public byte[] Image
		{
			get { return image; }
			set { image = value; }
		}
		private bool isActive;

		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}
		private bool isDelete;

		public bool IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}
		private string producer;

		public string Producer
		{
			get { return producer; }
			set { producer = value; }
		}

        public DTO_Foods()
        {
            
        }
        public DTO_Foods(int id, string name, double price, int quantity, DateTime dateImport,DateTime dateExport, DateTime expDate, byte[] image,  string producer,bool isDelete,bool isActive)
        {
			this.id = id;
			this.name = name;
			this.price = price;
			this.quantity = quantity;
			this.dateImport = dateImport;
			this.dateExport	= dateExport;
			this.expDate = expDate;
			this.image = image;
			this.producer = producer;
			this.isActive = isActive;
			this.isDelete = isDelete;	
        }

        public DTO_Foods(DataRow dr)
        {
            this.id = (int)dr["id"];
            this.name = (string)dr["name"];
            this.price = (double)dr["price"];
            this.quantity = (int)dr["quantity"];
            this.dateImport = dr["dateImport"]==DBNull.Value ? DateTime.MinValue.AddDays(1): (DateTime)dr["dateImport"];
            this.dateExport = dr["dateExport"] == DBNull.Value ? DateTime.MinValue.AddDays(1) : (DateTime)dr["dateExport"];
            this.expDate = dr["expDate"] == DBNull.Value ? DateTime.MinValue.AddDays(1) : (DateTime)dr["expDate"];
            this.image = dr["image"] == DBNull.Value ? null : (byte[])dr["image"];
            this.producer = (string)dr["producer"];
            this.isActive = (bool)dr["isActive"];
            this.isDelete = (bool)dr["isDelete"];
        }

    }
}
