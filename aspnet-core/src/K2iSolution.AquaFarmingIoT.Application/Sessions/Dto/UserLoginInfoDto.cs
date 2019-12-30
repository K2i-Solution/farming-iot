using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using K2iSolution.AquaFarmingIoT.Authorization.Users;

namespace K2iSolution.AquaFarmingIoT.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
