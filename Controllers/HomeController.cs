using EE_Commerce.Models;
using EEcomercEE.Datas;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EE_Commerce.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext context = new AppDbContext();

        public IActionResult index()
        {
            var products=context.Products.ToList();
            return View("index1", products);

        }











        public IActionResult productListing()
        {
            var products = context.Products.ToList();

            return View("productListing", products);

        }
        public IActionResult Checkout()
        {
            return View("Checkout");
        }


        public IActionResult Payment_Method()
        {
            return View("Payment_Method");
        }
        public IActionResult Shipping_Address()
        {
            return View("Shipping_Address");
        }
        public IActionResult forgot_password()
        {
            return View("forgot_password");
        }
        public IActionResult product_detail()
        {
            return View("product_detail");
        }


    }
}