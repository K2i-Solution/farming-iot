using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using K2iSolution.AquaFarmingIoT.Authorization.Roles;
using K2iSolution.AquaFarmingIoT.Authorization.Users;
using K2iSolution.AquaFarmingIoT.MultiTenancy;

namespace K2iSolution.AquaFarmingIoT.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(
                  options, 
                  signInManager, 
                  systemClock)
        {
        }
    }
}
