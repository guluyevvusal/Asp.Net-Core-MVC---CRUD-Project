using Microsoft.AspNetCore.Mvc;
using MVC___CRUD_Project.Models;

namespace MVC___CRUD_Project.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductContext context;

        public ProductsController(ProductContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p=>p.Id).ToList();
            return View(products);
        }


        public IActionResult Create()
        {
            
            return View();
        }
    }
}
