using Microsoft.AspNetCore.Mvc;

namespace ContractClaimSystem.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult VerifyClaims()
        {
            return View();
        }
    }
}
