using Abp.AutoMapper;
using K2iSolution.AquaFarmingIoT.Authentication.External;

namespace K2iSolution.AquaFarmingIoT.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
