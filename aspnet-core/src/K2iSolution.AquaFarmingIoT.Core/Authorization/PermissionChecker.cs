using Abp.Authorization;
using K2iSolution.AquaFarmingIoT.Authorization.Roles;
using K2iSolution.AquaFarmingIoT.Authorization.Users;

namespace K2iSolution.AquaFarmingIoT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
