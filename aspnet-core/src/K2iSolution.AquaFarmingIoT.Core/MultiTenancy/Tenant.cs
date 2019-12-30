using Abp.MultiTenancy;
using K2iSolution.AquaFarmingIoT.Authorization.Users;

namespace K2iSolution.AquaFarmingIoT.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
