using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace K2iSolution.AquaFarmingIoT.EntityFrameworkCore
{
    public static class AquaFarmingIoTDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AquaFarmingIoTDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AquaFarmingIoTDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
