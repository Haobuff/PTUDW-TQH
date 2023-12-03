using myClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thuchanhtow.Models;

namespace thuchanhtow.Controllers
{
    public class CartController : Controller
    {
         MyDBContext db = new MyDBContext();


        public List<Cart> TakeACart()
        {
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart == null)
            {
                lstCart = new List<Cart>();
                Session["Cart"] = lstCart;
            }
            return lstCart;
        }

        public ActionResult AddToCart(int iMaSP, string strUrl)
        {
            List<Cart> lstCart = TakeACart();
            Cart product = lstCart.Find(n => n.iMaSP == iMaSP);
            if (product == null)
            {
                product = new Cart(iMaSP);
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
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart != null)
            {
                iTotalQuantity = lstCart.Sum(n => n.iSoLuong);
            }
            return iTotalQuantity;
        }
        private double TotalAmount()
        {
            double iTotalAmount = 0;
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart != null)
            {
                iTotalAmount = lstCart.Sum(n => n.dThanhTien);
            }
            return iTotalAmount;
        }
        public ActionResult Cart()
        {
            List<Cart> lstCart = TakeACart();
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
        public ActionResult DeleteCart(int iMaSP)
        {
            List<Cart> lstCart = TakeACart();
            Cart product = lstCart.SingleOrDefault(n => n.iMaSP == iMaSP);
            if (product != null)
            {
                lstCart.RemoveAll(n => n.iMaSP == iMaSP);
                return RedirectToAction("Cart");
            }
            if (lstCart.Count == 0)
            {
                return RedirectToAction("Index", "site");
            }
            return RedirectToAction("Cart");
        }

        public ActionResult UpdateCart(int iMaSP, FormCollection f)
        {
            List<Cart> lstCart = TakeACart();
            Cart product = lstCart.SingleOrDefault(n => n.iMaSP == iMaSP);
            if (product != null)
            {
                product.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("Cart");
        }
        public ActionResult DeleteAllCart()
        {
            List<Cart> lstCart = TakeACart();
            lstCart.Clear();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Order()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("Register", "Member");
            }
            if (Session["Cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            // lấy giỏ hàng từ session
            List<Cart> lstCart = TakeACart();
            ViewBag.TotalQuantity = TotalQuantity();
            ViewBag.TotalAmount = TotalAmount();
            return View(lstCart);
        }
        
        public ActionResult OrderSuccess()
        {
            return View();
        }

    }
}