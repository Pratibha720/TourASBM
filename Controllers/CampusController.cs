using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class CampusController : Controller
    {
        public IActionResult Infrastructure() => View();
        public IActionResult Research() => View();
        public IActionResult LifeASBM() => View();
        public IActionResult FDP() => View();
        public IActionResult MDP() => View();
    }
}
