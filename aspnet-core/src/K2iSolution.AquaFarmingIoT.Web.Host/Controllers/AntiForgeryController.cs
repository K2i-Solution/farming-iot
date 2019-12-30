using Microsoft.AspNetCore.Antiforgery;
using K2iSolution.AquaFarmingIoT.Controllers;

namespace K2iSolution.AquaFarmingIoT.Web.Host.Controllers
{
    public class AntiForgeryController : AquaFarmingIoTControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
