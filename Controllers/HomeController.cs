using Microsoft.AspNetCore.Mvc;

namespace TP_CALCULADORA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
