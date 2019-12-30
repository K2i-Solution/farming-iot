using System.Threading.Tasks;
using Abp.Application.Services;
using K2iSolution.AquaFarmingIoT.Sessions.Dto;

namespace K2iSolution.AquaFarmingIoT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
