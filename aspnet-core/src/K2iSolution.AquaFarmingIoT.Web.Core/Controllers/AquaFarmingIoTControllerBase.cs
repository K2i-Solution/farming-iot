using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace K2iSolution.AquaFarmingIoT.Controllers
{
    public abstract class AquaFarmingIoTControllerBase: AbpController
    {
        protected AquaFarmingIoTControllerBase()
        {
            LocalizationSourceName = AquaFarmingIoTConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
