using myClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;



namespace thuchanhtow.Controllers
{
    public class siteController : Controller
    {
        // GET: site
    MyDBContext db = new MyDBContext();//tạo mới mẫu tin
        public ActionResult Index(int? page)
        {
            int pageSize = 6; // Số sản phẩm trên 1 trang
            int pageNumber = (page ?? 1); // Trang hiện tại, mặc định là trang đầu tiên

            var products = db.Products.OrderBy(p => p.Name); // Sắp xếp danh sách sản phẩm theo tên

            return View(products.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Brand()
        {
            var suppliers = from c in db.Suppliers select c;
            return PartialView(suppliers);
        }
        public ActionResult ListByBrand(int id)
        {
            var products = from p in db.Products where p.SupplierId == id select p;
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = from p in db.Products where p.Id == id select p;
            return View(product.Single());
        }


    }
}