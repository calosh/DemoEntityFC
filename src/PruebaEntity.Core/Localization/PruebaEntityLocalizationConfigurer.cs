using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PruebaEntity.Localization
{
    public static class PruebaEntityLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PruebaEntityConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PruebaEntityLocalizationConfigurer).GetAssembly(),
                        "PruebaEntity.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
