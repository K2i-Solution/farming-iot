using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using K2iSolution.AquaFarmingIoT.Authorization;

namespace K2iSolution.AquaFarmingIoT
{
    [DependsOn(
        typeof(AquaFarmingIoTCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AquaFarmingIoTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AquaFarmingIoTAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AquaFarmingIoTApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
