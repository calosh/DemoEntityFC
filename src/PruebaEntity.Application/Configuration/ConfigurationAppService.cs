using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PruebaEntity.Configuration.Dto;

namespace PruebaEntity.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PruebaEntityAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
