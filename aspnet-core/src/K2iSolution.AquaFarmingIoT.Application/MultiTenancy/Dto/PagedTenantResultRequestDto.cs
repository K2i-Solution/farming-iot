using Abp.Application.Services.Dto;

namespace K2iSolution.AquaFarmingIoT.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

