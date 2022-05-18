using Microsoft.AspNetCore.Mvc;

namespace Web2._6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
