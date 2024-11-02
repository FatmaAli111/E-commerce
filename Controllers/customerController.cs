
using EEcomercEE.Models.Datas;
using EEcomercEE.Models.Entitiess;
using Microsoft.AspNetCore.Mvc;

namespace EEcomercEE.Controllers
{
    public class customerController : Controller
    {
        AppDbContext context = new AppDbContext();

        public IActionResult Order_Summary()
        {
            return View("Order_Summary");
        }
        [HttpGet]
        public IActionResult Shipping_Address()
        {
            return View("Shipping_Address");
        }


        [HttpPost]
        public IActionResult AddNewCustomer(Customer custfromrequest)
        {

            context.Add(custfromrequest);
            context.SaveChanges();

            return View("Shipping_Address");
        }
        public IActionResult shipping()
        {
            var cust = context.Customers.ToList();
            return View("_shipping", cust);
        }
    }
}
