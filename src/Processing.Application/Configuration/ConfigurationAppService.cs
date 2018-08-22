using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Processing.Configuration.Dto;

namespace Processing.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProcessingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
