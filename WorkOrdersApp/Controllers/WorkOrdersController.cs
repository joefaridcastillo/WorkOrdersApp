using Microsoft.AspNetCore.Mvc;

namespace WorkOrdersApp.Controllers
{
    public class WorkOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
