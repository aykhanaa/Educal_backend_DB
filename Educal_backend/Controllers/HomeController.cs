
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Educal_backend.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }
    }
}
