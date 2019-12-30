using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using K2iSolution.AquaFarmingIoT.Configuration;
using K2iSolution.AquaFarmingIoT.EntityFrameworkCore;
using K2iSolution.AquaFarmingIoT.Migrator.DependencyInjection;

namespace K2iSolution.AquaFarmingIoT.Migrator
{
    [DependsOn(typeof(AquaFarmingIoTEntityFrameworkModule))]
    public class AquaFarmingIoTMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AquaFarmingIoTMigratorModule(AquaFarmingIoTEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AquaFarmingIoTMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AquaFarmingIoTConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AquaFarmingIoTMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
