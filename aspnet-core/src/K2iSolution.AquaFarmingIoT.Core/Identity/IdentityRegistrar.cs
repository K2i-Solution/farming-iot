using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using K2iSolution.AquaFarmingIoT.Authorization;
using K2iSolution.AquaFarmingIoT.Authorization.Roles;
using K2iSolution.AquaFarmingIoT.Authorization.Users;
using K2iSolution.AquaFarmingIoT.Editions;
using K2iSolution.AquaFarmingIoT.MultiTenancy;

namespace K2iSolution.AquaFarmingIoT.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
