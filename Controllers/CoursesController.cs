using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult PGDM() => View();
        public IActionResult DataScience() => View();
        public IActionResult BusinessAnalytics() => View();
    }
}
