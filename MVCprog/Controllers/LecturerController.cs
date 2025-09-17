using Microsoft.AspNetCore.Mvc;

namespace ContractClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult TrackClaim()
        {
            return View();
        }
    }
}
