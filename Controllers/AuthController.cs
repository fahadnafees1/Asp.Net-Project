using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registor()
        {

            return View();
        }
    }
}
  