using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class PlacementController : Controller
    {
        public IActionResult Recruiters() => View();
        public IActionResult StudentBatch2022_2024() => View();
    }
}
