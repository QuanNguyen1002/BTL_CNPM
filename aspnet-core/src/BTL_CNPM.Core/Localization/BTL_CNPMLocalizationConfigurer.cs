using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BTL_CNPM.Localization
{
    public static class BTL_CNPMLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BTL_CNPMConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BTL_CNPMLocalizationConfigurer).GetAssembly(),
                        "BTL_CNPM.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
