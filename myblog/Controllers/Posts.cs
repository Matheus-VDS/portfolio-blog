using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers;

public class Posts : Controller
{
    // GET
    public IActionResult Home()
    {
        return View();
    }
}