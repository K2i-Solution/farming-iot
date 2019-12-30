using Abp.Application.Services.Dto;

namespace K2iSolution.AquaFarmingIoT.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

