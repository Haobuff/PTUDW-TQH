using myClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thuchanhtow.Models
{
    public class Cart
    {
        MyDBContext db = new MyDBContext();
        public int iMaSP { set; get; }
        public string sTenSP { set; get; }
        public double dGiaBan { set; get; }
        public string sAnhDD { set; get; }
        public int iSoLuong { set; get; }
        public double dThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }
        public Cart(int MaSP)
        {
            iMaSP = MaSP;
            Products product = db.Products.Single(n => n.Id == iMaSP);
            sTenSP = product.Name;
            sAnhDD = product.Img;
            dGiaBan = double.Parse(product.SalePrice.ToString());
            iSoLuong = 1;
        }
    }
}