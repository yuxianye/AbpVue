using System.Threading.Tasks;
using Solution.Configuration.Dto;

namespace Solution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
