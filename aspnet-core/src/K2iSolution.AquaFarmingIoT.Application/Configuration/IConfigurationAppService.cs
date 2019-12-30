using System.Threading.Tasks;
using K2iSolution.AquaFarmingIoT.Configuration.Dto;

namespace K2iSolution.AquaFarmingIoT.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
