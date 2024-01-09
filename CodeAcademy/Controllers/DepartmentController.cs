using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
