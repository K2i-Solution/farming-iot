using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using K2iSolution.AquaFarmingIoT.EntityFrameworkCore.Seed;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore
{
    [DependsOn(
        typeof(AquaFarmingIoTCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AquaFarmingIoTEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AquaFarmingIoTDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AquaFarmingIoTDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AquaFarmingIoTDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AquaFarmingIoTEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
