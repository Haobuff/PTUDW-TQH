using myClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thuchanhtow.Controllers
{
    public class CartController : Controller
    {
        private MyDBContext db = new MyDBContext();
        private int id;
        private int iSoLuong;
        private int dThanhTien;

        public CartController(int id)
        {
        }

        // GET: Cart
        public List<CartController> TakeACart()
        {
            List<CartController> lstCart = Session["Cart"] as List<CartController>;
            if (lstCart == null)
            {
                lstCart = new List<CartController>();
                Session["Cart"] = lstCart;
            }
            return lstCart;
        }

        public ActionResult AddToCart(int id, string strUrl)
        {
            List<CartController> lstCart = TakeACart();
            CartController product = lstCart.Find(n => n.id == id);
            if (product == null)
            {
                product = new CartController(id);
                lstCart.Add(product);
                return Redirect(strUrl);
            }
            else
            {
                product.iSoLuong++;
                return Redirect(strUrl);
            }

        }
        private int TotalQuantity()
        {
            int iTotalQuantity = 0;
            List<CartController> lstCart = Session["Cart"] as List<CartController>;
            if (lstCart != null)
            {
                iTotalQuantity = lstCart.Sum(n => n.iSoLuong);
            }
            return iTotalQuantity;
        }
        private double TotalAmount()
        {
            double iTotalAmount = 0;
            List<CartController> lstCart = Session["Cart"] as List<CartController>;
            if (lstCart != null)
            {
                iTotalAmount = lstCart.Sum(n => n.dThanhTien);
            }
            return iTotalAmount;
        }
        public ActionResult Cart()
        {
            List<CartController> lstCart = TakeACart();
            if (lstCart.Count == 0)
            {
                return RedirectToAction("Index", "Cart");
            }
            ViewBag.TotalQuantity = TotalQuantity();
            ViewBag.TotalAmount = TotalAmount();
            return View(lstCart);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CartPartial()
        {
            ViewBag.TotalQuantity = TotalQuantity();
            ViewBag.TotalAmount = TotalAmount();
            return PartialView();
        }
        public ActionResult DeleteCart(int id)
        {
            List<CartController> lstCart = TakeACart();
            CartController product = lstCart.SingleOrDefault(n => n.id == id);
            if (product != null)
            {
                lstCart.RemoveAll(n => n.id == id);
                return RedirectToAction("Cart");
            }
            if (lstCart.Count == 0)
            {
                return RedirectToAction("Index", "Home_63132535");
            }
            return RedirectToAction("Cart");
        }
    }
}