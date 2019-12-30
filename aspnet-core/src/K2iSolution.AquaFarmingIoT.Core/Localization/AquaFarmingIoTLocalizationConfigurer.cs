using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace K2iSolution.AquaFarmingIoT.Localization
{
    public static class AquaFarmingIoTLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AquaFarmingIoTConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AquaFarmingIoTLocalizationConfigurer).GetAssembly(),
                        "K2iSolution.AquaFarmingIoT.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
