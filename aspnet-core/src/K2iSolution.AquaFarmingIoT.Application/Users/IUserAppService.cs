using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using K2iSolution.AquaFarmingIoT.Roles.Dto;
using K2iSolution.AquaFarmingIoT.Users.Dto;

namespace K2iSolution.AquaFarmingIoT.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
