using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using K2iSolution.AquaFarmingIoT.Configuration;
using K2iSolution.AquaFarmingIoT.Web;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AquaFarmingIoTDbContextFactory : IDesignTimeDbContextFactory<AquaFarmingIoTDbContext>
    {
        public AquaFarmingIoTDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AquaFarmingIoTDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AquaFarmingIoTDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AquaFarmingIoTConsts.ConnectionStringName));

            return new AquaFarmingIoTDbContext(builder.Options);
        }
    }
}
