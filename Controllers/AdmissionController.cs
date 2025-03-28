using Microsoft.AspNetCore.Mvc;

namespace TourASBM.Controllers
{
    public class AdmissionController : Controller
    {
        public IActionResult Process() => View();
        public IActionResult Fee() => View();
        public IActionResult AdmissionProcess() => View();
        public IActionResult ApplicationForm() => View();
        public IActionResult OnlineFeePayment() => View();
        public IActionResult EducationLoanPortal() => View();
    }
}
