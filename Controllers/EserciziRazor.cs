using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class EserciziRazor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
