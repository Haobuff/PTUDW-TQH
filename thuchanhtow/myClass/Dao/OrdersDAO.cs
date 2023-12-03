using myClass.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass.Dao
{
    public class OrdersDAO
    {
        //Copy noi dung cua class CATEGORIES, thay the Categories bang Suppliers
        private MyDBContext db = new MyDBContext();

        //SELECT * FROM ...
        public List<Orders> getList()
        {
            return db.Orders.ToList();
        }

        //SELECT * from cho Index chi voi status 1,2
        public List<Orders> getList(string status = "ALL")//status = 0,1,2
        {
            List<Orders> list = null;
            switch (status)
            {
                case "Index"://1,2
                    {
                        list = db.Orders.Where(m => m.Status != 0).ToList();
                        break;
                    }
                case "Trash"://0
                    {
                        list = db.Orders.Where(m => m.Status == 0).ToList();
                        break;
                    }
                default:
                    {
                        list = db.Orders.ToList();
                        break;
                    }
            }
            return list;
        }
        //details
        public Orders getRow(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return db.Orders.Find(id);
            }
        }

        //tao moi 
        public int Insert(Orders row)
        {
            db.Orders.Add(row);
            return db.SaveChanges();
        }

        //cap nhat mau tin
        public int Update(Orders row)
        {
            db.Entry(row).State = EntityState.Modified;
            return db.SaveChanges();
        }

        //xoa mau tin
        public int Delete(Orders row)
        {
            db.Orders.Remove(row);
            return db.SaveChanges();
        }
    }
}
