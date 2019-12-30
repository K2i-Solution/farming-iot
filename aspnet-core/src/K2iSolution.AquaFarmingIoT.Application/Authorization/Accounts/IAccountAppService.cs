using System.Threading.Tasks;
using Abp.Application.Services;
using K2iSolution.AquaFarmingIoT.Authorization.Accounts.Dto;

namespace K2iSolution.AquaFarmingIoT.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
