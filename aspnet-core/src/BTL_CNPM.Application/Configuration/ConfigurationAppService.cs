using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BTL_CNPM.Configuration.Dto;

namespace BTL_CNPM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BTL_CNPMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
