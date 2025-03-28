using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Differentiators() => View();
        public IActionResult Message() => View();
        public IActionResult Faculty() => View();
        public IActionResult Academic() => View();
        public IActionResult Organogram() => View();
        public IActionResult MediaSpeaks() => View();
    }
}
