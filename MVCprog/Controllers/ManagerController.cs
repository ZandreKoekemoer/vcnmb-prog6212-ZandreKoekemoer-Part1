using Microsoft.AspNetCore.Mvc;

namespace ContractClaimSystem.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult FinalApproval()
        {
            return View();
        }
    }
}
