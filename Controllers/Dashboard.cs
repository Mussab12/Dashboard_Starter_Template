using Microsoft.AspNetCore.Mvc;

namespace Dashboard_Starter_Template.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult MainPage()
        {
            return View();
        }
    }
}
