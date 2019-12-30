using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using K2iSolution.AquaFarmingIoT.Configuration.Dto;

namespace K2iSolution.AquaFarmingIoT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AquaFarmingIoTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
