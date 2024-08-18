using Microsoft.AspNetCore.Mvc;
using MVC___CRUD_Project.Models;

namespace MVC___CRUD_Project.Controllers
{
    public class MenController : Controller
    {
        private readonly MenContext context;

        public MenController(MenContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var men = context.Mens.ToList();
            return View(men);
        }
    }
}
