using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using K2iSolution.AquaFarmingIoT.Configuration;

namespace K2iSolution.AquaFarmingIoT.Web.Host.Startup
{
    [DependsOn(
       typeof(AquaFarmingIoTWebCoreModule))]
    public class AquaFarmingIoTWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AquaFarmingIoTWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AquaFarmingIoTWebHostModule).GetAssembly());
        }
    }
}
