using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using K2iSolution.AquaFarmingIoT.MultiTenancy;

namespace K2iSolution.AquaFarmingIoT.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
