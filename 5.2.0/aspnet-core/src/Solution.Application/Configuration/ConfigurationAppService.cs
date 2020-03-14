using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Solution.Configuration.Dto;

namespace Solution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
