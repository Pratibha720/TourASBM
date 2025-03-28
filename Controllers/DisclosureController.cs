using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class DisclosureController : Controller
    {
        public IActionResult MandatoryDisclosure() => View();
        public IActionResult AICTE() => View();
    }
}
