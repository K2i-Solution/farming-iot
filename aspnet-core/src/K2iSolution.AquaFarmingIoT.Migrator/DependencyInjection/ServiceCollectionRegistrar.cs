using Microsoft.Extensions.DependencyInjection;
using Castle.Windsor.MsDependencyInjection;
using Abp.Dependency;
using K2iSolution.AquaFarmingIoT.Identity;

namespace K2iSolution.AquaFarmingIoT.Migrator.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static void Register(IIocManager iocManager)
        {
            var services = new ServiceCollection();

            IdentityRegistrar.Register(services);

            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
        }
    }
}
