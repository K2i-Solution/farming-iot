using System.Collections.Generic;

namespace K2iSolution.AquaFarmingIoT.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
