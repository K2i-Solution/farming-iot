using Abp.Application.Services;
using Abp.Application.Services.Dto;
using K2iSolution.AquaFarmingIoT.MultiTenancy.Dto;

namespace K2iSolution.AquaFarmingIoT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

