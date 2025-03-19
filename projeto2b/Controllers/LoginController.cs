using Microsoft.AspNetCore.Mvc;

namespace projeto2b.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
