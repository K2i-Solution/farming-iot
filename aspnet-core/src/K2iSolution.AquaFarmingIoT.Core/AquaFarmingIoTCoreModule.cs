using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using K2iSolution.AquaFarmingIoT.Authorization.Roles;
using K2iSolution.AquaFarmingIoT.Authorization.Users;
using K2iSolution.AquaFarmingIoT.Configuration;
using K2iSolution.AquaFarmingIoT.Localization;
using K2iSolution.AquaFarmingIoT.MultiTenancy;
using K2iSolution.AquaFarmingIoT.Timing;

namespace K2iSolution.AquaFarmingIoT
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AquaFarmingIoTCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AquaFarmingIoTLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AquaFarmingIoTConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AquaFarmingIoTCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
